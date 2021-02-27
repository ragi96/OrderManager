using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;

namespace OrderManagement.View
{
    public partial class InvoiceManagementView : Form
    {
        private readonly EfCrudRepository<Order> _orderRepo;
        private IList<Order> _invoices;

        private readonly EfCrudRepository<Customer> _customerRepo;
        private IList<Customer> _customers;

        public InvoiceManagementView(EfCrudRepository<Order> orderRepo, EfCrudRepository<Customer> customerRepo)
        {
            InitializeComponent();
            _orderRepo = orderRepo;
            _customerRepo = customerRepo;
        }

        protected override async void OnLoad(EventArgs e)
        {
            GrdInvoice.AutoGenerateColumns = false;
            base.OnLoad(e);
            _invoices = new List<Order>();
            await using (var context = new DataContext())
            {
                _invoices = context.Order.Include(o => o.Customer).Include(o => o.Positions).ToList();
            }

            _customers = new List<Customer>();
            _customers = await _customerRepo.GetAll();

            // GrdInvoice
            SetInvoiceGridColumns();
            // Customer Combobox
            SetCustomerCombo();
        }

        private void SetInvoiceGridColumns()
        {
            var colDate = new DataGridViewTextBoxColumn { HeaderText = "Rechnungsdatum", Name = "invoiceDate", DataPropertyName = "InvoiceDate", DefaultCellStyle = { Format = "dd.MM.yyyy" } };
            var colCustomerId = new DataGridViewTextBoxColumn { HeaderText = "Kunden ID", Name = "customerId", DataPropertyName = "CustomerId" };

            var colCustomerName = new DataGridViewTextBoxColumn { HeaderText = "Kunde", Name = "customerName", DataPropertyName = "CustomerName" };
            var colCustomerStreet = new DataGridViewTextBoxColumn { HeaderText = "Strasse", Name = "customerStreet", DataPropertyName = "CustomerStreet" };
            var colCustomerZip = new DataGridViewTextBoxColumn { HeaderText = "PLZ", Name = "customerZip", DataPropertyName = "CustomerZip" };
            var colCustomerCity = new DataGridViewTextBoxColumn { HeaderText = "City", Name = "customerCity", DataPropertyName = "CustomerCity" };
            var colCustomerCountry = new DataGridViewTextBoxColumn { HeaderText = "Land", Name = "customerCountry", DataPropertyName = "CustomerCountry" };
            var colCustomerPriceNetto = new DataGridViewTextBoxColumn { HeaderText = "Netto", Name = "priceNetto", DataPropertyName = "PriceNetto", DefaultCellStyle = { Format = "N2" }};
            var colCustomerPriceBrutto = new DataGridViewTextBoxColumn { HeaderText = "Brutto", Name = "priceBrutto", DataPropertyName = "PriceBrutto", DefaultCellStyle = { Format = "N2" } };

            GrdInvoice.Columns.Add(colCustomerId);
            GrdInvoice.Columns.Add(colCustomerName);
            GrdInvoice.Columns.Add(colCustomerStreet);
            GrdInvoice.Columns.Add(colCustomerZip);
            GrdInvoice.Columns.Add(colCustomerCity);
            GrdInvoice.Columns.Add(colCustomerCountry);
            GrdInvoice.Columns.Add(colDate);
            GrdInvoice.Columns.Add(colCustomerPriceNetto);
            GrdInvoice.Columns.Add(colCustomerPriceBrutto);

            GrdInvoice.DataSource = _invoices;
        }

        private void SetCustomerCombo()
        {
            var customerList = _customers;
            customerList.Insert(0, new Customer());
            cmbUser.Text = "";
            cmbUser.DataSource = customerList;
            cmbUser.ValueMember = "id";
            cmbUser.DisplayMember = "fullname";
            cmbUser.SelectedIndex = 0;
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = cmbUser.SelectedItem as Customer;
            if (selectedCustomer.Id != 0)
            {
                GrdInvoice.DataSource = _invoices.Where(o => o.CustomerId == selectedCustomer.Id).ToList();
            }
        }
    }
}
