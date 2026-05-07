using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codePuls.API.Migrations
{
    /// <inheritdoc />
    public partial class initmigrationforapp0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "NewsCategoryId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NewsCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeaturedImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlHandle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NewsCategoryId",
                table: "Categories",
                column: "NewsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_NewsCategory_NewsCategoryId",
                table: "Categories",
                column: "NewsCategoryId",
                principalTable: "NewsCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_NewsCategory_NewsCategoryId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "NewsCategory");

            migrationBuilder.DropIndex(
                name: "IX_Categories_NewsCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "NewsCategoryId",
                table: "Categories");
        }
    }
}
