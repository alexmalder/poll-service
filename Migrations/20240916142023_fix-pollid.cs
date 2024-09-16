using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetCrudWebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixpollid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollInstances_Polls_PollId",
                table: "PollInstances");

            migrationBuilder.AlterColumn<long>(
                name: "PollId",
                table: "PollInstances",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_PollInstances_Polls_PollId",
                table: "PollInstances",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollInstances_Polls_PollId",
                table: "PollInstances");

            migrationBuilder.AlterColumn<long>(
                name: "PollId",
                table: "PollInstances",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PollInstances_Polls_PollId",
                table: "PollInstances",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
