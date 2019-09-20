using Microsoft.EntityFrameworkCore.Migrations;

namespace ConestogaVirtualGameStore.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Command_games_Gameid",
                table: "Command");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_members_Memberid",
                table: "CreditCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_members_Employeeid",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Familyship_members_Memberid",
                table: "Familyship");

            migrationBuilder.DropForeignKey(
                name: "FK_Familyship_members_Memberid1",
                table: "Familyship");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendship_members_Memberid",
                table: "Friendship");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendship_members_Memberid1",
                table: "Friendship");

            migrationBuilder.DropForeignKey(
                name: "FK_games_members_Employeeid",
                table: "games");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_members_Memberid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_games_Gameid",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_members_Memberid",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_games_Gameid",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_members_Memberid",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_members_Memberid",
                table: "Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_games_Gameid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_members_Memberid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_members_Moderatorid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Wish_games_Gameid",
                table: "Wish");

            migrationBuilder.DropForeignKey(
                name: "FK_Wish_members_Memberid",
                table: "Wish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_members",
                table: "members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_games",
                table: "games");

            migrationBuilder.RenameTable(
                name: "members",
                newName: "Members");

            migrationBuilder.RenameTable(
                name: "games",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_games_Employeeid",
                table: "Games",
                newName: "IX_Games_Employeeid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_Games_Gameid",
                table: "Command",
                column: "Gameid",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_Members_Memberid",
                table: "CreditCard",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Members_Employeeid",
                table: "Event",
                column: "Employeeid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familyship_Members_Memberid",
                table: "Familyship",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familyship_Members_Memberid1",
                table: "Familyship",
                column: "Memberid1",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendship_Members_Memberid",
                table: "Friendship",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendship_Members_Memberid1",
                table: "Friendship",
                column: "Memberid1",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Members_Memberid",
                table: "Order",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_Games_Gameid",
                table: "Ownership",
                column: "Gameid",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_Members_Memberid",
                table: "Ownership",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Games_Gameid",
                table: "Rating",
                column: "Gameid",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Members_Memberid",
                table: "Rating",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Members_Memberid",
                table: "Registration",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Games_Gameid",
                table: "Review",
                column: "Gameid",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Members_Memberid",
                table: "Review",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Members_Moderatorid",
                table: "Review",
                column: "Moderatorid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wish_Games_Gameid",
                table: "Wish",
                column: "Gameid",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wish_Members_Memberid",
                table: "Wish",
                column: "Memberid",
                principalTable: "Members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Command_Games_Gameid",
                table: "Command");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_Members_Memberid",
                table: "CreditCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Members_Employeeid",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Familyship_Members_Memberid",
                table: "Familyship");

            migrationBuilder.DropForeignKey(
                name: "FK_Familyship_Members_Memberid1",
                table: "Familyship");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendship_Members_Memberid",
                table: "Friendship");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendship_Members_Memberid1",
                table: "Friendship");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Members_Employeeid",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Members_Memberid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Games_Gameid",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Members_Memberid",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Games_Gameid",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Members_Memberid",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Members_Memberid",
                table: "Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Games_Gameid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Members_Memberid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Members_Moderatorid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Wish_Games_Gameid",
                table: "Wish");

            migrationBuilder.DropForeignKey(
                name: "FK_Wish_Members_Memberid",
                table: "Wish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Members",
                newName: "members");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "games");

            migrationBuilder.RenameIndex(
                name: "IX_Games_Employeeid",
                table: "games",
                newName: "IX_games_Employeeid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_members",
                table: "members",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_games",
                table: "games",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_games_Gameid",
                table: "Command",
                column: "Gameid",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_members_Memberid",
                table: "CreditCard",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_members_Employeeid",
                table: "Event",
                column: "Employeeid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familyship_members_Memberid",
                table: "Familyship",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familyship_members_Memberid1",
                table: "Familyship",
                column: "Memberid1",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendship_members_Memberid",
                table: "Friendship",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendship_members_Memberid1",
                table: "Friendship",
                column: "Memberid1",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_games_members_Employeeid",
                table: "games",
                column: "Employeeid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_members_Memberid",
                table: "Order",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_games_Gameid",
                table: "Ownership",
                column: "Gameid",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_members_Memberid",
                table: "Ownership",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_games_Gameid",
                table: "Rating",
                column: "Gameid",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_members_Memberid",
                table: "Rating",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_members_Memberid",
                table: "Registration",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_games_Gameid",
                table: "Review",
                column: "Gameid",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_members_Memberid",
                table: "Review",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_members_Moderatorid",
                table: "Review",
                column: "Moderatorid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wish_games_Gameid",
                table: "Wish",
                column: "Gameid",
                principalTable: "games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wish_members_Memberid",
                table: "Wish",
                column: "Memberid",
                principalTable: "members",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
