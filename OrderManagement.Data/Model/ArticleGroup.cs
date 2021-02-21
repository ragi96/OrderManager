using System.ComponentModel.DataAnnotations.Schema;
using Smartive.Core.Database.Models;

namespace OrderManagement.Data.Model
{
    public class ArticleGroup : Base
    {
        public string Name { get; set; } = string.Empty;
        public int? SuperiorArticleId { get; set; }

        [ForeignKey("SuperiorArticleId")]
        public virtual ArticleGroup SuperiorArticleGroup { get; set; } = new ArticleGroup();
    }
}
