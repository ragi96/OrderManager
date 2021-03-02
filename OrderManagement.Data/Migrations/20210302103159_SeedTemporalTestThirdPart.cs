using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedTemporalTestThirdPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            System.Threading.Thread.Sleep(30000);
            var secondDate = DateTime.Now.AddHours(-1);
            var sqlSecondDateString = secondDate.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
            migrationBuilder.Sql($"INSERT INTO [dbo].[Order] ([Date]) VALUES ('{sqlSecondDateString}')");
            migrationBuilder.Sql($"UPDATE [dbo].[Order] SET CustomerId = parent.id FROM (SELECT Id FROM [dbo].[Customer] WHERE Prename = 'Temporal') AS parent WHERE date = '{sqlSecondDateString}'");
            migrationBuilder.Sql($"UPDATE [dbo].[Order] SET InvoiceDate = '{DateTime.Now:u}' WHERE date = '{sqlSecondDateString}'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
