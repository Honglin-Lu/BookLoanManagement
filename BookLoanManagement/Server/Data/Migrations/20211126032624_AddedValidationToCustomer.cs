using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLoanManagement.Server.Data.Migrations
{
    public partial class AddedValidationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266a63e5-f115-4785-b043-25d2e789dfee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b2b1675-a431-40bf-a758-15130bf926a6");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84757fcf-8772-4e92-a745-dbbd7ddfd4ff", "e017c227-b8fc-4b0b-9ff3-9fd4880ed89d", "User", "USER" },
                    { "1fcdb003-c783-43b1-86b8-78b6a55dd5f5", "eabca4e0-8830-400e-b522-ca531e46c871", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 123, DateTimeKind.Local).AddTicks(900), new DateTime(2021, 11, 25, 22, 26, 24, 125, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 125, DateTimeKind.Local).AddTicks(4071), new DateTime(2021, 11, 25, 22, 26, 24, 125, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(8821), new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(9233), new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(9246), new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(9251), new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(5356), new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(5694), new DateTime(2021, 11, 25, 22, 26, 24, 126, DateTimeKind.Local).AddTicks(5703) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fcdb003-c783-43b1-86b8-78b6a55dd5f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84757fcf-8772-4e92-a745-dbbd7ddfd4ff");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
