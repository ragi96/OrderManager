using Smartive.Core.Database.Models;
using System;

namespace OrderManagement.Data.Model
{
    public class Order : Base
    {
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
    }
}
