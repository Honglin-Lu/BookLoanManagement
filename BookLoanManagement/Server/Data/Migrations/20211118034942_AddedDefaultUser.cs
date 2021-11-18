using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLoanManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70f196db-a022-4f11-927c-6075a058ebd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1410b77-55e7-4075-ab0c-64bb5f9f9561");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b5e17ab-be0a-4383-85dc-f7f094b10268", "c408f7c2-c5a8-490f-b455-a1785c061f05", "User", "USER" },
                    { "b119ac9e-b56b-4047-a385-27a12f71ecef", "b2e08ed5-eebf-49c8-ba9e-bf89f8aab5b9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 94, DateTimeKind.Local).AddTicks(4515), new DateTime(2021, 11, 17, 22, 49, 42, 97, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 97, DateTimeKind.Local).AddTicks(6755), new DateTime(2021, 11, 17, 22, 49, 42, 97, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(7773), new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(8223), new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(8238), new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(8243), new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(2149), new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(2799), new DateTime(2021, 11, 17, 22, 49, 42, 99, DateTimeKind.Local).AddTicks(2814) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b5e17ab-be0a-4383-85dc-f7f094b10268");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b119ac9e-b56b-4047-a385-27a12f71ecef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70f196db-a022-4f11-927c-6075a058ebd4", "a485e425-7ed9-4f06-ae67-bc8118c8ae4f", "User", "USER" },
                    { "b1410b77-55e7-4075-ab0c-64bb5f9f9561", "20b12446-6200-414c-8d99-4837f06700d7", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 588, DateTimeKind.Local).AddTicks(5979), new DateTime(2021, 11, 17, 22, 18, 52, 591, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 591, DateTimeKind.Local).AddTicks(4859), new DateTime(2021, 11, 17, 22, 18, 52, 591, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(120), new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(450), new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(462), new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(466), new DateTime(2021, 11, 17, 22, 18, 52, 593, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 592, DateTimeKind.Local).AddTicks(6614), new DateTime(2021, 11, 17, 22, 18, 52, 592, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 18, 52, 592, DateTimeKind.Local).AddTicks(6960), new DateTime(2021, 11, 17, 22, 18, 52, 592, DateTimeKind.Local).AddTicks(6969) });
        }
    }
}
