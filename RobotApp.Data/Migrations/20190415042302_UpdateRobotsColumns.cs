using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotApp.Data.Migrations
{
    public partial class UpdateRobotsColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Robots",
                newName: "RobotName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RobotName",
                table: "Robots",
                newName: "Name");
        }
    }
}
