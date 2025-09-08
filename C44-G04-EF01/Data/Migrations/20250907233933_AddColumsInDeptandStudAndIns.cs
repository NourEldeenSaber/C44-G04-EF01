using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C44_G04_EF01.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColumsInDeptandStudAndIns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Courses");
        }
    }
}
