using Microsoft.VisualBasic;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace OrderManagement.View
{
    public partial class YearlyCompareView : Form
    {
        private readonly EfCrudRepository<Article> _articleRepo;

        public YearlyCompareView(EfCrudRepository<Article> articleRepo)
        {
            InitializeComponent();
            _articleRepo = articleRepo;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

           
        }
    }
}
