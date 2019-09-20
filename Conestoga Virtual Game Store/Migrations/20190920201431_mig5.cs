using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameOwnership");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Familyship",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                    table.ForeignKey(
                        name: "FK_Order_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ownership",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gameid = table.Column<int>(nullable: true),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ownership", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ownership_games_Gameid",
                        column: x => x.Gameid,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ownership_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gameid = table.Column<int>(nullable: true),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rating_games_Gameid",
                        column: x => x.Gameid,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rating_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.id);
                    table.ForeignKey(
                        name: "FK_Registration_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gameid = table.Column<int>(nullable: true),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.id);
                    table.ForeignKey(
                        name: "FK_Review_games_Gameid",
                        column: x => x.Gameid,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wish",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gameid = table.Column<int>(nullable: true),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wish", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wish_games_Gameid",
                        column: x => x.Gameid,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wish_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Command",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gameid = table.Column<int>(nullable: true),
                    Orderid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Command", x => x.id);
                    table.ForeignKey(
                        name: "FK_Command_games_Gameid",
                        column: x => x.Gameid,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Command_Order_Orderid",
                        column: x => x.Orderid,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Command_Gameid",
                table: "Command",
                column: "Gameid");

            migrationBuilder.CreateIndex(
                name: "IX_Command_Orderid",
                table: "Command",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Memberid",
                table: "Order",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_Gameid",
                table: "Ownership",
                column: "Gameid");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_Memberid",
                table: "Ownership",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_Gameid",
                table: "Rating",
                column: "Gameid");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_Memberid",
                table: "Rating",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_Memberid",
                table: "Registration",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Review_Gameid",
                table: "Review",
                column: "Gameid");

            migrationBuilder.CreateIndex(
                name: "IX_Review_Memberid",
                table: "Review",
                column: "Memberid");

            migrationBuilder.CreateIndex(
                name: "IX_Wish_Gameid",
                table: "Wish",
                column: "Gameid");

            migrationBuilder.CreateIndex(
                name: "IX_Wish_Memberid",
                table: "Wish",
                column: "Memberid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Command");

            migrationBuilder.DropTable(
                name: "Ownership");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Wish");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Familyship",
                newName: "Id");

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
                name: "GameOwnership",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gameid = table.Column<int>(nullable: true),
                    Memberid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameOwnership", x => x.id);
                    table.ForeignKey(
                        name: "FK_GameOwnership_games_Gameid",
                        column: x => x.Gameid,
                        principalTable: "games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameOwnership_members_Memberid",
                        column: x => x.Memberid,
                        principalTable: "members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameOwnership_Gameid",
                table: "GameOwnership",
                column: "Gameid");

            migrationBuilder.CreateIndex(
                name: "IX_GameOwnership_Memberid",
                table: "GameOwnership",
                column: "Memberid");
        }
    }
}
