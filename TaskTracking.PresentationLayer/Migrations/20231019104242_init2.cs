using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTracking.PresentationLayer.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Departman",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departman",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");
        }
    }
}
