﻿using OrderManagement.Data.Model;
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

        public StartView(EfCrudRepository<Customer> customerRepo, EfCrudRepository<Article> articleRepo, EfCrudRepository<ArticleGroup> articleGroup)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
            _articleRepo = articleRepo;
            _articleGroupRepo = articleGroup;
        }

        private void CmdCustomerManagement_Click(object sender, EventArgs e)
        {
            var view = new CustomerManagementView(_customerRepo);
            view.Show();
        }

        private void CmdOrderManagement_Click(object sender, EventArgs e)
        {
            var view = new OrderManagementView();
            view.Show();
        }
        private void CmdArticleManagement_Click(object sender, EventArgs e)
        {
            var view = new ArticleManagementView(_articleGroupRepo, _articleRepo);
            view.Show();
        }

        private void CmdYearCompare_Click(object sender, EventArgs e)
        {
            var view = new YearlyCompareView();
            view.Show();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
