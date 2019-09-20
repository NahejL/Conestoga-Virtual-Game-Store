using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Employees_Employeeid",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Employees_Employeeid",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Members",
                newName: "ModeratorProp");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeProp",
                table: "Members",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Members_Employeeid",
                table: "Event",
                column: "Employeeid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Members_Employeeid",
                table: "Games",
                column: "Employeeid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Members_Employeeid",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Members_Employeeid",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "EmployeeProp",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "ModeratorProp",
                table: "Members",
                newName: "MyProperty");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Employees_Employeeid",
                table: "Event",
                column: "Employeeid",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Employees_Employeeid",
                table: "Games",
                column: "Employeeid",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
