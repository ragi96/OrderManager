using Smartive.Core.Database.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderManagement.Data.Model
{
    public class ArticleGroup : Base
    {
        [Required]
        public string Name { get; set; }
        public int? SuperiorArticleId { get; set; }
        [ForeignKey("SuperiorArticleId")]
        public virtual ArticleGroup SuperiorArticleGroup { get; set; }
    }

    [Table("ArticleGroupView")]
    public class ArticleGroupView : Base
    {
        public string Name { get; set; }
        public int? SuperiorArticleId { get; set; }
        public int? TreeLevel { get; set; }

        public string TreePath { get; set; }
    }
}
