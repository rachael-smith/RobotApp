using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotApp.Data.Migrations
{
    public partial class UpdateCompletedChores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedTasks");

            migrationBuilder.CreateTable(
                name: "CompletedChores",
                columns: table => new
                {
                    CompletedChoreID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChoreCompletedID = table.Column<int>(nullable: false),
                    RobotCompletedID = table.Column<int>(nullable: false),
                    TimeTakenToComplete = table.Column<long>(nullable: false),
                    TimeCompleted = table.Column<DateTime>(nullable: false),
                    ChoreCompletedSuccessfully = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedChores", x => x.CompletedChoreID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedChores");

            migrationBuilder.CreateTable(
                name: "CompletedTasks",
                columns: table => new
                {
                    CompletedTaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChoreCompletedSuccessfully = table.Column<bool>(nullable: false),
                    RobotCompletedID = table.Column<int>(nullable: false),
                    TaskCompletedID = table.Column<int>(nullable: false),
                    TimeCompleted = table.Column<DateTime>(nullable: false),
                    TimeTakenToComplete = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedTasks", x => x.CompletedTaskID);
                });
        }
    }
}
