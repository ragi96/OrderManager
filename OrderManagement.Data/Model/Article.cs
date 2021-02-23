using Smartive.Core.Database.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Data.Model
{
    public class Article : Base
    {
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public double Mwst { get; set; }

        public int? ArticleGroupId { get; set; }
        [ForeignKey("ArticleGroupId")]
        public virtual ArticleGroup ArticleGroup { get; set; } = new ArticleGroup();
    }
}
