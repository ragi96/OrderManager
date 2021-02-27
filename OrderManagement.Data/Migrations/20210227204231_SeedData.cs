using Microsoft.EntityFrameworkCore.Migrations;
using OrderManagement.Data.Model;
using System;
using System.Collections.Generic;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region Article Groups

            // Main Groups
            migrationBuilder.Sql("INSERT INTO ArticleGroup VALUES ('Elektronik', null)");
            migrationBuilder.Sql("INSERT INTO ArticleGroup VALUES ('Haushaltswaren', null)");
            migrationBuilder.Sql("INSERT INTO ArticleGroup VALUES ('Möbel', null)");

            // Sub Groups Elektronik
            var parentGroupName = "Elektronik";
            var groupName = "Computer";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Smartphone";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");

            groupName = "Fernseher";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            // Sub Groups Haushaltswaren

            parentGroupName = "Haushaltswaren";
            groupName = "Küche";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Bad";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Lampen";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            // Sub Groups Möbel
            parentGroupName = "Möbel";
            groupName = "Bettwaren";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Schränke";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");

            // Subsub Groups Computers
            parentGroupName = "Computer";
            groupName = "Komplettsysteme";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Grafikkarten";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Mainboards";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Peripherie - Geräte";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            // Subsub Groups Bettwaren
            parentGroupName = "Bettwaren";
            groupName = "Bettwäsche";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Bett";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Matratzen";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");

            // subsubsub Groups Peripherie
            parentGroupName = "Peripherie - Geräte";
            groupName = "Maus";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Tastatur";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");
            groupName = "Drucker";
            migrationBuilder.Sql($"INSERT INTO ArticleGroup (Name) VALUES ('{groupName}')");
            migrationBuilder.Sql($"UPDATE ArticleGroup SET SuperiorArticleId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{parentGroupName}') AS parent WHERE name = '{groupName}'");

            #endregion

            #region Article Group View
            migrationBuilder.Sql("CREATE PROCEDURE getArticleGroupTree AS BEGIN WITH cte_articlegroup as(SELECT ID, Name, SuperiorArticleId, 0 AS TreeLevel, CAST(ID AS VARCHAR(255)) AS TreePath FROM ArticleGroup AG1 WHERE SuperiorArticleId IS NULL UNION ALL SELECT AG2.ID, AG2.Name, AG2.SuperiorArticleId, TreeLevel + 1, CAST(TreePath + '.' + CAST(AG2.ID AS VARCHAR(255)) AS VARCHAR(255)) AS TreePath FROM ArticleGroup AG2 INNER JOIN cte_articlegroup itms ON itms.ID = AG2.SuperiorArticleId) SELECT * FROM cte_articlegroup Order By TreeLevel ASC END");
            #endregion

            #region Articles
            var articleGroup = "Smartphone";
            var article = "Google Pixel 4a";

            var number = 1000;
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '419.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Google Pixel 5";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '570.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "iPhone 12 128GB";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '870.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "iPhone XR 64GB";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '498.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            articleGroup = "Maus";
            article = "GIGABYTE AORUS M2";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '19.9', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "HP Spectre Maus 700";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '53.00', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "HP Omen 400";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '39.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "HP Omen 600";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '39.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            articleGroup = "Tastatur";
            article = "Trust Primo";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '29.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "LogiLink Tastatur Flexibel & Wasserfest";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '19.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Logitech G915 TKL GL Wireless Gaming";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '279.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Logitech G915 Lightspeed Wireless Mechanical Gaming ";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '199.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            articleGroup = "Matratzen";
            article = "Emma One";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '259.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Sanaflex one";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '249.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Sanaflex Youth";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '149.00', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Sanaflex Wave";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '329.00', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            articleGroup = "Bett";
            article = "Navier";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '3959.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Marron";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '459.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Hasena Woodline";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '1212.00', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Don";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '1709.00', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Aurore";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '1399.15', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            articleGroup = "Bettwäsche";
            article = "Manor Marmar Duvetbezug";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '119.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Manor Marmar Kissenbezug";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '29.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Manor Logan Duvetbezug";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '149.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "Manor Logan Kissenbezug";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '39.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            articleGroup = "Peripherie - Geräte";
            article = "Canon imagePROGRAF Pro-300";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '819.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");
            article = "HP Tango X";
            migrationBuilder.Sql($"INSERT INTO Article (Number, Name, Price, Mwst) VALUES ({number++}, '{article}', '99.90', '7.9')");
            migrationBuilder.Sql($"UPDATE Article SET ArticleGroupId = parent.id FROM (SELECT Id FROM ArticleGroup WHERE Name = '{articleGroup}') AS parent WHERE name = '{article}'");

            #endregion

            #region Customers
            string[] prenames = new string[] { "Bernd", "Thomas", "Tracie", "Beatrice", "Chantal", "Gerald", "Bartli", "Fridolin" };
            string[] lastnames = new string[] { "Müller", "Kaiser", "Mengol", "Cost", "Wagner", "Riwa", "Kuhfuerst", "Langfinger" };
            string[] street = new string[] { "Hauptstrasse", "Steigstrasse", "Paradeplatz", "Bahnhofstrasse", "Steigstrasse", "Hauptstrasse", "Hauptstrasse", "Bahnhofstrasse" };
            string[] nr = new string[] { "12", "4", "5", "5", "1", "77", "2", "5" };
            string[] zip = new string[] { "5345", "2342", "2355", "3455", "2324", "1123", "9594", "2383" };
            string[] city = new string[] { "St. Gallen", "Bern", "Zürich", "Kreuzlingen", "Wil", "Wattwil", "Genf", "Lausanne" };
            string[] countryCode = new string[] { "CH", "CH", "CH", "CH", "CH", "CH", "CH", "CH" };

            for (var i = 0; i < 8; i++)
            {
                migrationBuilder.Sql($"INSERT INTO Customer (Prename, Lastname, Street, StreetNr, Zip, City, CountryCode)" +
                                     $"VALUES ('{prenames[i]}', '{lastnames[i]}', '{street[i]}', '{nr[i]}', '{zip[i]}', '{city[i]}', '{countryCode[i]}')");
            }
            #endregion

            #region Orders

            var orders = new List<Order>();
            var random = new Random();

            for (var i = 0; i < 200; i++)
            {
                var year = random.Next(2019, 2022);
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
                migrationBuilder.Sql($"INSERT INTO [dbo].[Order] ([Date],[CustomerId],[InvoiceDate]) VALUES ('{order.Date.ToString("u")}','{order.CustomerId}', '{order.InvoiceDate?.ToString("u")}')");
            }
            #endregion
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
