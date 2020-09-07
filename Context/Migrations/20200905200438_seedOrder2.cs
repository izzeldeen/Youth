using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class seedOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "DeliveryInfo", "DeliveryLatitude", "DeliveryLongitude", "StatusId", "TotalPrice", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(3766), "Dahiet AlRashhed", 32f, 35f, 1, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 944, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 954, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "ItemPrice", "OrderId", "ProductId", "Quantity", "TotalPrice", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(3884), 2, 2, 5, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 655, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 655, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 645, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 653, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 22, 55, 36, 654, DateTimeKind.Local).AddTicks(8375));
        }
    }
}
