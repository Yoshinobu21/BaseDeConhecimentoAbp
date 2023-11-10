using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDeConhecimento.Migrations
{
    /// <inheritdoc />
    public partial class UpdateArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "body",
                table: "Articles",
                newName: "Body");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Articles",
                newName: "body");
        }
    }
}
