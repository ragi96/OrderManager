using System;
using System.CodeDom;
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
        private DataContext _context;
        public ArticleManagementView()
        {
            InitializeComponent();
            

           /* 
            context.Article.Load();
            GrdArticle.DataSource = context.Article.Local.ToBindingList();*/
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context.Article.Load();

            //GrdArticle
            GrdArticle.DataSource = _context.Article.Local.ToBindingList();
            GrdArticle.Columns["Id"].Visible = false;

            //GrdArticleGroup
            _context.ArticleGroup.Load();
            GrdArticleGroups.DataSource = _context.ArticleGroup.Local.ToBindingList();
            GrdArticleGroups.Columns["Id"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        private void CmdSaveArticle_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._context.SaveChanges();
            this.GrdArticle.Refresh();
        }
    }
}
