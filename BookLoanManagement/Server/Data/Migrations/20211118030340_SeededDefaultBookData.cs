using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLoanManagement.Server.Data.Migrations
{
    public partial class SeededDefaultBookData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 17, 22, 3, 39, 333, DateTimeKind.Local).AddTicks(4628), new DateTime(2021, 11, 17, 22, 3, 39, 335, DateTimeKind.Local).AddTicks(8706), "Anna", "System" },
                    { 2, "System", new DateTime(2021, 11, 17, 22, 3, 39, 335, DateTimeKind.Local).AddTicks(9656), new DateTime(2021, 11, 17, 22, 3, 39, 335, DateTimeKind.Local).AddTicks(9668), "Mark", "System" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4294), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4307), "Romance", "System" },
                    { 2, "System", new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4614), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4623), "Historical", "System" },
                    { 3, "System", new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4626), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4628), "Dictionary", "System" },
                    { 4, "System", new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4630), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(4633), "Science", "System" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(355), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(371), "BYM", "System" },
                    { 2, "System", new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(680), new DateTime(2021, 11, 17, 22, 3, 39, 337, DateTimeKind.Local).AddTicks(688), "SXS", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
