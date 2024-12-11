using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodMenuWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "https://i0.wp.com/daddioskitchen.com/wp-content/uploads/2023/01/IMG-5299.jpg?fit=3024%2C3024&ssl=1", "Pepperoni", 8.5 },
                    { 3, "https://cdn.loveandlemons.com/wp-content/uploads/2023/02/vegetarian-pizza.jpg", "Vegetarian", 9.0 }
                });

            migrationBuilder.InsertData(
                table: "Ingradients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Pepperoni" },
                    { 4, "Paprika" },
                    { 5, "Mushroom" }
                });

            migrationBuilder.InsertData(
                table: "DishIngradients",
                columns: new[] { "DishId", "IngradientId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DishIngradients",
                keyColumns: new[] { "DishId", "IngradientId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DishIngradients",
                keyColumns: new[] { "DishId", "IngradientId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DishIngradients",
                keyColumns: new[] { "DishId", "IngradientId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DishIngradients",
                keyColumns: new[] { "DishId", "IngradientId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "DishIngradients",
                keyColumns: new[] { "DishId", "IngradientId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingradients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingradients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingradients",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
