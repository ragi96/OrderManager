using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;

namespace OrderManagement.View
{
    public partial class ArticleManagementView : Form
    {
        public ArticleManagementView()
        {
            InitializeComponent();
            

           /* 
            context.Article.Load();
            GrdArticle.DataSource = context.Article.Local.ToBindingList();*/
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            var builder = new DbContextOptionsBuilder<DataContext>();
            using var context = new DataContext(builder.Options);

            // Call the Load method to get the data for the given DbSet
            // from the database.
            // The data is materialized as entities. The entities are managed by
            // the DbContext instance.
            context.Article.Load();

            // Bind the categoryBindingSource.DataSource to
            // all the Unchanged, Modified and Added Category objects that
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.
            this.GrdArticle.DataSource = context.Article.Local.ToBindingList();
        }
    }
}
