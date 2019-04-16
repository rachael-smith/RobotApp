using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotApp.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chores",
                columns: table => new
                {
                    ChoreID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChoreName = table.Column<string>(nullable: true),
                    TimeToComplete = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chores", x => x.ChoreID);
                });

            migrationBuilder.CreateTable(
                name: "CompletedTasks",
                columns: table => new
                {
                    CompletedTaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskCompletedID = table.Column<int>(nullable: false),
                    RobotCompletedID = table.Column<int>(nullable: false),
                    TimeTakenToComplete = table.Column<long>(nullable: false),
                    TimeCompleted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedTasks", x => x.CompletedTaskID);
                });

            migrationBuilder.CreateTable(
                name: "Robots",
                columns: table => new
                {
                    RobotID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    RobotTypeID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robots", x => x.RobotID);
                });

            migrationBuilder.CreateTable(
                name: "RobotTypes",
                columns: table => new
                {
                    RobotTypeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RobotTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotTypes", x => x.RobotTypeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chores");

            migrationBuilder.DropTable(
                name: "CompletedTasks");

            migrationBuilder.DropTable(
                name: "Robots");

            migrationBuilder.DropTable(
                name: "RobotTypes");
        }
    }
}
