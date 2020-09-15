using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class deliverydate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 232, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 232, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 232, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 218, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 230, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 39, 4, 231, DateTimeKind.Local).AddTicks(6694));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Orders");

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
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 970, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 18, 31, 11, 970, DateTimeKind.Local).AddTicks(8536));

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
    }
}
