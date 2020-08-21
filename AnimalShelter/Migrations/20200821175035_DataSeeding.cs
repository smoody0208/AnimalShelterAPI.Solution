using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "ShelterId", "Location" },
                values: new object[] { 1, "Four Paws Rescue" });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "ShelterId", "Location" },
                values: new object[] { 2, "Meowin Rescue" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "DateRescued", "Description", "Gender", "Name", "ShelterId", "Species" },
                values: new object[] { 1, 4, "German Shepard", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Well behaved and playful!", "Male", "Leo", 1, "Dog" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "DateRescued", "Description", "Gender", "Name", "ShelterId", "Species" },
                values: new object[] { 2, 2, "N/A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometimes grumpy, but usually friendly", "Female", "Kitty", 1, "Cat" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "DateRescued", "Description", "Gender", "Name", "ShelterId", "Species" },
                values: new object[] { 3, 20, "Parrot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Likes to talk and yell", "Female", "Birdy", 2, "Bird" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 2);
        }
    }
}
