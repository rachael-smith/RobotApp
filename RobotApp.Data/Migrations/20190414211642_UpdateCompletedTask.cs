using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotApp.Data.Migrations
{
    public partial class UpdateCompletedTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "CompletedTasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "CompletedTasks");
        }
    }
}
