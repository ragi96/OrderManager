using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;

namespace OrderManagement.View
{
    public partial class InvoiceManagementView : Form
    {
        private readonly EfCrudRepository<Order> _orderRepo;
        private IList<Order> _orders;
        private IList<Order> _invoices;

        public InvoiceManagementView(EfCrudRepository<Order> orderRepo)
        {
            InitializeComponent();
            _orderRepo = orderRepo;
        }

        protected override async void OnLoad(EventArgs e)
        {
            GrdInvoice.AutoGenerateColumns = false;
            base.OnLoad(e);
            _orders = new List<Order>();
            _invoices = new List<Order>();
            _orders = await _orderRepo.GetAll();
            _invoices = _orders.Where(o => o.InvoiceDate != null).ToList();

            // GrdInvoice
            SetInvoiceGridColumns();
        }

        private void SetInvoiceGridColumns()
        {
            var colId = new DataGridViewTextBoxColumn { Name = "id", DataPropertyName = "id", Visible = false};
            var colDate = new DataGridViewTextBoxColumn { HeaderText = "Rechnungsdatum", Name = "invoiceDate", DataPropertyName = "InvoiceDate", DefaultCellStyle = { Format = "dd.MM.yyyy" } };

            GrdInvoice.Columns.Add(colId);
            GrdInvoice.Columns.Add(colDate);
            GrdInvoice.DataSource = new BindingList<Order>(_invoices);
        }
    }
}
