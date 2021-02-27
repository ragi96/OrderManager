using OrderManagement.Data.Context;
using System;
using System.Windows.Forms;

namespace OrderManagement.View
{
    public partial class YearlyCompareView : Form
    {
        public YearlyCompareView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using var db = new DataContext();

        }
    }
}
