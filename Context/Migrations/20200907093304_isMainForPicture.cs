using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class isMainForPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "ProductPictures",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 821, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 816, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 12, 33, 3, 820, DateTimeKind.Local).AddTicks(4755));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "ProductPictures");

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
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 23, 4, 36, 955, DateTimeKind.Local).AddTicks(3766));

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
        }
    }
}
