using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioFullstack.Migrations
{
    /// <inheritdoc />
    public partial class CreateFirstWorshopAndCollaborator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Workshop",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedAt",
                table: "Workshop",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Collaborator",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedAt",
                table: "Collaborator",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.InsertData(
                table: "Collaborator",
                columns: new[] { "Id", "CreatedAt", "Guid", "Name", "RemovedAt", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abfde"), "Colaborador 1", null, null });

            migrationBuilder.InsertData(
                table: "Workshop",
                columns: new[] { "Id", "CreatedAt", "Description", "ExecutionDate", "Guid", "Name", "RemovedAt", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participe deste workshop prático e intensivo sobre tecnologia e aprenda com o especialista a dominar as técnicas e ferramentas essenciais para aplicar o conhecimento imediatamente.", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abcde"), "Workshop 1", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workshop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Workshop",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedAt",
                table: "Workshop",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Collaborator",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedAt",
                table: "Collaborator",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);
        }
    }
}
