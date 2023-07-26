using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EagerLoading.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTag");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CourseId",
                table: "Tags",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Courses_CourseId",
                table: "Tags",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Courses_CourseId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CourseId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "CourseTag",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTag", x => new { x.CoursesId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_CourseTag_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTag_TagsId",
                table: "CourseTag",
                column: "TagsId");
        }
    }
}
