using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentManagement.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupAssignment",
                columns: table => new
                {
                    GroupId = table.Column<string>(nullable: false),
                    ProblemId = table.Column<string>(nullable: false),
                    SubmissionDeadline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupAssignment", x => new { x.ProblemId, x.GroupId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupAssignment");
        }
    }
}
