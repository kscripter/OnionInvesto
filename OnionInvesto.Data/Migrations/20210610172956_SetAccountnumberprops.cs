using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionInvesto.Data.Migrations
{
    public partial class SetAccountnumberprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "BankDetails",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountName",
                table: "BankDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_AccountNumber",
                table: "BankDetails",
                column: "AccountNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BankDetails_AccountNumber",
                table: "BankDetails");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "BankDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "AccountName",
                table: "BankDetails",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
