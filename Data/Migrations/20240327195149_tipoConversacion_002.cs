using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euneo.Data.Migrations
{
    /// <inheritdoc />
    public partial class tipoConversacion_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_ConversationType_ConversationTypeId",
                table: "Conversation");

            migrationBuilder.AlterColumn<int>(
                name: "ConversationTypeId",
                table: "Conversation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_ConversationType_ConversationTypeId",
                table: "Conversation",
                column: "ConversationTypeId",
                principalTable: "ConversationType",
                principalColumn: "ConversationTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_ConversationType_ConversationTypeId",
                table: "Conversation");

            migrationBuilder.AlterColumn<int>(
                name: "ConversationTypeId",
                table: "Conversation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_ConversationType_ConversationTypeId",
                table: "Conversation",
                column: "ConversationTypeId",
                principalTable: "ConversationType",
                principalColumn: "ConversationTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
