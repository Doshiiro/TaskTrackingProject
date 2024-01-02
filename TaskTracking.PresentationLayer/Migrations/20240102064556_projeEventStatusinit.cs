using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTracking.PresentationLayer.Migrations
{
    public partial class projeEventStatusinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ProjeEvent",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ProjeEvent");
        }
    }
}
