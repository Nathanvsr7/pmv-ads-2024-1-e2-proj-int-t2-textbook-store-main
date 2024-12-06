using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducaLivros.Migrations
{
    /// <inheritdoc />
    public partial class _07AddUserType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "usuarios");
        }
    }
}
