using Smartive.Core.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Data.Model
{
    public class Order : Base
    {
        public DateTime Date { get; set; } = DateTime.Now;

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }        
        public Customer Customer { get; set; }

        public DateTime? InvoiceDate { get; set; } = null;

        public virtual List<Position> Positions { get; set; } = null;
    }
}