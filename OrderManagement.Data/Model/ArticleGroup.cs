using Smartive.Core.Database.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderManagement.Data.Model
{
    public class ArticleGroup : Base
    {
        [Required]
        public string Name { get; set; }

        [ForeignKey("SuperiorArticleGroup")]
        public int? SuperiorArticleId { get; set; }
        public virtual ArticleGroup SuperiorArticleGroup { get; set; }

        public bool Deleted { get; set; } = false;
    }

    public class ArticleGroupView : Base
    {
        public string Name { get; set; }

        public int? SuperiorArticleId { get; set; }

        public int? TreeLevel { get; set; }

        public string TreePath { get; set; }
    }
}
