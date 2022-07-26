using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Class.Migrations
{
    public partial class newq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Questions",
                table: "Questions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
