using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
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
           // SetArticleGridColumns();
            GrdArticle.DataSource = new BindingList<Article>(_articles);
            GrdArticle.Columns["Id"].Visible = false;

            //GrdArticleGroup
            SetArticleGroupGridColumns();


            /** Treeeee Stuff **/
            // Show the user something
            //TrvArticlegroups.Nodes.Add("Loading...");
            // Run the tree load in the background
            //Task.Run(() => LoadTree());
            //GrdArticleGroups.DataSource = _articlesGroups;
            //GrdArticleGroups.Refresh();
        }

        private void SetArticleGridColumns()
        {
            var col1 = new DataGridViewTextBoxColumn();
            col1.Name = "id";
            col1.DataPropertyName = "id";
            col1.Visible = false;
            GrdArticle.Columns.Add(col1);
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

        private void SetArticleGroupGridColumns()
        {
            var col1 = new DataGridViewTextBoxColumn();
            col1.Name = "id";
            col1.DataPropertyName = "id";
            col1.Visible = false;
            GrdArticleGroups.Columns.Add(col1);
            // create new
            var col2 = new DataGridViewTextBoxColumn();
            // create fake articlegroup
            col2.HeaderText = "Name";
            col2.Name = "name";
            col2.DataPropertyName = "name";
            GrdArticleGroups.Columns.Add(col2);
            addArticleGroupCombo();
            GrdArticleGroups.AutoGenerateColumns = false;
            GrdArticleGroups.DataSource = new BindingList<ArticleGroup>(_articlesGroups);
        }

        private async void addArticleGroupCombo()
        {
            var list = await _articleGroupRepo.GetAll();
            list.Insert(0, new ArticleGroup());
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Überkategorie",
                Name = "superiorArticleId",
                DataPropertyName = "SuperiorArticleId",
                DataSource = list,
                DisplayMember = "name",
                ValueMember = "id",
            };
            GrdArticleGroups.Columns.Add(combo);
        }

        private async void GrdArticleGroup_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
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

        private void GrdArticleGroups_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            _articleGroupRepo.DeleteById((int)e.Row.Cells["id"].Value);
        }

        private async void TxtArticleGroupSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtArticleGroupSearch.Text))
            {
                GrdArticleGroups.DataSource = await _articleGroupRepo.GetAll();
                return;
            }
            var foundArticleGroups = new List<ArticleGroup>();
            var searchString = TxtArticleGroupSearch.Text;
            foreach (var articleGroup in _articlesGroups)
            {
                if (articleGroup.Name.Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                {
                    foundArticleGroups.Add(articleGroup);
                }
            }
            GrdArticleGroups.DataSource = foundArticleGroups;
        }
    }
}
