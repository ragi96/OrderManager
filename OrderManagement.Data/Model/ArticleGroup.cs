using Smartive.Core.Database.Models;

namespace OrderManagement.Data.Model
{
    public class ArticleGroup : Base
    {
        public string Name { get; set; } = string.Empty;

#pragma warning disable CS8632 // Die Anmerkung für Nullable-Verweistypen darf nur in Code innerhalb eines #nullable-Anmerkungskontexts verwendet werden.
        public ArticleGroup? SuperiorArticleGroup { get; set; }
#pragma warning restore CS8632 // Die Anmerkung für Nullable-Verweistypen darf nur in Code innerhalb eines #nullable-Anmerkungskontexts verwendet werden.
    }
}
