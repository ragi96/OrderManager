using System.ComponentModel.DataAnnotations.Schema;
using Smartive.Core.Database.Models;

namespace OrderManagement.Data.Model
{
    public class Position : Base
    {
        public int? ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public double ArticlePrice { get; set; }

        public int Amount { get; set; }
    }
}
