using Smartive.Core.Database.Models;
using System;
using System.Collections.Generic;

namespace OrderManagement.Data.Model
{
    public class Customer : Base
    {

        public string Prename { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string StreetNr { get; set; } = string.Empty;

        public string Zip { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string CountryCode { get; set; } = string.Empty;

        public string Fullname
        {
            get => this.Prename + " " + this.Lastname;
        }

        public bool Deleted { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
