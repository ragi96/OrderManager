using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement.Data.Context;
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

        public OrderManagementView(EfCrudRepository<Order> orderRepo, EfCrudRepository<Position> positionRepo, EfCrudRepository<Customer> customerRepo, EfCrudRepository<Article> articleRepo)
        {
            InitializeComponent();
            _orderRepo = orderRepo;
            _positionRepo = positionRepo;
            _customerRepo = customerRepo;
            _articleRepo = articleRepo;
        }

        protected override async void OnLoad(EventArgs e)
        {
            GrdPosition.AutoGenerateColumns = false;
            base.OnLoad(e);
            _orders = new List<Order>();
            _orders = await _orderRepo.GetAll();
            _positions = new List<Position>();
            _positions = await _positionRepo.GetAll();
            _customers = new List<Customer>();
            _customers = await _customerRepo.GetAll();
            _articles = new List<Article>();
            _articles = await _articleRepo.GetAll();

            // GrdPositions
            SetPositionGridColumns();
            //GrdArticle
            SetOrderGridColumns();
        }

        private async void SetOrderGridColumns()
        {
            var colId = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false };
            var colDate = new DataGridViewTextBoxColumn { HeaderText = "Datum", Name = "date", DataPropertyName = "Date", ReadOnly = true, DefaultCellStyle = {Format = "dd.MM.yyyy"}};
            GrdOrder.Columns.Add(colId);
            GrdOrder.Columns.Add(colDate);
            AddCustomerCombo();
            GrdOrder.AutoGenerateColumns = false;
            var orders = await _orderRepo.GetAll();
            var allOrders = orders.Where(o => o.InvoiceDate == null).ToList();
            GrdOrder.DataSource = new BindingList<Order>(allOrders);
        }

        private void SetPositionGridColumns()
        {
            var colId = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false};
            var colOId = new DataGridViewTextBoxColumn { Name = "orderId", DataPropertyName = "orderId", Visible = false};
            var colAmount = new DataGridViewTextBoxColumn { HeaderText = "Menge", Name = "amount", DataPropertyName = "amount", DefaultCellStyle = { Format = "N0" }};
            var colPrice = new DataGridViewTextBoxColumn { HeaderText = "Preis pro Stück", Name = "articlePrice", DataPropertyName = "articlePrice" };
            GrdPosition.Columns.Add(colId);
            GrdPosition.Columns.Add(colOId);
            AddArticleCombo();
            GrdPosition.Columns.Add(colAmount);
            GrdPosition.Columns.Add(colPrice);
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
            var currentOrder = GrdOrder.CurrentRow.DataBoundItem as Order;
            if (currentOrder == null) return;
            if (currentOrder.Id == 0)
            {
                await _orderRepo.Create(currentOrder);
            }
            else
            {
                if (currentOrder.Customer != null) return;
                
                await _orderRepo.Update(currentOrder);
            }
        }

        private async void GrdOrder_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((int) e.Row.Cells["id"].Value > 0)
            {
                await _orderRepo.DeleteById((int) e.Row.Cells["id"].Value);
            }
        }

        private async void GrdOrder_SelectionChanged(object sender, EventArgs e)
        {
            GrdPosition.Enabled = false;
            GrdPosition.DataSource = null;
            var selectedOrder = GrdOrder.CurrentRow.DataBoundItem as Order; ;
            if (selectedOrder == null) return;
            if (selectedOrder.Id == 0) return;

            var selectedPos = await _positionRepo.GetAll();
            selectedPos = selectedPos.Where(p => p.OrderId == selectedOrder.Id).ToList();
            GrdPosition.Enabled = true;
            GrdPosition.DataSource = new BindingList<Position>(selectedPos);
        }

        private void GrdPosition_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var name = GrdPosition.CurrentCell.OwningColumn.Name;
            if (name == "ArticleId")
            {
                //load article stuff in to active grdposition table
                var articleId = (int)GrdPosition.CurrentCell.Value;
                var article = _articles.Where(a => a.Id == articleId).ToList().First();
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

        private async void GrdPosition_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentPosition = GrdPosition.CurrentRow.DataBoundItem as Position;
            if (currentPosition == null) return;
            if (currentPosition.Id == 0)
            {
                currentPosition.OrderId = (int)GrdOrder.CurrentRow.Cells["id"].Value;
                await _positionRepo.Create(currentPosition);
            }
            else
            {
                if (currentPosition.ArticlePrice == 0) return;

                if (currentPosition.Amount == 0) return;

                await _positionRepo.Update(currentPosition);
            }
        }

        private async void TxtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchOrder.Text))
            {
                GrdOrder.DataSource = await _orderRepo.GetAll();
            }
            else { 
                var searchString = TxtSearchOrder.Text;
                // Prüfen auf Customer Fullname und All articles?
                var foundArticle = _orders.Where(o => o.Id == 1).ToList();
                GrdOrder.DataSource = foundArticle;
            }
        }

        private async void GrdPosition_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((int) e.Row.Cells["id"].Value > 0)
            {
                await _positionRepo.DeleteById((int)e.Row.Cells["id"].Value);
            }
        }

        private async void CmdCreateInvoice_Click(object sender, EventArgs e)
        {
            var currentOrder = GrdOrder.CurrentRow.DataBoundItem as Order;
            if (currentOrder != null)
            {
                var positions = await _positionRepo.GetAll();
                if (positions.Any(p => p.OrderId == currentOrder.Id))
                {
                    currentOrder.InvoiceDate = DateTime.Now;
                    await _orderRepo.Update(currentOrder);
                    GrdOrderRefresh();
                }
                else
                {
                    MessageBox.Show("Auftrage hat keine Auftragspositionen und kann deshalb nicht zu Rechnung werden!");
                }
            }
        }

        private async void GrdOrderRefresh()
        {
            GrdOrder.ClearSelection();
            GrdPosition.Enabled = false;
            GrdPosition.DataSource = null;
            var orders = await _orderRepo.GetAll();
            var activeOrders = orders.Where(o => o.InvoiceDate == null).ToList();
            GrdOrder.DataSource = activeOrders;
        }
    }
}
