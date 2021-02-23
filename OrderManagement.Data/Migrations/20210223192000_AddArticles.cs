using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class AddArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Article DBCC CHECKIDENT('Article',RESEED, 0)");
        }
    }
}
