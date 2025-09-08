using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C44_G04_EF01.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseInstructorAndStudentCourseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsCourse",
                columns: table => new
                {
                    InstId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    evalution = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsCourse", x => x.InstId);
                });

            migrationBuilder.CreateTable(
                name: "StudCourse",
                columns: table => new
                {
                    StudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudCourse", x => x.StudId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsCourse");

            migrationBuilder.DropTable(
                name: "StudCourse");
        }
    }
}
