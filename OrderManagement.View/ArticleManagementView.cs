using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private String articleGroupSearch = "";
        public ArticleManagementView()
        {
            InitializeComponent();
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
            SetArticleGroupGridColumns();
        }

        private void ClearArticleGroupGrid()
        {
            GrdArticleGroups.CancelEdit();
            GrdArticleGroups.Columns.Clear();
            GrdArticleGroups.DataSource = null;
            GrdArticleGroups.Refresh();
        }

        private void SetArticleGroupGridColumns()
        {
            // create new
            var col1 = new DataGridViewTextBoxColumn();
            var list = this._context.ArticleGroup.Local.ToList();
            // create fake articlegroup
            list.Insert(0, new ArticleGroup());
            col1.HeaderText = "Name";
            col1.Name = "name";
            col1.DataPropertyName = "name";
            GrdArticleGroups.Columns.Add(col1);
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Überkategorie",
                Name = "superiorArticleId",
                DataPropertyName = "superiorArticleId",
                DataSource = list,
                DisplayMember = "name",
                ValueMember = "id"
            };
            GrdArticleGroups.Columns.Add(combo);
            GrdArticleGroups.AutoGenerateColumns = false;
            _context.ArticleGroup.Load();
            if (articleGroupSearch == "")
            {
                GrdArticleGroups.DataSource = _context.ArticleGroup.Local.ToBindingList();
            }
            else
            {
                var results = _context.ArticleGroup.Where(x => EF.Functions.FreeText(x.Name, articleGroupSearch))
                    .ToList();
                GrdArticleGroups.DataSource = new BindingList<ArticleGroup>(results);
            }
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
            ClearArticleGroupGrid();
            SetArticleGroupGridColumns();
        }

        private void CmdArticleGroupSearch_Click(object sender, EventArgs e)
        {
            if (TxtArticleGroupSearch.ToString() != "")
            {
                articleGroupSearch = TxtArticleGroupSearch.ToString();
                ClearArticleGroupGrid();
                SetArticleGroupGridColumns();
            }
        }
    }
}
