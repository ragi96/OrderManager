using System.ComponentModel.DataAnnotations.Schema;
using Smartive.Core.Database.Models;

namespace OrderManagement.Data.Model
{
    public class Position : Base
    {
        [ForeignKey("Article")]
        public int? ArticleId { get; set; }
        public virtual Article Article { get; set; }

        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order Order { get; set; }

        public double ArticlePrice { get; set; }

        public int Amount { get; set; }
    }
}