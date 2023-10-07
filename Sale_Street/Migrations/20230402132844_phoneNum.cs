using Microsoft.EntityFrameworkCore.Migrations;

namespace Sale_Street.Migrations
{
    public partial class phoneNum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "AspNetUsers",
                newName: "phoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "AspNetUsers",
                newName: "PhoneNumber");
        }
    }
}
