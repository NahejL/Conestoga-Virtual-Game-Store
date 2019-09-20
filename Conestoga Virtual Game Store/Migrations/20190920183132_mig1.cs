using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_members_Memberid",
                table: "members");

            migrationBuilder.DropIndex(
                name: "IX_members_Memberid",
                table: "members");

            migrationBuilder.DropColumn(
                name: "Memberid",
                table: "members");

            migrationBuilder.CreateTable(
                name: "Familyship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Memberid = table.Column<int>(nullable: true),
                    Memberid1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familyship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Familyship_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Familyship_members_Memberid1",
                        column: x => x.Memberid1,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Familyship_Memberid",
                table: "Familyship",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Familyship_Memberid1",
                table: "Familyship",
                column: "Memberid1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Familyship");

            migrationBuilder.AddColumn<int>(
                name: "Memberid",
                table: "members",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_members_Memberid",
                table: "members",
                column: "Memberid");

            migrationBuilder.AddForeignKey(
                name: "FK_members_members_Memberid",
                table: "members",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
