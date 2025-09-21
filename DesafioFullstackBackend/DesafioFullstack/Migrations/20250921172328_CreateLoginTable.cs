using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioFullstack.Migrations
{
    /// <inheritdoc />
    public partial class CreateLoginTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Collaborator",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "xAPNjP>$gsO,myR{");

            migrationBuilder.UpdateData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "7?{+Z5tge(^(x4=h");

            migrationBuilder.UpdateData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "3*M1/P^H$E1FsIUN");

            migrationBuilder.UpdateData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "s&W:mdI*}tV7f{]6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Collaborator");
        }
    }
}
