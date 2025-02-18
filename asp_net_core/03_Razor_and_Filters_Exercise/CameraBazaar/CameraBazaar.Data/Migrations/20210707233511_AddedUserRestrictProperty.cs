﻿namespace CameraBazaar.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedUserRestrictProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRestrict",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRestrict",
                table: "AspNetUsers");
        }
    }
}
