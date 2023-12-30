using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTracking.PresentationLayer.Migrations
{
    public partial class departmaninit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectDescription",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectType",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DepartmentID",
                table: "Projects",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmentID",
                table: "Projects",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmentID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DepartmentID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescription",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectType",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
