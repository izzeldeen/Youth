using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class seedORder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "DeliveryInfo", "DeliveryLatitude", "DeliveryLongitude", "StatusId", "TotalPrice", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(2871), "Dahiet AlRashhed", 32f, 35f, 1, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 622, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 625, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "NameEn" },
                values: new object[] { new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(2296), "Rejected" });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "ItemPrice", "OrderId", "ProductId", "Quantity", "TotalPrice", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 9, 5, 14, 11, 18, 626, DateTimeKind.Local).AddTicks(4457), 2, 1, 4, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 249, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "NameEn" },
                values: new object[] { new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(3641), "Removed" });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 12, 9, 25, 253, DateTimeKind.Local).AddTicks(3659));
        }
    }
}
