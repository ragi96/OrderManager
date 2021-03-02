using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedArticleGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Main Groups
            migrationBuilder.Sql("INSERT INTO ArticleGroup (Name) VALUES ('Elektronik')");
            migrationBuilder.Sql("INSERT INTO ArticleGroup (Name) VALUES ('Haushaltswaren')");
            migrationBuilder.Sql("INSERT INTO ArticleGroup (Name) VALUES ('Möbel')");

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

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ArticleGroup DBCC CHECKIDENT('ArticleGroup',RESEED, 0)");
        }
    }
}
