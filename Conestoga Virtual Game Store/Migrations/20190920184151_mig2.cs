using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
