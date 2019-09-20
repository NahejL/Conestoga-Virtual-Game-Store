using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Familyship_members_Memberid2",
                table: "Familyship");

            migrationBuilder.DropForeignKey(
                name: "FK_Familyship_members_Memberid3",
                table: "Familyship");

            migrationBuilder.DropIndex(
                name: "IX_Familyship_Memberid2",
                table: "Familyship");

            migrationBuilder.DropIndex(
                name: "IX_Familyship_Memberid3",
                table: "Familyship");

            migrationBuilder.DropColumn(
                name: "Memberid2",
                table: "Familyship");

            migrationBuilder.DropColumn(
                name: "Memberid3",
                table: "Familyship");

            migrationBuilder.CreateTable(
                name: "Friendship",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Memberid = table.Column<int>(nullable: true),
                    Memberid1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendship", x => x.id);
                    table.ForeignKey(
                        name: "FK_Friendship_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friendship_members_Memberid1",
                        column: x => x.Memberid1,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friendship_Memberid",
                table: "Friendship",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Friendship_Memberid1",
                table: "Friendship",
                column: "Memberid1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendship");

            migrationBuilder.AddColumn<int>(
                name: "Memberid2",
                table: "Familyship",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Memberid3",
                table: "Familyship",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Familyship_Memberid2",
                table: "Familyship",
                column: "Memberid2");

            migrationBuilder.CreateIndex(
                name: "IX_Familyship_Memberid3",
                table: "Familyship",
                column: "Memberid3");

            migrationBuilder.AddForeignKey(
                name: "FK_Familyship_members_Memberid2",
                table: "Familyship",
                column: "Memberid2",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familyship_members_Memberid3",
                table: "Familyship",
                column: "Memberid3",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
