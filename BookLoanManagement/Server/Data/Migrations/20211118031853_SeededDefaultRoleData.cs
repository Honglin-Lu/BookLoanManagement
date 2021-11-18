using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLoanManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70f196db-a022-4f11-927c-6075a058ebd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1410b77-55e7-4075-ab0c-64bb5f9f9561");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 333, DateTimeKind.Local).AddTicks(4628), new DateTime(2021, 11, 17, 22, 3, 39, 335, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 335, DateTimeKind.Local).AddTicks(9656), new DateTime(2021, 11, 17, 22, 3, 39, 335, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4294), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4614), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4626), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4630), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(355), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(680), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(688) });
        }
    }
}
