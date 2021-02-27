using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrderManagement.View
{
    public partial class CustomerManagementView : Form
    {
        private readonly EfCrudRepository<Customer> _customerRepo;
        private IList<Customer> _customers;

        public CustomerManagementView(
            EfCrudRepository<Customer> customerRepo
        )
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _customers = new List<Customer>();
            _customers = await _customerRepo.GetAll();

            GrdCustomers.DataSource = _customers;
            //GrdCustomers.Columns["Id"].Visible = false;

            GrdCustomers.CellEndEdit += new DataGridViewCellEventHandler(GrdCustomers_CellEndEdit);
            TxtSearchCustomer.TextChanged += new EventHandler(TxtSearchCustomer_TextChanged);
            GrdCustomers.SelectionChanged += new EventHandler(GrdCustomers_SelectionChanged);
        }

        private async void GrdCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = GrdCustomers.SelectedRows;
            var currentCustomer = selectedRows[0].Cells[8].Value;

            using (var db = new DataContext())
            {
                var customerHistory = db.Customer.FromSqlRaw($"SELECT * FROM [Customer] FOR SYSTEM_TIME ALL WHERE Id = {currentCustomer}").AsNoTracking().ToList();
                
                if(customerHistory.Count > 0)
                {
                    GrdAdressHistory.DataSource = customerHistory;
                } 
                else {
                    GrdAdressHistory.DataSource = null;
                }
            }            
        }

        private async void GrdCustomers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;

            var selectedCustomer = GrdCustomers.Rows[currentRow].Cells;
            var currentCustomer = _customers[currentRow];

            currentCustomer.Prename = (string)selectedCustomer["Prename"].Value;
            currentCustomer.Lastname = (string)selectedCustomer["Lastname"].Value;
            currentCustomer.Street = (string)selectedCustomer["Street"].Value;
            currentCustomer.StreetNr = (string)selectedCustomer["StreetNr"].Value;
            //currentCustomer.ValidFrom = (DateTime)selectedCustomer["ValidFrom"].Value;
            currentCustomer.Zip = (string)selectedCustomer["Zip"].Value;
            currentCustomer.CountryCode = (string)selectedCustomer["CountryCode"].Value;
            currentCustomer.City = (string)selectedCustomer["City"].Value;

            await _customerRepo.Update(_customers);
        }

        private async void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtSearchCustomer.Text))
            {
                GrdCustomers.DataSource = await _customerRepo.GetAll();
                return;
            }

            var foundCustomers = new List<Customer>();

            foreach(var customer in _customers)
            {
                if (customer.Prename.Contains(TxtSearchCustomer.Text, StringComparison.InvariantCultureIgnoreCase) || 
                    customer.Lastname.Contains(TxtSearchCustomer.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    foundCustomers.Add(customer);
                }
            }

            GrdCustomers.DataSource = foundCustomers;
        }

        private void CmdSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void CmdSaveCustomer_Click(object sender, EventArgs e)
        {

        }

        private void GrdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
