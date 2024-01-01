using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTracking.PresentationLayer.Migrations
{
    public partial class resettestinit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjeEvent",
                columns: table => new
                {
                    ProjeEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeDescription = table.Column<string>(nullable: true),
                    EventEmpFK_ID = table.Column<int>(nullable: false),
                    Employeesemp_ID = table.Column<int>(nullable: true),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeEvent", x => x.ProjeEventID);
                    table.ForeignKey(
                        name: "FK_ProjeEvent_Employees_Employeesemp_ID",
                        column: x => x.Employeesemp_ID,
                        principalTable: "Employees",
                        principalColumn: "emp_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjeEvent_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjeEvent_Employeesemp_ID",
                table: "ProjeEvent",
                column: "Employeesemp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjeEvent_ProjectID",
                table: "ProjeEvent",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjeEvent");
        }
    }
}
