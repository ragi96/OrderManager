using Smartive.Core.Database.Models;
using System;

namespace OrderManagement.Data.Model
{
    public class Article : Base
    {
        public DateTime ValidFrom { get; set; }

        public int Number { get; set; }

        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }

        public double Mwst { get; set; }

        public ArticleGroup ArticleGroup { get; set; } = new ArticleGroup();
    }
}
