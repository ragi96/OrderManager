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
            var notDeletedCustomers = _customers.Where(elem => elem.Deleted != true).ToList();

            GrdCustomers.DataSource = new BindingList<Customer>(notDeletedCustomers);
            GrdCustomers.Columns["Id"].Visible = false;
            GrdCustomers.Columns["Orders"].Visible = false;
            GrdCustomers.Columns["Deleted"].Visible = false;

            GrdCustomers.CellEndEdit += new DataGridViewCellEventHandler(GrdCustomers_CellEndEdit);
            TxtSearchCustomer.TextChanged += new EventHandler(TxtSearchCustomer_TextChanged);
            GrdCustomers.SelectionChanged += new EventHandler(GrdCustomers_SelectionChanged);
        }

        private void GrdCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var currentRow = GrdCustomers.CurrentCell.RowIndex;
            var currentCustomer = GrdCustomers.CurrentRow.DataBoundItem as Customer;
            if (currentCustomer != null)
            {
                var customerHistory = new List<Customer>();
                using var db = new DataContext();

                customerHistory = db.Customer.FromSqlRaw($"SELECT * FROM [Customer] FOR SYSTEM_TIME ALL WHERE Id = '{currentCustomer.Id}'").AsNoTracking().ToList();

                if (customerHistory.Count > 0)
                {
                    GrdAdressHistory.DataSource = customerHistory;
                    GrdAdressHistory.Columns["Id"].Visible = false;
                    GrdAdressHistory.Columns["Orders"].Visible = false;
                    GrdAdressHistory.Columns["Deleted"].Visible = false;
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
        }

        private async void GrdCustomers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            var currentCustomer = GrdCustomers.CurrentRow.DataBoundItem as Customer;

            if(currentCustomer.Id == 0)
            {
                var valid = true;
                if (string.IsNullOrEmpty(currentCustomer.Prename))
                {
                    valid = false;
                    // error number
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Vorname darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.Lastname))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Nachname darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.Street))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Strasse darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.StreetNr))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Strassen-Nr. darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.City))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Stadt darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.Zip))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "ZIP darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.CountryCode))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Länderkürzel darf nicht leer sein!";
                }

                if (valid)
                {
                    await _customerRepo.Create(currentCustomer);
                }
                
            } else
            {
                var valid = true;
                if (string.IsNullOrEmpty(currentCustomer.Prename))
                {
                    valid = false;
                    // error number
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Vorname darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.Lastname))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Nachname darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.Street))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Strasse darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.StreetNr))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Strassen-Nr. darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.City))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Stadt darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.Zip))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "ZIP darf nicht leer sein!";
                }

                if (string.IsNullOrEmpty(currentCustomer.CountryCode))
                {
                    valid = false;
                    GrdCustomers.Rows[e.RowIndex].ErrorText = "Länderkürzel darf nicht leer sein!";
                }

                if (valid)
                {
                    await _customerRepo.Update(currentCustomer);
                }
            }

            GrdCustomers.Rows[currentRow].ErrorText = String.Empty;
        }

        private async void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtSearchCustomer.Text))
            {
                GrdCustomers.ClearSelection();
                GrdCustomers.DataSource = new BindingList<Customer>((await _customerRepo.GetAll()).Where(elem => elem.Deleted != true).ToList());
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
