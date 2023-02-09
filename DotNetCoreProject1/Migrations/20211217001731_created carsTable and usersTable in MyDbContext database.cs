using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreProject1.Migrations
{
    public partial class createdcarsTableandusersTableinMyDbContextdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "carsTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 12, 16, 16, 17, 30, 613, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "carsTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 12, 16, 16, 17, 30, 642, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "usersTable",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 16, 16, 17, 30, 644, DateTimeKind.Local).AddTicks(8450), new DateTime(2021, 12, 16, 16, 17, 30, 644, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "usersTable",
                keyColumn: "RegisterId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 16, 16, 17, 30, 645, DateTimeKind.Local).AddTicks(3950), new DateTime(2021, 12, 16, 16, 17, 30, 645, DateTimeKind.Local).AddTicks(3990) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "carsTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 12, 16, 16, 10, 59, 538, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "carsTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 12, 16, 16, 10, 59, 562, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "usersTable",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 16, 16, 10, 59, 563, DateTimeKind.Local).AddTicks(9400), new DateTime(2021, 12, 16, 16, 10, 59, 563, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "usersTable",
                keyColumn: "RegisterId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 16, 16, 10, 59, 564, DateTimeKind.Local).AddTicks(4060), new DateTime(2021, 12, 16, 16, 10, 59, 564, DateTimeKind.Local).AddTicks(4080) });
        }
    }
}
