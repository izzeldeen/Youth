using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 492, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 16, 24, 23, 496, DateTimeKind.Local).AddTicks(5559));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 390, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 10, 27, 9, 394, DateTimeKind.Local).AddTicks(3202));
        }
    }
}
