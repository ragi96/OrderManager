using Microsoft.EntityFrameworkCore.Migrations;
using OrderManagement.Data.Model;
using System;
using System.Collections.Generic;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var orders = new List<Order>();
            var random = new Random();

            for (var i = 0; i < 200; i++)
            {
                var year = random.Next(2018, 2021);
                var month = random.Next(1, 13);
                var day = random.Next(1, 26);
                var hour = random.Next(1, 24);
                var minute = random.Next(1, 60);
                var second = random.Next(1, 60);
                var invoiceDays = random.Next(1, 6);

                var order = new Order
                {
                    Date = new DateTime(year, month, day, hour, minute, second)
                };

                if (invoiceDays + day > 26)
                {
                    order.InvoiceDate = new DateTime(year, month, day + 1, hour, minute, second);
                }
                else
                {
                    order.InvoiceDate = new DateTime(year, month, day + invoiceDays, hour, minute, second);
                }

                order.CustomerId = random.Next(1, 8);

                orders.Add(order);
            }

            foreach (var order in orders)
            {
                migrationBuilder.Sql($"INSERT INTO [dbo].[Order] ([Date],[CustomerId],[InvoiceDate]) VALUES ('{order.Date:u}','{order.CustomerId}', '{order.InvoiceDate?.ToString("u")}')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
