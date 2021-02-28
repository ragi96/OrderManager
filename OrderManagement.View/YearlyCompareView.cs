using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.View
{
    public partial class YearlyCompareView : Form
    {
        private readonly EfCrudRepository<Article> _articleRepo;
        private readonly EfCrudRepository<Customer> _customerRepo;

        public YearlyCompareView(EfCrudRepository<Article> articleRepo, EfCrudRepository<Customer> customerRepo)
        {
            InitializeComponent();
            _articleRepo = articleRepo;
            _customerRepo = customerRepo;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GrdYearlyCompare.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kategorie", Name = "category", DataPropertyName = "category" });
            for(var year = 2018; year < 2021; year++)
            {
                for(var quarter = 1; quarter < 5; quarter++)
                {
                    GrdYearlyCompare.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = $"Q{quarter} {year}", Name = $"year{year}quarter{quarter}", DataPropertyName = $"year{year}quarter{quarter}" });
                }
            }

            await FillTotalArticles();
            await FillNumOfOrders();
            await FillAverageArticlesPerOrder();
            await FillSalesPerCustomer();
            await FillTotalSales();
        }

        private async Task FillTotalArticles()
        {
            var index = GrdYearlyCompare.Rows.Add();
            var cellsCounter = 0;
            GrdYearlyCompare.Rows[index].Cells[cellsCounter].Value = "Artikel total:";

            for (var year = 2018; year < 2021; year++)
            {
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 1].Value = await GetTotalArticles($"{year}-01-01", $"{year}-04-01");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 2].Value = await GetTotalArticles($"{year}-04-01", $"{year}-07-01");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 3].Value = await GetTotalArticles($"{year}-07-01", $"{year}-10-01");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 4].Value = await GetTotalArticles($"{year}-10-01", $"{year}-12-31");

                cellsCounter += 4;
            }
        }

        private async Task<int> GetTotalArticles(string date1, string date2)
        {
            var totalSales = 0;

            using (var context = new DataContext())
            {
                var conn = context.Database.GetDbConnection();
                await conn.OpenAsync();

                var command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(Id) AS TotalArticles FROM Article";
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    totalSales = (int)reader.GetValue(0);
                }
            }

            return totalSales;
        }

        private async Task<double> GetTotalSales(string date1, string date2)
        {
            double totalSales = 0;

            using (var context = new DataContext())
            {
                var conn = context.Database.GetDbConnection();
                await conn.OpenAsync();

                var command = conn.CreateCommand();
                command.CommandText = "SELECT SUM(TotalPerOrder) FROM (SELECT [dbo].[Order].[InvoiceDate], SUM(ArticlePrice * Amount) AS TotalPerOrder "+
                    " FROM [dbo].[Position] INNER JOIN[dbo].[Order] ON[dbo].[Order].[Id] = [dbo].[Position].[OrderId] "+
                    $" WHERE[OrderManager].[dbo].[Order].[InvoiceDate] BETWEEN '{date1}' AND '{date2}' GROUP BY[dbo].[Order].[InvoiceDate] ) MyTable";
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    totalSales = Math.Round((double)reader.GetValue(0), 2);
                }
            }

            return totalSales;
        }

        private async Task FillTotalSales()
        {
            var index = GrdYearlyCompare.Rows.Add();
            var cellsCounter = 0;
            GrdYearlyCompare.Rows[index].Cells[cellsCounter].Value = "Umsatz total:";

            for (var year = 2018; year < 2021; year++)
            {
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 1].Value = await GetTotalSales($"{year}-01-01", $"{year}-04-01") + " CHF";
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 2].Value = await GetTotalSales($"{year}-04-01", $"{year}-07-01") + " CHF";
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 3].Value = await GetTotalSales($"{year}-07-01", $"{year}-10-01") + " CHF";
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 4].Value = await GetTotalSales($"{year}-10-01", $"{year}-12-31") + " CHF";

                cellsCounter += 4;
            }
        }

        private async Task FillSalesPerCustomer()
        {
            var index = GrdYearlyCompare.Rows.Add();
            GrdYearlyCompare.Rows[index].Height = 200;
            var cellsCounter = 0;
            GrdYearlyCompare.Rows[index].Cells[cellsCounter].Value = "Umsatz pro Kunde:";

            var customers = await _customerRepo.GetAll();

            for (var year = 2018; year < 2021; year++)
            {
                var totalQ1 = await GetSalesPerCustomer($"{year}-01-01", $"{year}-04-01");
                var totalQ2 = await GetSalesPerCustomer($"{year}-04-01", $"{year}-07-01");
                var totalQ3 = await GetSalesPerCustomer($"{year}-07-01", $"{year}-10-01");
                var totalQ4 = await GetSalesPerCustomer($"{year}-10-01", $"{year}-12-31");

                for(var i = 0; i < totalQ1.Count; i++)
                {
                    GrdYearlyCompare.Rows[index].Cells[cellsCounter + 1].Value += customers[i].Fullname + ": " + totalQ1[i] + " CHF" + Environment.NewLine;
                }

                for (var i = 0; i < totalQ2.Count; i++)
                {
                    GrdYearlyCompare.Rows[index].Cells[cellsCounter + 2].Value += customers[i].Fullname + ": " + totalQ2[i] + " CHF" + Environment.NewLine;
                }

                for (var i = 0; i < totalQ3.Count; i++)
                {
                    GrdYearlyCompare.Rows[index].Cells[cellsCounter + 3].Value += customers[i].Fullname + ": " + totalQ3[i] + " CHF" + Environment.NewLine;
                }

                for (var i = 0; i < totalQ4.Count; i++)
                {
                    GrdYearlyCompare.Rows[index].Cells[cellsCounter + 4].Value += customers[i].Fullname + ": " + totalQ4[i] + " CHF" + Environment.NewLine;
                }

                cellsCounter += 4;
            }
        }

        private async Task<List<double>> GetSalesPerCustomer(string date1, string date2)
        {
            var totalPerCustomer = new List<double>();

            using (var context = new DataContext())
            {
                var conn = context.Database.GetDbConnection();
                await conn.OpenAsync();

                var command = conn.CreateCommand();
                command.CommandText = $"SELECT [OrderManager].[dbo].[Order].[CustomerId], SUM(ArticlePrice * Amount) AS TotalPerOrder FROM[OrderManager].[dbo].[Position] INNER JOIN[OrderManager].[dbo].[Order] ON[OrderManager].[dbo].[Position].[OrderId] = [OrderManager].[dbo].[Order].[Id] WHERE[OrderManager].[dbo].[Order].[InvoiceDate] BETWEEN '{date1}' AND '{date2}' GROUP BY CustomerId";
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    totalPerCustomer.Add(Math.Round((double)reader.GetValue(1), 2));
                }
            }

            return totalPerCustomer;
        }

        private async Task FillAverageArticlesPerOrder()
        {
            var index = GrdYearlyCompare.Rows.Add();
            var cellsCounter = 0;
            GrdYearlyCompare.Rows[index].Cells[cellsCounter].Value = "Durchschnittliche Anzahl Artikel pro Auftrag:";

            for (var year = 2018; year < 2021; year++)
            {
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 1].Value = await GetAverageArticlesPerOrder($"{year}-01-01", $"{year}-04-01");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 2].Value = await GetAverageArticlesPerOrder($"{year}-04-01", $"{year}-07-01");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 3].Value = await GetAverageArticlesPerOrder($"{year}-07-01", $"{year}-10-01");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 4].Value = await GetAverageArticlesPerOrder($"{year}-10-01", $"{year}-12-31");

                cellsCounter += 4;
            }
        }

        private async Task<int> GetAverageArticlesPerOrder(string date1, string date2)
        {
            var average = 0;

            using (var context = new DataContext())
            {
                var conn = context.Database.GetDbConnection();
                await conn.OpenAsync();

                var command = conn.CreateCommand();
                command.CommandText = "SELECT AVG(Average) AS TotalAverage FROM (SELECT [dbo].[Order].[Id], AVG([dbo].[Position].Amount) AS " + 
                    " Average FROM[dbo].[Order] INNER JOIN[dbo].[Position] ON[dbo].[Order].[Id] = [dbo].[Position].OrderId " + 
                    $" WHERE[dbo].[Order].[InvoiceDate] BETWEEN '{date1}' AND '{date2}'GROUP BY [dbo].[Order].[Id]) MyTable";
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    average = (int)reader.GetValue(0);
                }
            }

            return average;
        }

        private async Task FillNumOfOrders()
        {
            var index = GrdYearlyCompare.Rows.Add();
            var cellsCounter = 0;
            GrdYearlyCompare.Rows[index].Cells[cellsCounter].Value = "Anzahl Aufträge:";

            for (var year = 2018; year < 2021; year++)
            {
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 1].Value = await GetNumOfOrders($"SELECT COUNT(*) FROM [OrderManager].[dbo].[Order]  WHERE [Date] BETWEEN '{year}-01-01' AND '{year}-04-01'");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 2].Value = await GetNumOfOrders($"SELECT COUNT(*) FROM [OrderManager].[dbo].[Order]  WHERE [Date] BETWEEN '{year}-04-01' AND '{year}-07-01'");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 3].Value = await GetNumOfOrders($"SELECT COUNT(*) FROM [OrderManager].[dbo].[Order]  WHERE [Date] BETWEEN '{year}-07-01' AND '{year}-10-01'");
                GrdYearlyCompare.Rows[index].Cells[cellsCounter + 4].Value = await GetNumOfOrders($"SELECT COUNT(*) FROM [OrderManager].[dbo].[Order]  WHERE [Date] BETWEEN '{year}-10-01' AND '{year}-12-31'");

                cellsCounter += 4;
            }
        }

        private async Task<int> GetNumOfOrders(string query)
        {
            var numOf = 0;

            using (var context = new DataContext())
            {
                var conn = context.Database.GetDbConnection();
                await conn.OpenAsync();

                var command = conn.CreateCommand();
                command.CommandText = query;
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    numOf = (int)reader.GetValue(0);
                }
            }

            return numOf;
        }
    }
}
