using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sale_Street.Migrations
{
    public partial class image_arr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "byte[]",
                table: "Image",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "byte[]",
                table: "Image");
        }
    }
}
