using System;
using System.Windows.Forms;
using OrderManagment.View;

namespace OrderManagement.View
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void CmdCustomerManagement_Click(object sender, EventArgs e)
        {
            var view = new CustomerManagementView();
            view.Show();
            this.Close();
        }

        private void CmdOrderManagement_Click(object sender, EventArgs e)
        {
            var view = new OrderManagementView();
            view.Show();
            this.Close();
        }
        private void CmdArticleManagement_Click(object sender, EventArgs e)
        {
            var view = new ArticleManagementView();
            view.Show();
            this.Close();
        }

        private void CmdYearCompare_Click(object sender, EventArgs e)
        {
            var view = new YearlyCompareView();
            view.Show();
            this.Close();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
