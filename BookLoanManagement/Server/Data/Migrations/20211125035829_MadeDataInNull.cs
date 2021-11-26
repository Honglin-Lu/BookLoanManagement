using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLoanManagement.Server.Data.Migrations
{
    public partial class MadeDataInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b5e17ab-be0a-4383-85dc-f7f094b10268");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b119ac9e-b56b-4047-a385-27a12f71ecef");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Customers",
                newName: "Email");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Loans",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "266a63e5-f115-4785-b043-25d2e789dfee", "4991e597-4de2-4458-adc1-8314ebdf111e", "User", "USER" },
                    { "5b2b1675-a431-40bf-a758-15130bf926a6", "c99c8b2e-9786-4996-a4f1-9d97ebe54103", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 64, DateTimeKind.Local).AddTicks(2371), new DateTime(2021, 11, 24, 22, 58, 29, 66, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 66, DateTimeKind.Local).AddTicks(7588), new DateTime(2021, 11, 24, 22, 58, 29, 66, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2298), new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2627), new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2642), new DateTime(2021, 11, 24, 22, 58, 29, 68, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 67, DateTimeKind.Local).AddTicks(8803), new DateTime(2021, 11, 24, 22, 58, 29, 67, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 22, 58, 29, 67, DateTimeKind.Local).AddTicks(9145), new DateTime(2021, 11, 24, 22, 58, 29, 67, DateTimeKind.Local).AddTicks(9154) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266a63e5-f115-4785-b043-25d2e789dfee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b2b1675-a431-40bf-a758-15130bf926a6");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "email");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
