using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebMVC.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class Create_Table_Cat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DogCode",
                table: "Animal",
                newName: "DogID");

            migrationBuilder.AddColumn<string>(
                name: "CatCategory",
                table: "Animal",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CatID",
                table: "Animal",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogCategory",
                table: "Animal",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatCategory",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "CatID",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "DogCategory",
                table: "Animal");

            migrationBuilder.RenameColumn(
                name: "DogID",
                table: "Animal",
                newName: "DogCode");
        }
    }
}
