using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("7b7e52a3-9362-4631-8c01-d8577a0d7f62"), "Фрукты" },
                    { new Guid("dbd53a84-3706-4b89-a135-da888aa024a7"), "Овощи" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("7b7e52a3-9362-4631-8c01-d8577a0d7f62"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("dbd53a84-3706-4b89-a135-da888aa024a7"));
        }
    }
}
