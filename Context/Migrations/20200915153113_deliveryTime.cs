using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class deliveryTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 970, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 970, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 9, 15, 18, 31, 11, 970, DateTimeKind.Local).AddTicks(262), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 9, 15, 18, 31, 11, 970, DateTimeKind.Local).AddTicks(8536), 1 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 956, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 968, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 969, DateTimeKind.Local).AddTicks(8083));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(2092), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(7839), 2 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 963, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 971, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 29, 37, 972, DateTimeKind.Local).AddTicks(1046));
        }
    }
}
