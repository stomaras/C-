using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRSchool.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Java" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Python" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "C#" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Javascript" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 1, 1, "Spyros", "Tomaras" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 2, 1, "Agathi", "Tomara" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 3, 2, "Apostolis", "Papanikoaloy" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 4, 2, "Xristoforos", "Kallifonis" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 5, 3, "Yiannis", "Karakasis" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 6, 3, "Ntinos", "Nikos" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 7, 4, "Natalia", "Zachanekpliroto" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CourseId", "FirstName", "LastName" },
                values: new object[] { 8, 4, "Konstantina", "Nikolatoy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
