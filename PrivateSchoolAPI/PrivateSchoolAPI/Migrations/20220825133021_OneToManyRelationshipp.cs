using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrivateSchoolAPI.Migrations
{
    public partial class OneToManyRelationshipp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Stream = table.Column<string>(type: "TEXT", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EndDateTime", "Name", "StartDateTime", "Stream" },
                values: new object[] { 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Java", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CB16" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EndDateTime", "Name", "StartDateTime", "Stream" },
                values: new object[] { 2, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Csharp", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CB16" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EndDateTime", "Name", "StartDateTime", "Stream" },
                values: new object[] { 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javascript", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CB16" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EndDateTime", "Name", "StartDateTime", "Stream" },
                values: new object[] { 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "CB16" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 1, 24, 1, "Spyros", "Tomaras" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 2, 22, 1, "Agathi", "Tomaras" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 3, 60, 2, "Eleni", "Kallifoni" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 4, 65, 2, "Stathis", "Tomaras" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 5, 21, 3, "Apostolis", "Papanikolaoy" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 6, 27, 3, "Xristoforos", "Kallifonis" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 7, 39, 4, "Yiannis", "Karakasis" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "FirstName", "LastName" },
                values: new object[] { 8, 24, 4, "Xristos", "Kanoulas" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
