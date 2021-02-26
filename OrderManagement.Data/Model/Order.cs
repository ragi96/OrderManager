using Smartive.Core.Database.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Data.Model
{
    public class Order : Base
    {
        public DateTime Date { get; set; } = DateTime.Now;

        public int? CustomerId { get; set; } 
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public DateTime? InvoiceDate { get; set; } = null;
    }
}
