using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotApp.Data.Migrations
{
    public partial class UpdateRobots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "CompletedTasks",
                newName: "ChoreCompletedSuccessfully");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfChoresCompleted",
                table: "Robots",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfChoresCompleted",
                table: "Robots");

            migrationBuilder.RenameColumn(
                name: "ChoreCompletedSuccessfully",
                table: "CompletedTasks",
                newName: "Status");
        }
    }
}
