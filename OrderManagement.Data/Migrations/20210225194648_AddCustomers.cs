using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class AddCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Customer DBCC CHECKIDENT('ArticleGroup',RESEED, 0)");
        }
    }
}
