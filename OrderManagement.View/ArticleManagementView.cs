using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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

        private IList<ArticleGroup> _groupListCombo;


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

            // GroupListCombo
            _groupListCombo = await _articleGroupRepo.GetAll();
            _groupListCombo.Insert(0, new ArticleGroup());

            //GrdArticle
            SetArticleGridColumns();

            //GrdArticleGroup
            SetArticleGroupGridColumns();



            // Run the tree load in the background
            await Task.Run(() => LoadTree());
        }

        private void SetArticleGridColumns()
        {
            var colId = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false };

            var colNum = new DataGridViewTextBoxColumn { HeaderText = "Nummer", Name = "number", DataPropertyName = "number" };

            var colName = new DataGridViewTextBoxColumn { HeaderText = "Name", Name = "name", DataPropertyName = "name" };

            var colPrice = new DataGridViewTextBoxColumn { HeaderText = "Preis", Name = "price", DataPropertyName = "price", DefaultCellStyle = { Format = "N2" } };
            var colMwst = new DataGridViewTextBoxColumn { HeaderText = "Mehrwertsteuer", Name = "mwst", DataPropertyName = "mwst", DefaultCellStyle = { Format = "N2" } };

            GrdArticle.Columns.Add(colId);
            GrdArticle.Columns.Add(colNum);
            GrdArticle.Columns.Add(colName);
            AddArticleArticleGroupCombo();
            GrdArticle.Columns.Add(colPrice);
            GrdArticle.Columns.Add(colMwst);
            GrdArticle.AutoGenerateColumns = false;
            GrdArticle.DataSource = new BindingList<Article>(_articles);
        }

        private void LoadTree()
        {
            List<ArticleGroupView> treeView;
            using (var db = new DataContext())
            {
                treeView = db.ArticleGroupView.FromSqlRaw("Exec getArticleGroupTree;").ToList();
            }

            TrvArticlegroups.Invoke(new Action(() =>
            {
                TrvArticlegroups.BeginUpdate();
                TrvArticlegroups.Nodes.Clear();
                var mainNodes = treeView.Where(node => node.SuperiorArticleId == null).ToList();
                foreach (var mainNode in mainNodes)
                {
                    var actualNodeId = mainNode.Id;
                    var newlevel = mainNode.TreeLevel + 1;
                    TreeNode treeviewNode = new TreeNode(mainNode.Name);
                    var subNodes = treeView.Where(node => node.SuperiorArticleId.Equals(actualNodeId)).ToList();
                    TrvArticlegroups.Nodes.Add(CreateRecursiveTreeview(treeView, subNodes, treeviewNode));
                }
                TrvArticlegroups.ExpandAll();
                TrvArticlegroups.EndUpdate();
            }));
        }

        private TreeNode CreateRecursiveTreeview(List<ArticleGroupView> completeList, List<ArticleGroupView> articleGroupList, TreeNode mainNode)
        {
            foreach (var articleGroup in articleGroupList)
            {
                var actualNodeId = articleGroup.Id;
                var newlevel = articleGroup.TreeLevel + 1;
                TreeNode treeviewNode = new TreeNode(articleGroup.Name);
                var subNodes = completeList.Where(node => node.SuperiorArticleId.Equals(actualNodeId)).ToList();
                if (subNodes.Count() > 0)
                {
                    mainNode.Nodes.Add(CreateRecursiveTreeview(completeList, subNodes, treeviewNode));
                }
                else
                {
                    mainNode.Nodes.Add(articleGroup.Name);
                }
            }

            return mainNode;
        }

        private void SetArticleGroupGridColumns()
        {
            var col1 = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false };
            GrdArticleGroups.Columns.Add(col1);
            // create new
            var col2 = new DataGridViewTextBoxColumn { HeaderText = "Name", Name = "name", DataPropertyName = "name" };
            // create fake articlegroup
            GrdArticleGroups.Columns.Add(col2);
            AddArticleGroupCombo();
            GrdArticleGroups.AutoGenerateColumns = false;
            GrdArticleGroups.DataSource = new BindingList<ArticleGroup>(_articlesGroups);
        }

        private void AddArticleGroupCombo()
        {
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Überkategorie",
                Name = "superiorArticleId",
                DataPropertyName = "SuperiorArticleId",
                DataSource = _groupListCombo,
                DisplayMember = "name",
                ValueMember = "id",
            };
            GrdArticleGroups.Columns.Add(combo);
        }

        private void AddArticleArticleGroupCombo()
        {
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Artikel Gruppe",
                Name = "ArticleGroupId",
                DataPropertyName = "ArticleGroupId",
                DataSource = _groupListCombo,
                DisplayMember = "name",
                ValueMember = "id",
            };
            GrdArticle.Columns.Add(combo);
        }

        private async void GrdArticleGroup_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            var currentArticleGroup = _articlesGroups[currentRow];
            if (currentArticleGroup.SuperiorArticleGroup == null && currentArticleGroup.SuperiorArticleId != null)
            {
                var articleGroup = await _articleGroupRepo.GetById((int)currentArticleGroup.SuperiorArticleId);
                currentArticleGroup.SuperiorArticleGroup = articleGroup;
            }
            if (currentArticleGroup.Id == 0)
            {
                await _articleGroupRepo.Create(currentArticleGroup);
            }
            else
            {
                await _articleGroupRepo.Update(currentArticleGroup);
            }
            // Run the tree load in the background
            await Task.Run(() => LoadTree());
        }

        private async void GrdArticleGroups_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            await _articleGroupRepo.DeleteById((int)e.Row.Cells["id"].Value);
            // Run the tree load in the background
            await Task.Run(() => LoadTree());
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

        private async void GrdArticle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            var currentArticle = _articles[currentRow];
            if (currentArticle.ArticleGroup == null && currentArticle.ArticleGroupId != null)
            {
                var articleGroup = await _articleGroupRepo.GetById((int)currentArticle.ArticleGroupId);
                currentArticle.ArticleGroup = articleGroup;
            }

            if (currentArticle.Id == 0)
            {
                var valid = true;
                if (currentArticle.Number == 0)
                {
                    valid = false;
                    // error number
                    GrdArticle.Rows[e.RowIndex].ErrorText = "Nummer darf nicht 0 sein!";
                }

                if (currentArticle.Name == "")
                {
                    valid = false;
                    GrdArticle.Rows[e.RowIndex].ErrorText = "Name darf nicht leer sein!";
                }


                if (currentArticle.Price == 0)
                {
                    valid = false;
                    GrdArticle.Rows[e.RowIndex].ErrorText = "Preis darf nicht 0.00 sein!";
                }

                if (valid)
                {
                    currentArticle.ArticleGroup = null;
                    await _articleRepo.Create(currentArticle);
                }
            }
            else
            {
                await _articleRepo.Update(currentArticle);
            }

            GrdArticle.Rows[currentRow].ErrorText = String.Empty;
        }

        private void GrdArticle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = GrdArticle.Columns[e.ColumnIndex].HeaderText;

            if (headerText == "Preis")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    GrdArticle.Rows[e.RowIndex].ErrorText = "Preis darf nicht leer sein!";
                    e.Cancel = true;
                }
                if (!Double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    GrdArticle.Rows[e.RowIndex].ErrorText = "Preis muss als Zahl eingeben sein";
                    e.Cancel = true;
                }

            }
            else if (headerText == "Name")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    GrdArticle.Rows[e.RowIndex].ErrorText = "Name darf nicht leer sein!";
                    e.Cancel = true;
                }
            }
        }

        private async void GrdArticle_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            await _articleRepo.DeleteById((int)e.Row.Cells["id"].Value);
        }

        private async void TxtSearchArticle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchArticle.Text))
            {
                GrdArticle.DataSource = await _articleRepo.GetAll();
                return;
            }

            var searchString = TxtSearchArticle.Text;
            var foundArticle = _articles.Where(article => article.Name.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)).ToList();
            GrdArticle.DataSource = foundArticle;
        }
    }
}