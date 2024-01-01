using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTracking.PresentationLayer.Migrations
{
    public partial class init2133 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectEvent",
                columns: table => new
                {
                    ProjectEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDescription = table.Column<string>(nullable: true),
                    projectEmp_ID = table.Column<int>(nullable: false),
                    Employeesemp_ID = table.Column<int>(nullable: true),
                    ProjectFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectEvent", x => x.ProjectEventID);
                    table.ForeignKey(
                        name: "FK_ProjectEvent_Employees_Employeesemp_ID",
                        column: x => x.Employeesemp_ID,
                        principalTable: "Employees",
                        principalColumn: "emp_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectEvent_Projects_ProjectFK",
                        column: x => x.ProjectFK,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectEvent_Employeesemp_ID",
                table: "ProjectEvent",
                column: "Employeesemp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectEvent_ProjectFK",
                table: "ProjectEvent",
                column: "ProjectFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "ProjectEvent");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
