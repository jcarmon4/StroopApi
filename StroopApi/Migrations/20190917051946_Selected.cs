using Microsoft.EntityFrameworkCore.Migrations;

namespace StroopApi.Migrations
{
    public partial class Selected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Selected",
                table: "RecordActivities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Selected",
                table: "RecordActivities");
        }
    }
}
