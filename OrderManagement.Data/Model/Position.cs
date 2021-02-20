using Smartive.Core.Database.Models;

namespace OrderManagement.Data.Model
{
    public class Position : Base
    {
        public Article Article { get; set; } = new Article();

        public Order Order { get; set; } = new Order();

        public double ArticlePrice { get; set; }

        public int Amount { get; set; }
    }
}
