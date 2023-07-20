using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalCMS_API.Migrations
{
    /// <inheritdoc />
    public partial class PopulatePatientsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Patients");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Patients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "Patients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "Ethnicity", "FirstName", "Height", "Language", "LastName", "LegalSex", "MaritalStatus", "Race", "RegisterDate", "Weight" },
                values: new object[,]
                {
                    { 1, 55, "Caribbean", "Trinidad", 5.1m, "English", "Franklin", "Female", "Married", "African American", new DateTime(2023, 7, 19, 23, 3, 17, 975, DateTimeKind.Local).AddTicks(6184), 210.5m },
                    { 2, 23, "American", "Ashley", 5.5m, "English", "Castaneda", "Female", "Single", "Hispanic", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5460), 131.8m },
                    { 3, 32, "Irish", "Josh", 5.7m, "English", "McGlade", "Male", "Married", "European American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5476), 248.8m },
                    { 4, 68, "American", "Shanon", 5.6m, "English", "Anderson", "Female", "Divorced", "White American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5480), 109.3m },
                    { 5, 51, "American", "Wilson", 5.11m, "English", "Li", "Male", "Married", "Asian American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5483), 139.2m },
                    { 6, 39, "South American", "Miguel", 5.9m, "Spanish", "Pena", "Male", "Divorced", "Hispanic", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5491), 197.3m },
                    { 7, 47, "American", "Robert", 5.8m, "English", "Bush", "Male", "Divorced", "European American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5494), 233.2m },
                    { 8, 39, "Norwegian", "Michelle", 5.6m, "English", "Hagen", "Female", "Single", "European American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5497), 210.3m },
                    { 9, 55, "Scottish", "Norris", 6.0m, "English", "McKenney", "Male", "Divorced", "European American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5500), 173.8m },
                    { 10, 62, "American", "Krista", 5.3m, "English", "Thomas", "Female", "Married", "Native American", new DateTime(2023, 7, 19, 23, 3, 17, 986, DateTimeKind.Local).AddTicks(5504), 190.5m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Patients",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Patients",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
