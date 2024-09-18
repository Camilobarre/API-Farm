using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_Farm.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedersAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "animals",
                columns: new[] { "id", "animal_type_id", "birth_date", "description", "name", "weight" },
                values: new object[,]
                {
                    { 1, 3, new DateOnly(2020, 3, 25), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Lucy", 438.62657639839387 },
                    { 2, 4, new DateOnly(2024, 9, 9), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Bonnie", 219.54965794091456 },
                    { 3, 5, new DateOnly(2020, 8, 31), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Iris", 420.51139919537428 },
                    { 4, 5, new DateOnly(2023, 1, 12), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Kristi", 0.83653782322055303 },
                    { 5, 1, new DateOnly(2020, 12, 29), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Adrian", 6.4142383345377114 },
                    { 6, 1, new DateOnly(2022, 1, 24), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Lynn", 308.56136261113556 },
                    { 7, 1, new DateOnly(2021, 10, 2), "The Football Is Good For Training And Recreational Purposes", "Florence", 74.364587261547882 },
                    { 8, 5, new DateOnly(2021, 9, 22), "The Football Is Good For Training And Recreational Purposes", "Felicia", 188.92464313107868 },
                    { 9, 3, new DateOnly(2024, 2, 3), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Angel", 287.44698976716546 },
                    { 10, 2, new DateOnly(2021, 7, 27), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Bridget", 452.34844486821532 },
                    { 11, 5, new DateOnly(2023, 11, 1), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Elena", 445.04361864688292 },
                    { 12, 1, new DateOnly(2023, 12, 17), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Cornelius", 362.92321205662529 },
                    { 13, 2, new DateOnly(2022, 4, 16), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Eric", 490.40205182859131 },
                    { 14, 3, new DateOnly(2022, 10, 8), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Harold", 58.376759228178244 },
                    { 15, 4, new DateOnly(2024, 7, 28), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Noel", 161.24928718487257 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "animals",
                keyColumn: "id",
                keyValue: 15);
        }
    }
}
