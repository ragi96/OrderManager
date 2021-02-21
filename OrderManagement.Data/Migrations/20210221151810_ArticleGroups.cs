using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class ArticleGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleGroup_ArticleGroup_SuperiorArticleGroupId",
                table: "ArticleGroup");

            migrationBuilder.RenameColumn(
                name: "SuperiorArticleGroupId",
                table: "ArticleGroup",
                newName: "SuperiorArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleGroup_SuperiorArticleGroupId",
                table: "ArticleGroup",
                newName: "IX_ArticleGroup_SuperiorArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleGroup_ArticleGroup_SuperiorArticleId",
                table: "ArticleGroup",
                column: "SuperiorArticleId",
                principalTable: "ArticleGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleGroup_ArticleGroup_SuperiorArticleId",
                table: "ArticleGroup");

            migrationBuilder.RenameColumn(
                name: "SuperiorArticleId",
                table: "ArticleGroup",
                newName: "SuperiorArticleGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleGroup_SuperiorArticleId",
                table: "ArticleGroup",
                newName: "IX_ArticleGroup_SuperiorArticleGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleGroup_ArticleGroup_SuperiorArticleGroupId",
                table: "ArticleGroup",
                column: "SuperiorArticleGroupId",
                principalTable: "ArticleGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
