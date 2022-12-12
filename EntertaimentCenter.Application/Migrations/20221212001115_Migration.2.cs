using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntertaimentCenter.Application.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "DateOfBirth", "DiscountCardId", "Email", "Name", "OrderId", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "john.smith@example.com", "John Smith", null, "555-555-5555" },
                    { 2, new DateTime(1995, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jane.doe@example.com", "Jane Doe", null, "555-555-5556" },
                    { 3, new DateTime(1985, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bob.johnson@example.com", "Bob Johnson", null, "555-555-5557" },
                    { 4, new DateTime(1980, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "alice.williams@example.com", "Alice Williams", null, "555-555-5558" }
                });

            migrationBuilder.InsertData(
                table: "CustomEvents",
                columns: new[] { "Id", "Description", "EndTime", "OrderId", "StartTime" },
                values: new object[,]
                {
                    { 1, "A musical performance by the city symphony orchestra", new DateTime(2022, 12, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "A stand-up comedy show featuring local comedians", new DateTime(2022, 12, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "A book reading and signing event with a bestselling author", new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "A movie screening of a classic film", new DateTime(2022, 12, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountCardId", "Value" },
                values: new object[,]
                {
                    { 1, null, 0.15m },
                    { 2, null, 0.2m },
                    { 3, null, 0.25m }
                });

            migrationBuilder.InsertData(
                table: "DiscountsCards",
                columns: new[] { "Id", "ClientId", "DiscountId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CustomEventId", "PlaceId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 2 },
                    { 3, 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "Capacity", "OrderId" },
                values: new object[,]
                {
                    { 1, 500, null },
                    { 2, 250, null },
                    { 3, 100, null },
                    { 4, 75, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CustomEvents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomEvents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomEvents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomEvents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiscountsCards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiscountsCards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiscountsCards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
