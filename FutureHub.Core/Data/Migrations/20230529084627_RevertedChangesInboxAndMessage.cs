using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_FutureHub.Data.Migrations
{
    public partial class RevertedChangesInboxAndMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecieverID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "InboxId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Inboxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RecieverId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inboxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inboxes_Users_RecieverId",
                        column: x => x.RecieverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inboxes_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_InboxId",
                table: "Messages",
                column: "InboxId");

            migrationBuilder.CreateIndex(
                name: "IX_Inboxes_RecieverId",
                table: "Inboxes",
                column: "RecieverId");

            migrationBuilder.CreateIndex(
                name: "IX_Inboxes_SenderId",
                table: "Inboxes",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Inboxes_InboxId",
                table: "Messages",
                column: "InboxId",
                principalTable: "Inboxes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Inboxes_InboxId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Inboxes");

            migrationBuilder.DropIndex(
                name: "IX_Messages_InboxId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "InboxId",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "RecieverID",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderID",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
