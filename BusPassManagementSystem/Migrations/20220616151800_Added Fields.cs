using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusPassManagementSystem.Migrations
{
    public partial class AddedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "UserMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "UserMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserMasters",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "UserMasters");

            migrationBuilder.DropColumn(
                name: "DoB",
                table: "UserMasters");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserMasters");
        }
    }
}
