using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System;
using System.Windows.Forms;

namespace OrderManagement.View
{
    public partial class StartView : Form
    {
        private readonly EfCrudRepository<Customer> _customerRepo;
        private readonly EfCrudRepository<Article> _articleRepo;
        private readonly EfCrudRepository<ArticleGroup> _articleGroupRepo;
        private readonly EfCrudRepository<Order> _orderRepo;
        private readonly EfCrudRepository<Position> _positionRepo;

        public StartView(
            EfCrudRepository<Customer> customerRepo, 
            EfCrudRepository<Article> articleRepo, 
            EfCrudRepository<ArticleGroup> articleGroupRepo, 
            EfCrudRepository<Order> orderRepo, 
            EfCrudRepository<Position> positionRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _articleRepo = articleRepo;
            _articleGroupRepo = articleGroupRepo;
            _orderRepo = orderRepo;
            _positionRepo = positionRepo;
        }

        private void CmdCustomerManagement_Click(object sender, EventArgs e)
        {
            var view = new CustomerManagementView(_customerRepo);
            view.Show();
        }

        private void CmdOrderManagement_Click(object sender, EventArgs e)
        {
            var view = new OrderManagementView(_orderRepo, _positionRepo, _customerRepo, _articleRepo);
            view.Show();
        }
        private void CmdArticleManagement_Click(object sender, EventArgs e)
        {
            var view = new ArticleManagementView(_articleGroupRepo, _articleRepo);
            view.Show();
        }

        private void CmdYearCompare_Click(object sender, EventArgs e)
        {
            var view = new YearlyCompareView(_articleRepo);
            view.Show();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdInvoice_Click(object sender, EventArgs e)
        {
            var view = new InvoiceManagementView(_customerRepo);
            view.Show();
        }
    }
}
