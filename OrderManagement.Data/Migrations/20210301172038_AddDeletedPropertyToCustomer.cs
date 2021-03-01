using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class AddDeletedPropertyToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Customer");
        }
    }
}
