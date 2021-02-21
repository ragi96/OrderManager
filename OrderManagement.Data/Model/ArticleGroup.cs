using Smartive.Core.Database.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
