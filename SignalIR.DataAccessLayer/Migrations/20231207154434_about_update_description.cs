using Microsoft.EntityFrameworkCore.Migrations;

namespace SignaIR.DataAccessLayer.Migrations
{
    public partial class about_update_description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "Abouts");
        }
    }
}
