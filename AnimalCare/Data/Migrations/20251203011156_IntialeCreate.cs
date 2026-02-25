using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialeCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-admin-id",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3d3c543-ee69-4157-b568-3983d25d1060", new DateTime(2025, 12, 3, 1, 11, 54, 558, DateTimeKind.Utc).AddTicks(9017), "AQAAAAIAAYagAAAAEEy2APl8Wu9Kg0rIvFsUuPTDmaRDyQSV2t8nsL5FgQ1eepmAHRgZYP9Fizn1maC4lg==", "958e6a95-3ade-4400-87c3-e05b04c5e5fe" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 11, 54, 650, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 11, 54, 650, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 11, 54, 650, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 11, 54, 650, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 11, 54, 650, DateTimeKind.Utc).AddTicks(6087));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-admin-id",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0436b4b8-117a-4654-91c1-94b4a83829b9", new DateTime(2025, 11, 30, 17, 34, 5, 292, DateTimeKind.Utc).AddTicks(6055), "AQAAAAIAAYagAAAAEGb+CRYEvJHNOCF2brANqyMZJU5/+A+40xhAReDH84vEQMQtrKxHhXT6IpryGMhZYA==", "4787ff16-fbc3-4140-83df-1a27f81a6b86" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 17, 34, 5, 348, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 17, 34, 5, 348, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 17, 34, 5, 348, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 17, 34, 5, 348, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 17, 34, 5, 348, DateTimeKind.Utc).AddTicks(8572));
        }
    }
}
