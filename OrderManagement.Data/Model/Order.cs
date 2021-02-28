using Smartive.Core.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace OrderManagement.Data.Model
{
    public class Order : Base
    {
        public DateTime Date { get; set; }

        [ForeignKey("Customer")] 
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime? InvoiceDate { get; set; } 
        public virtual List<Position> Positions { get; set; } 

        public string CustomerName
        {
            get => Customer.Fullname;
        }

        public string CustomerStreet
        {
            get => Customer.Street;
        }

        public string CustomerZip
        {
            get => Customer.Zip;
        }

        public string CustomerCity
        {
            get => Customer.City;
        }

        public string CustomerCountry
        {
            get => Customer.CountryCode;
        }

        public double PriceNetto
        {
            get
            {
                return Positions.Sum(pos => pos.ArticlePrice * pos.Amount);
            }
        }

        public double PriceBrutto
        {
            get
            {
                return Positions.Sum(pos => (pos.ArticlePrice * pos.Amount) * ((pos.Article.Mwst / 100) + 1));
            }
        }
    }
}