using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class measurmentsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.InsertData(
                table: "Measurments",
                columns: new[] { "Id", "CreatedAt", "UnitAr", "UnitEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(8225), "كيلوجرام", "Kilogram", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(8395), "جرام", "gram", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(8421), "كبير", "Large", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(8439), "متوسط", "Medium", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(8456), "صغير", "Small", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 19, 59, 15, 773, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 19, 59, 15, 776, DateTimeKind.Local).AddTicks(6288));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Measurments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 17, 21, 54, 462, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 17, 21, 54, 458, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 17, 21, 54, 462, DateTimeKind.Local).AddTicks(4926));
        }
    }
}
