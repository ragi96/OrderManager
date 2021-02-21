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
            SetArticleGridColumns(GrdArticleGroups);
            GrdArticleGroups.AutoGenerateColumns = false;
            GrdArticleGroups.DataSource = _context.ArticleGroup.Local.ToBindingList();
        }

        private void SetArticleGridColumns(DataGridView dgv)
        {
            // create new
            var col1 = new DataGridViewTextBoxColumn();
            var list = this._context.ArticleGroup.Local.ToList();
            // create fake articlegroup
            list.Insert(0, new ArticleGroup());
            col1.HeaderText = "name";
            col1.Name = "name";
            col1.DataPropertyName = "name";
            dgv.Columns.Add(col1);
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Überkategorie",
                Name = "superiorArticleId",
                DataPropertyName = "superiorArticleId",
                DataSource = list,
                DisplayMember = "name",
                ValueMember = "id"
            };
            dgv.Columns.Add(combo);
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

        private void CmdSaveArticleGroups_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._context.SaveChanges();
            this.GrdArticleGroups.Refresh();
        }
    }
}
