using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Members");

            migrationBuilder.AddColumn<int>(
                name: "member_type",
                table: "Members",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "member_type",
                table: "Members");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Members",
                nullable: false,
                defaultValue: "");
        }
    }
}
