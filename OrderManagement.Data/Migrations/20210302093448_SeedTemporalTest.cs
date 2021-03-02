using System;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedTemporalTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql($"INSERT INTO Customer (Prename, Lastname, Street, StreetNr, Zip, City, CountryCode)" +
                                 $"VALUES ('Temporal', 'Test', 'Gottwilerstrasse', '12', '9000', 'St. Gallen', 'CH')");

            var firstDate = DateTime.Now.AddHours(-1);
            var sqlFirstDateString = firstDate.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
            migrationBuilder.Sql($"INSERT INTO [dbo].[Order] ([Date]) VALUES ('{sqlFirstDateString}')");
            migrationBuilder.Sql($"UPDATE [dbo].[Order] SET CustomerId = customer.id FROM (SELECT Id FROM [dbo].[Customer] WHERE Prename = 'Temporal') AS customer WHERE date = '{sqlFirstDateString}'");
            migrationBuilder.Sql($"UPDATE [dbo].[Order] SET InvoiceDate = '{DateTime.Now:u}' WHERE date = '{sqlFirstDateString}'");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
