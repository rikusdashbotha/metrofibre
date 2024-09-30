using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MetroFibre.Data.Migrations
{
    /// <inheritdoc />
    public partial class add_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00000000-da7a-0000-0000-000000000000"), "Meat", 6 },
                    { new Guid("00000000-da7a-0000-0000-000000000001"), "Lettuce", 3 },
                    { new Guid("00000000-da7a-0000-0000-000000000002"), "Tomato", 6 },
                    { new Guid("00000000-da7a-0000-0000-000000000003"), "Cheese", 8 },
                    { new Guid("00000000-da7a-0000-0000-000000000004"), "Dough", 10 },
                    { new Guid("00000000-da7a-0000-0000-000000000005"), "Cucumber", 2 },
                    { new Guid("00000000-da7a-0000-0000-000000000006"), "Olives", 2 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Feeds", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-da7a-0000-0000-000000001000"), 1, "Burger" },
                    { new Guid("00000000-da7a-0000-0000-000000001001"), 2, "Pasta" },
                    { new Guid("00000000-da7a-0000-0000-000000001002"), 6, "Tomato" },
                    { new Guid("00000000-da7a-0000-0000-000000001003"), 1, "Pie" },
                    { new Guid("00000000-da7a-0000-0000-000000001004"), 3, "Salad" },
                    { new Guid("00000000-da7a-0000-0000-000000001005"), 1, "Sandwich" },
                    { new Guid("00000000-da7a-0000-0000-000000001006"), 4, "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "RecipeId", "RequiredAmount" },
                values: new object[,]
                {
                    { new Guid("00000000-da7a-0000-0000-000000002000"), new Guid("00000000-da7a-0000-0000-000000000000"), new Guid("00000000-da7a-0000-0000-000000001000"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002001"), new Guid("00000000-da7a-0000-0000-000000000001"), new Guid("00000000-da7a-0000-0000-000000001000"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002002"), new Guid("00000000-da7a-0000-0000-000000000002"), new Guid("00000000-da7a-0000-0000-000000001000"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002003"), new Guid("00000000-da7a-0000-0000-000000000003"), new Guid("00000000-da7a-0000-0000-000000001000"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002004"), new Guid("00000000-da7a-0000-0000-000000000004"), new Guid("00000000-da7a-0000-0000-000000001000"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002005"), new Guid("00000000-da7a-0000-0000-000000000004"), new Guid("00000000-da7a-0000-0000-000000001001"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002006"), new Guid("00000000-da7a-0000-0000-000000000002"), new Guid("00000000-da7a-0000-0000-000000001001"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002007"), new Guid("00000000-da7a-0000-0000-000000000003"), new Guid("00000000-da7a-0000-0000-000000001001"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002008"), new Guid("00000000-da7a-0000-0000-000000000000"), new Guid("00000000-da7a-0000-0000-000000001001"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002009"), new Guid("00000000-da7a-0000-0000-000000000004"), new Guid("00000000-da7a-0000-0000-000000001003"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002010"), new Guid("00000000-da7a-0000-0000-000000000000"), new Guid("00000000-da7a-0000-0000-000000001003"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002011"), new Guid("00000000-da7a-0000-0000-000000000001"), new Guid("00000000-da7a-0000-0000-000000001004"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002012"), new Guid("00000000-da7a-0000-0000-000000000002"), new Guid("00000000-da7a-0000-0000-000000001004"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002013"), new Guid("00000000-da7a-0000-0000-000000000005"), new Guid("00000000-da7a-0000-0000-000000001004"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002014"), new Guid("00000000-da7a-0000-0000-000000000003"), new Guid("00000000-da7a-0000-0000-000000001004"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002015"), new Guid("00000000-da7a-0000-0000-000000000006"), new Guid("00000000-da7a-0000-0000-000000001004"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002016"), new Guid("00000000-da7a-0000-0000-000000000004"), new Guid("00000000-da7a-0000-0000-000000001005"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002017"), new Guid("00000000-da7a-0000-0000-000000000005"), new Guid("00000000-da7a-0000-0000-000000001005"), 1 },
                    { new Guid("00000000-da7a-0000-0000-000000002018"), new Guid("00000000-da7a-0000-0000-000000000004"), new Guid("00000000-da7a-0000-0000-000000001006"), 3 },
                    { new Guid("00000000-da7a-0000-0000-000000002019"), new Guid("00000000-da7a-0000-0000-000000000002"), new Guid("00000000-da7a-0000-0000-000000001006"), 2 },
                    { new Guid("00000000-da7a-0000-0000-000000002020"), new Guid("00000000-da7a-0000-0000-000000000003"), new Guid("00000000-da7a-0000-0000-000000001006"), 3 },
                    { new Guid("00000000-da7a-0000-0000-000000002021"), new Guid("00000000-da7a-0000-0000-000000000006"), new Guid("00000000-da7a-0000-0000-000000001006"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002000"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002001"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002002"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002003"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002004"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002005"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002006"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002007"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002008"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002009"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002010"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002011"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002012"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002013"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002014"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002015"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002016"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002017"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002018"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002019"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002020"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000002021"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001002"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000000"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001000"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001001"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001003"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001004"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001005"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-da7a-0000-0000-000000001006"));
        }
    }
}
