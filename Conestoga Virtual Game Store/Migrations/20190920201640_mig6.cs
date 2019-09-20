using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Moderatorid",
                table: "Review",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Eventid",
                table: "Registration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "members",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Employeeid",
                table: "games",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Employeeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.id);
                    table.ForeignKey(
                        name: "FK_Event_members_Employeeid",
                        column: x => x.Employeeid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_Moderatorid",
                table: "Review",
                column: "Moderatorid");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_Eventid",
                table: "Registration",
                column: "Eventid");

            migrationBuilder.CreateIndex(
                name: "IX_games_Employeeid",
                table: "games",
                column: "Employeeid");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Employeeid",
                table: "Event",
                column: "Employeeid");

            migrationBuilder.AddForeignKey(
                name: "FK_games_members_Employeeid",
                table: "games",
                column: "Employeeid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Event_Eventid",
                table: "Registration",
                column: "Eventid",
                principalTable: "Event",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_members_Moderatorid",
                table: "Review",
                column: "Moderatorid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_members_Employeeid",
                table: "games");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Event_Eventid",
                table: "Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_members_Moderatorid",
                table: "Review");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Review_Moderatorid",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Registration_Eventid",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_games_Employeeid",
                table: "games");

            migrationBuilder.DropColumn(
                name: "Moderatorid",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Eventid",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "members");

            migrationBuilder.DropColumn(
                name: "Employeeid",
                table: "games");
        }
    }
}
