using Microsoft.EntityFrameworkCore.Migrations;
using OrderManagement.Data.Model;
using System;
using System.Collections.Generic;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedPositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            var articlePrices = new string[] { "419.9", "570.9", "870.9", "498.9", "19.9", "53", "39.9", "39.9", "29.9", "19.9", "279.9", "199.9", "259.9", "249.9", "149", "329", "3959.9", "459.9", "1212", "1709", "1399.15", "119.9", "29.9", "149.9", "39.9", "819.9", "99.9" };
            var positions = new List<Position>();

            for (var i = 1; i < 201; i++)
            {
                var index = new Random().Next(1, articlePrices.Length-1);

                var position = new Position
                {
                    OrderId = i,
                    ArticleId = index,
                    Amount = new Random().Next(1, 11)
                };

                if (index == 0)
                {
                    position.ArticlePrice = (Double.Parse(articlePrices[index]));
                }
                else
                {
                    position.ArticlePrice = (Double.Parse(articlePrices[index - 1]));
                }

                positions.Add(position);
            }

            for (var i = 1; i < 100; i++)
            {
                var index = new Random().Next(1, articlePrices.Length-1);

                var position = new Position
                {
                    OrderId = new Random().Next(1, 200),
                    ArticleId = new Random().Next(1, 27),
                    Amount = new Random().Next(1, 11)
                };

                if (index == 0)
                {
                    position.ArticlePrice = (Double.Parse(articlePrices[index]));
                }
                else
                {
                    position.ArticlePrice = (Double.Parse(articlePrices[index - 1]));
                }

                positions.Add(position);
            }

            foreach (var pos in positions)
            {
                migrationBuilder.Sql($"INSERT INTO [Position] ([ArticleId],[OrderId],[ArticlePrice],[Amount],[Number]) VALUES ('{pos.ArticleId}','{pos.OrderId}',CAST('{pos.ArticlePrice}' AS float),'{pos.Amount}', '1')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
