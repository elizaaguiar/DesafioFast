using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DesafioFullstack.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationshipsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Collaborator",
                columns: new[] { "Id", "CreatedAt", "Guid", "Name", "RemovedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abfd1"), "Colaborador 2", null, null },
                    { 3, new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abfd2"), "Colaborador 3", null, null },
                    { 4, new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abfd3"), "Colaborador 4", null, null }
                });

            migrationBuilder.InsertData(
                table: "Workshop",
                columns: new[] { "Id", "CreatedAt", "Description", "ExecutionDate", "Guid", "Name", "RemovedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descubra o potencial da IA. Neste evento, vamos explorar algoritmos de machine learning e criar um modelo preditivo do zero, sem necessidade de conhecimento prévio.", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abcf1"), "Workshop de Inteligência Artificial", null, null },
                    { 3, new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aprenda a construir APIs robustas e escaláveis. Abordaremos desde os conceitos fundamentais de REST até a implementação de segurança com JWT e documentação com Swagger.", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abcf2"), "APIs RESTful com .NET", null, null },
                    { 4, new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Focado em UI/UX, este workshop ensina a criar interfaces intuitivas e atraentes. Você aprenderá sobre prototipação, sistemas de design e testes de usabilidade.", new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3f1a2b4-5c6d-7e8f-9012-3456789abcf3"), "Design de Interfaces Modernas", null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "CollaboratorId", "WorkshopId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Attendance",
                keyColumns: new[] { "CollaboratorId", "WorkshopId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workshop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workshop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workshop",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Collaborator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
