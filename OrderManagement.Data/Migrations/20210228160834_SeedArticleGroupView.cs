using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Data.Migrations
{
    public partial class SeedArticleGroupView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE PROCEDURE getArticleGroupTree AS BEGIN WITH cte_articlegroup as(SELECT ID, Name, SuperiorArticleId, 0 AS TreeLevel, CAST(ID AS VARCHAR(255)) AS TreePath FROM ArticleGroup AG1 WHERE SuperiorArticleId IS NULL UNION ALL SELECT AG2.ID, AG2.Name, AG2.SuperiorArticleId, TreeLevel + 1, CAST(TreePath + '.' + CAST(AG2.ID AS VARCHAR(255)) AS VARCHAR(255)) AS TreePath FROM ArticleGroup AG2 INNER JOIN cte_articlegroup itms ON itms.ID = AG2.SuperiorArticleId) SELECT * FROM cte_articlegroup Order By TreeLevel ASC END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
