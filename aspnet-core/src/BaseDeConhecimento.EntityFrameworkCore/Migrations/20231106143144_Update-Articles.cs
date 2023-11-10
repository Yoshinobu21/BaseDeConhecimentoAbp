using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDeConhecimento.Migrations
{
    /// <inheritdoc />
    public partial class UpdateArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "favorited",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Articles");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorited",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Articles",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsFavorited",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "createdAt",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "favorited",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "updatedAt",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
