using Smartive.Core.Database.Models;

namespace OrderManagement.Data.Model
{
    public class ArticleGroup : Base
    {
        public string Name { get; set; } = string.Empty;

        public ArticleGroup SuperiorArticleGroup { get; set; } = new ArticleGroup();
    }
}
