using Smartive.Core.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Data.Model
{
    public class Article : Base
    {
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public double Mwst { get; set; }

        [ForeignKey("ArticleGroup")]
        public int? ArticleGroupId { get; set; }
        public virtual ArticleGroup ArticleGroup { get; set; }

        public ICollection<Position> Positions { get; set; }
    }
}
