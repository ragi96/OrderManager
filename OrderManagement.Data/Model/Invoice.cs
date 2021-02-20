using Smartive.Core.Database.Models;
using System;

namespace OrderManagement.Data.Model
{
    public class Invoice : Base
    {
        public DateTime Date { get; set; }

        public Order Order { get; set; }
    }
}
