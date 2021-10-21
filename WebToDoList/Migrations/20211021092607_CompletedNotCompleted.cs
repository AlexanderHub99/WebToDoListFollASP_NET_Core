using Microsoft.EntityFrameworkCore.Migrations;

namespace WebToDoList.Migrations
{
    public partial class CompletedNotCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CompletedNotCompleted",
                table: "ToDoList",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedNotCompleted",
                table: "ToDoList");
        }
    }
}
