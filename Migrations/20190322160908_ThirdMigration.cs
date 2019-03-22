using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Activity",
                newName: "DurationStr");

            migrationBuilder.AddColumn<int>(
                name: "DurationNum",
                table: "Activity",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationNum",
                table: "Activity");

            migrationBuilder.RenameColumn(
                name: "DurationStr",
                table: "Activity",
                newName: "Duration");
        }
    }
}
