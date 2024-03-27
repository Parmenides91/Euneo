using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euneo.Data.Migrations
{
    /// <inheritdoc />
    public partial class tipoConversacion_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConversationTypeId",
                table: "Conversation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConversationType",
                columns: table => new
                {
                    ConversationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversationType", x => x.ConversationTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_ConversationTypeId",
                table: "Conversation",
                column: "ConversationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_ConversationType_ConversationTypeId",
                table: "Conversation",
                column: "ConversationTypeId",
                principalTable: "ConversationType",
                principalColumn: "ConversationTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_ConversationType_ConversationTypeId",
                table: "Conversation");

            migrationBuilder.DropTable(
                name: "ConversationType");

            migrationBuilder.DropIndex(
                name: "IX_Conversation_ConversationTypeId",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "ConversationTypeId",
                table: "Conversation");
        }
    }
}
