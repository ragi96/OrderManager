using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public OrderManagementView(EfCrudRepository<Order> orderRepo, EfCrudRepository<Position> positionRepo, EfCrudRepository<Customer> customerRepo)
        {
            InitializeComponent();
            _orderRepo = orderRepo;
            _positionRepo = positionRepo;
            _customerRepo = customerRepo;
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
            //GrdArticle
            SetOrderGridColumns();
            //GrdArticleGroup
            //SetArticleGroupGridColumns();
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
                    GrdOrder.Rows[1].ErrorText = "Kunde darf nicht leer sein!";
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

            GrdOrder.Rows[currentRow].ErrorText = String.Empty;
        }
    }
}
