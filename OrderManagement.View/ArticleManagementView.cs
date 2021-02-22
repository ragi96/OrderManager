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
using Microsoft.EntityFrameworkCore.Infrastructure;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;

namespace OrderManagement.View
{
    public partial class ArticleManagementView : Form
    {
        private readonly EfCrudRepository<ArticleGroup> _articleGroupRepo;
        private IList<ArticleGroup> _articlesGroups;

        private readonly EfCrudRepository<Article> _articleRepo;
        private IList<Article> _articles;
        

        public ArticleManagementView(EfCrudRepository<ArticleGroup> articleGroupRepo, EfCrudRepository<Article> articleRepo)
        {
            InitializeComponent();
            _articleGroupRepo = articleGroupRepo;
            _articleRepo = articleRepo;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _articles = new List<Article>();
            _articles = await _articleRepo.GetAll();
            _articlesGroups = new List<ArticleGroup>();
            _articlesGroups = await _articleGroupRepo.GetAll();

            //GrdArticle
            GrdArticle.DataSource = new BindingList<Article>(_articles);
            GrdArticle.Columns["Id"].Visible = false;

            //GrdArticleGroup
            SetArticleGroupGridColumns();

            // Show the user something
            //TrvArticlegroups.Nodes.Add("Loading...");
            // Run the tree load in the background
            //Task.Run(() => LoadTree());
            //GrdArticleGroups.DataSource = _articlesGroups;
            //GrdArticleGroups.Refresh();
        }

        private void LoadTree()
        {
            
          /*  var treeView = this._context.ArticleGroupView.FromSqlRaw("Exec getArticleGroupTree;").ToList();
            TrvArticlegroups.BeginUpdate();

            TreeNode treeviewNode = new TreeNode();
            string[] levels;
            foreach (var Node in treeView)
            {
                levels = Node.TreePath.Split(".");
                if (Node.TreeLevel == 0)
                {
                    treeviewNode.Nodes.Add(new TreeNode(Node.Name));
                }
                else
                {
                    var i = 0;
                    TreeNode node = null;
                    foreach (var level in levels)
                    {
                        if (i == 0)
                        {
                            node = treeviewNode.Nodes[Int32.Parse(level) - 1];
                        }
                        else
                        {
                            if (Int32.Parse(level) != Node.Id)
                            {
                                node = node?.Nodes[Int32.Parse(level) - 1];
                            }
                            else
                            {
                                node.Nodes.Add(new TreeNode(Node.Name));
                            }
                        }
                        i++;
                    }
                    //treeviewNode.Nodes[(int) Node.SuperiorArticleId - 1].Nodes.Add(new TreeNode(Node.Name));
                }
            }
            TrvArticlegroups.Nodes.Clear();
            TrvArticlegroups.Nodes.Add(treeviewNode);
            TrvArticlegroups.EndUpdate();*/
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
            var list = _articlesGroups;
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
                DataPropertyName = "SuperiorArticleId",
                DataSource = list,
                DisplayMember = "name",
                ValueMember = "id"
            };
            GrdArticleGroups.Columns.Add(combo);
            GrdArticleGroups.AutoGenerateColumns = false;
            GrdArticleGroups.DataSource = new BindingList<ArticleGroup>(_articlesGroups);
        }

        private void CmdSaveArticle_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this._context.SaveChanges();
            this.GrdArticle.Refresh();
        }

        private async void CmdSaveArticleGroups_Click(object sender, EventArgs e)
        {
            this.Validate();

            //await _articleGroupRepo.U;

            ClearArticleGroupGrid();
            SetArticleGroupGridColumns();
        }

        private void CmdArticleGroupSearch_Click(object sender, EventArgs e)
        {
            if (TxtArticleGroupSearch.ToString() != "")
            {
                //articleGroupSearch = TxtArticleGroupSearch.ToString();
                ClearArticleGroupGrid();
                SetArticleGroupGridColumns();
            }
        }

        private async void GrdArticleGroup_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            var selectedArticleGroup = GrdArticleGroups.Rows[currentRow].Cells;
            var currentArticleGroup = _articlesGroups[currentRow];
            if (currentArticleGroup.SuperiorArticleGroup == null && currentArticleGroup.SuperiorArticleId != null) {
                var articleGroup = await _articleGroupRepo.GetById((int)currentArticleGroup.SuperiorArticleId);
                currentArticleGroup.SuperiorArticleGroup = articleGroup;
            }
            if (currentArticleGroup.Id == 0) {
                await _articleGroupRepo.Create(currentArticleGroup);
            } else {
                await _articleGroupRepo.Update(currentArticleGroup);
            }
        }
    }
}
