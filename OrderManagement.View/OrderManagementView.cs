using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;

namespace OrderManagement.View
{
    public partial class OrderManagementView : Form
    {
        private readonly EfCrudRepository<Order> _orderRepo;
        private IList<Order> _orders;

        private readonly EfCrudRepository<Position> _positionRepo;
        private IList<Position> _positions;

        private readonly EfCrudRepository<Customer> _customerRepo;
        private IList<Customer> _customers;

        private readonly EfCrudRepository<Article> _articleRepo;
        private IList<Article> _articles;

        private int _selectedOrderId = 0;

        public OrderManagementView(EfCrudRepository<Order> orderRepo, EfCrudRepository<Position> positionRepo, EfCrudRepository<Customer> customerRepo, EfCrudRepository<Article> articleRepo)
        {
            InitializeComponent();
            _orderRepo = orderRepo;
            _positionRepo = positionRepo;
            _customerRepo = customerRepo;
            _articleRepo = articleRepo;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _orders = new List<Order>();
            _orders = await _orderRepo.GetAll();
            _positions = new List<Position>();
            _positions = await _positionRepo.GetAll();
            _customers = new List<Customer>();
            _customers = await _customerRepo.GetAll();
            _articles = new List<Article>();
            _articles = await _articleRepo.GetAll();

            //GrdArticle
            SetOrderGridColumns();

            // GrdPositions
            SetPositionGridColumns();
        }

        private void SetOrderGridColumns()
        {
            var colId = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false };
            var colDate = new DataGridViewTextBoxColumn { HeaderText = "Datum", Name = "date", DataPropertyName = "Date", ReadOnly = true, DefaultCellStyle = {Format = "dd.MM.yyyy"}};
            GrdOrder.Columns.Add(colId);
            GrdOrder.Columns.Add(colDate);
            AddCustomerCombo();
            GrdOrder.AutoGenerateColumns = false;
            GrdOrder.DataSource = new BindingList<Order>(_orders);
        }

        private void SetPositionGridColumns()
        {
            var colId = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false};
            var colOId = new DataGridViewTextBoxColumn { Name = "orderId", DataPropertyName = "orderId"};
            var colAmount = new DataGridViewTextBoxColumn { HeaderText = "Menge", Name = "amount", DataPropertyName = "amount", DefaultCellStyle = { Format = "N0" }};
            var colPrice = new DataGridViewTextBoxColumn { HeaderText = "Preis", Name = "articlePrice", DataPropertyName = "articlePrice" };
            GrdPosition.Columns.Add(colId);
            GrdPosition.Columns.Add(colOId);
            AddArticleCombo();
            GrdPosition.Columns.Add(colAmount);
            GrdPosition.Columns.Add(colPrice);
            GrdPosition.AutoGenerateColumns = false;
            GrdPosition.Enabled = false;
            GrdPosition.DataSource = new BindingList<Position>(_positions);
        }

        private void AddCustomerCombo()
        {
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Kunde",
                Name = "CustomerId",
                DataPropertyName = "CustomerId",
                DataSource = _customers,
                DisplayMember = "Fullname",
                ValueMember = "id",
            };
            GrdOrder.Columns.Add(combo);
        }

        private void AddArticleCombo()
        {
            var combo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Artikel",
                Name = "ArticleId",
                DataPropertyName = "ArticleId",
                DataSource = _articles,
                DisplayMember = "Name",
                ValueMember = "id",
            };
            GrdPosition.Columns.Add(combo);
        }

        private async void GrdOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var currentRow = e.RowIndex;
            var currentOrder = _orders[currentRow];
            if (currentOrder.Customer == null && currentOrder.CustomerId != null)
            {
                var customer = await _customerRepo.GetById((int)currentOrder.CustomerId);
                currentOrder.Customer = customer;
            }

            if (currentOrder.Id == 0)
            {
                var valid = true;

                if (currentOrder.Customer == null)
                {
                    valid = false;
                    GrdOrder.Rows[e.RowIndex].ErrorText = "Kunde darf nicht leer sein!";
                }

                if (valid)
                {

                    await _orderRepo.Create(currentOrder);
                }
            }
            else
            {
                await _orderRepo.Update(currentOrder);
            }
        }

        private async void GrdOrder_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            await _customerRepo.DeleteById((int)e.Row.Cells["id"].Value);
        }

        private async void GrdOrder_SelectionChanged(object sender, EventArgs e)
        {
            _selectedOrderId = (int)GrdOrder.CurrentRow.Cells["id"].Value;
            if (_selectedOrderId != 0) { 
                var allPos = await _positionRepo.GetAll();
                if (allPos.Count() == 0) { 
                    var selectedPos = allPos.Where(p => p.OrderId == _selectedOrderId).ToList();
                    GrdPosition.Enabled = true;
                    GrdPosition.DataSource = new BindingList<Position>(selectedPos);
                }
            }
            else
            {
                GrdPosition.DataSource = new BindingList<Position>(_positions);
            }
        }

        private async void GrdPosition_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var name = GrdPosition.CurrentCell.OwningColumn.Name;
            if (name == "ArticleId")
            {
                //load article stuff in to active grdposition table
                var articleId = (int)GrdPosition.CurrentCell.Value;
                var article = await _articleRepo.GetById(articleId);
                GrdPosition.CurrentRow.Cells["articlePrice"].Value = article.Price;
                GrdPosition.CurrentRow.Cells["amount"].Value = 1;
            }
        }

        private void GrdPosition_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GrdPosition.IsCurrentCellDirty)
            {
                GrdPosition.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
