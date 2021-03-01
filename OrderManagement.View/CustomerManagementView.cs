using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            GrdCustomers.DataSource = new BindingList<Customer>(_customers);
            GrdCustomers.Columns["Id"].Visible = false;
            GrdCustomers.Columns["Orders"].Visible = false;
            GrdCustomers.Columns["Deleted"].Visible = false;

            GrdCustomers.CellEndEdit += new DataGridViewCellEventHandler(GrdCustomers_CellEndEdit);
            TxtSearchCustomer.TextChanged += new EventHandler(TxtSearchCustomer_TextChanged);
            GrdCustomers.SelectionChanged += new EventHandler(GrdCustomers_SelectionChanged);
        }

        private void GrdCustomers_SelectionChanged(object sender, EventArgs e)
        {
            int selectedrowindex = GrdCustomers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GrdCustomers.Rows[selectedrowindex];
            string selectedRows = Convert.ToString(selectedRow.Cells["Id"].Value);

            var customerHistory = new List<Customer>();
            using var db = new DataContext();

            customerHistory = db.Customer.FromSqlRaw($"SELECT * FROM [Customer] FOR SYSTEM_TIME ALL WHERE Id = '{Int32.Parse(selectedRows)}'").AsNoTracking().ToList();
            

            if (customerHistory.Count > 0)
            {
                GrdAdressHistory.DataSource = customerHistory;
                foreach (DataGridViewColumn column in GrdAdressHistory.Columns)
                {
                    column.ReadOnly = true;
                }
            }
            else
            {
                GrdAdressHistory.DataSource = null;
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
                GrdCustomers.DataSource = new BindingList<Customer>(await _customerRepo.GetAll());
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

            GrdCustomers.DataSource = new BindingList<Customer>(foundCustomers);
        }

        private void CmdSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void CmdSaveCustomer_Click(object sender, EventArgs e)
        {

        }

        private async void GrdCustomers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int selectedrowindex = GrdCustomers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GrdCustomers.Rows[selectedrowindex];
            string selectedRows = Convert.ToString(selectedRow.Cells["Id"].Value);
            var id = Int32.Parse(selectedRows);

            var customer = await _customerRepo.GetById(id);
            customer.Deleted = true;
            await _customerRepo.Update(customer);
        }
    }
}
