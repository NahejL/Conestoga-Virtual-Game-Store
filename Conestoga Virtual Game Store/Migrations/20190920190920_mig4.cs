using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "postal_code",
                table: "members",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.id);
                    table.ForeignKey(
                        name: "FK_CreditCard_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditCard_Memberid",
                table: "CreditCard",
                column: "Memberid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCard");

            migrationBuilder.DropColumn(
                name: "address",
                table: "members");

            migrationBuilder.DropColumn(
                name: "city",
                table: "members");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "members");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "members");

            migrationBuilder.DropColumn(
                name: "postal_code",
                table: "members");
        }
    }
}
