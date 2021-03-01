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
        private IList<Order> _invoices;

        private readonly EfCrudRepository<Customer> _customerRepo;
        private IList<Customer> _customers;

        private Customer _selectedCustomer;

        private DateTime? _selectedDate;

        public InvoiceManagementView(EfCrudRepository<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        protected override async void OnLoad(EventArgs e)
        {
            GrdInvoice.AutoGenerateColumns = false;
            base.OnLoad(e);
            _invoices = new List<Order>();
            await using (var context = new DataContext())
            {
                _invoices = context.Order.Where(i => i.InvoiceDate != null).Include(o => o.Customer).Include(o => o.Positions).ThenInclude(p => p.Article).ToList();
            }


            // set temporal stuff (Customer & Article)
            foreach (var invoice in _invoices)
            {
                var invoiceDate = invoice.InvoiceDate;
                invoiceDate = invoiceDate?.AddHours(-1);
                var customerId = invoice.Customer.Id;
                await using (var context = new DataContext())
                {
                    var temporalCustomer = context.Customer
                        .FromSqlRaw(
                            $"SELECT * FROM [Customer] FOR SYSTEM_TIME AS OF '{invoiceDate?.ToString("u")}' WHERE Id = {customerId}")
                        .AsNoTracking().FirstOrDefault();
                    if (temporalCustomer != null) {
                        invoice.Customer = temporalCustomer;
                    }
                }

                foreach (var position in invoice.Positions)
                {
                    var positionId = position.Article.Id;
                    await using (var context = new DataContext())
                    {
                        var temporalArticle = context.Article.FromSqlRaw($"SELECT * FROM [Article] FOR SYSTEM_TIME AS OF '{invoiceDate?.ToString("u")}' WHERE Id = {positionId}").AsNoTracking().FirstOrDefault();

                        if (temporalArticle != null)
                        {
                            position.Article = temporalArticle;
                        }
                    }
                }

            }


            _customers = new List<Customer>();
            _customers = await _customerRepo.GetAll();

            // GrdInvoice
            SetInvoiceGridColumns();
            // Customer Combobox
            SetCustomerCombo();

            // setup datetimepicker
            DtpDate.Checked = false;
        }

        private void SetInvoiceGridColumns()
        {
            var colDate = new DataGridViewTextBoxColumn { HeaderText = "Rechnungsdatum", Name = "invoiceDate", DataPropertyName = "InvoiceDate", DefaultCellStyle = { Format = "dd.MM.yyyy" } };
            var colCustomerId = new DataGridViewTextBoxColumn { HeaderText = "Kunden ID", Name = "customerId", DataPropertyName = "CustomerId", Visible = false };
            var colId = new DataGridViewTextBoxColumn { HeaderText = "Rechnungsnummer", Name = "id", DataPropertyName = "id" };

            var colCustomerName = new DataGridViewTextBoxColumn { HeaderText = "Kunde", Name = "customerName", DataPropertyName = "CustomerName" };
            var colCustomerStreet = new DataGridViewTextBoxColumn { HeaderText = "Strasse", Name = "customerStreet", DataPropertyName = "CustomerStreet" };
            var colCustomerStreetNr = new DataGridViewTextBoxColumn { HeaderText = "Strasse-Nr", Name = "customerStreetNr", DataPropertyName = "CustomerStreetNr" };
            var colCustomerZip = new DataGridViewTextBoxColumn { HeaderText = "PLZ", Name = "customerZip", DataPropertyName = "CustomerZip" };
            var colCustomerCity = new DataGridViewTextBoxColumn { HeaderText = "City", Name = "customerCity", DataPropertyName = "CustomerCity" };
            var colCustomerCountry = new DataGridViewTextBoxColumn { HeaderText = "Land", Name = "customerCountry", DataPropertyName = "CustomerCountry" };
            var colCustomerPriceNetto = new DataGridViewTextBoxColumn { HeaderText = "Netto", Name = "priceNetto", DataPropertyName = "PriceNetto", DefaultCellStyle = { Format = "##############.00\\ CHF" }};
            var colCustomerPriceBrutto = new DataGridViewTextBoxColumn { HeaderText = "Brutto", Name = "priceBrutto", DataPropertyName = "PriceBrutto", DefaultCellStyle = { Format = "##############.00\\ CHF" } };

            GrdInvoice.Columns.Add(colCustomerId);
            GrdInvoice.Columns.Add(colId);
            GrdInvoice.Columns.Add(colCustomerName);
            GrdInvoice.Columns.Add(colCustomerStreet);
            GrdInvoice.Columns.Add(colCustomerStreetNr);
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
            CmbUser.Text = "";
            CmbUser.DataSource = customerList;
            CmbUser.ValueMember = "id";
            CmbUser.DisplayMember = "fullname";
            CmbUser.SelectedIndex = 0;
        }

        private void CmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCustomer = CmbUser.SelectedItem as Customer;
            FilterInvoiceGrid();
        }
        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (DtpDate.Checked)
            {
                _selectedDate = DtpDate.Value;
            }
            else
            {
                _selectedDate = null;
            }
            FilterInvoiceGrid();
        }


        private void FilterInvoiceGrid()
        {
            var filteredList = _invoices;
            if (_selectedCustomer.Id != 0)
            {
                filteredList = filteredList.Where(o => o.CustomerId == _selectedCustomer.Id).ToList();
            }

            if (_selectedDate != null)
            {
                filteredList = filteredList.Where(o => o.InvoiceDate?.ToString("d") == _selectedDate?.ToString("d")).ToList();
            }

            GrdInvoice.DataSource = filteredList;
        }


    }
}
