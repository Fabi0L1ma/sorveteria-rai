using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sorveteria_rai.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusCategoria",
                table: "Categoria",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusCategoria",
                table: "Categoria");
        }
    }
}
