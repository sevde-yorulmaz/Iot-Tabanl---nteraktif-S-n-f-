using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Class.Migrations
{
    public partial class question : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "Questions");
        }
    }
}
