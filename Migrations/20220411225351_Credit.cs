using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Goose_Panda_love_Coffee.Migrations
{
    public partial class Credit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Credit",
                table: "Student",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Student");
        }
    }
}
