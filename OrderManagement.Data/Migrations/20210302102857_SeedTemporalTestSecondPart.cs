using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedTemporalTestSecondPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            System.Threading.Thread.Sleep(10000);
            migrationBuilder.Sql($"UPDATE Customer SET Lastname = 'Neuer Nachname', Street = 'Neue Strasse' WHERE Prename = 'Temporal'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
