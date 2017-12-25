using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PetsVet.Migrations
{
    public partial class addAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Animals");

            migrationBuilder.AddColumn<string>(
                name: "Kind",
                table: "Animals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Animals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kind",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "Animals");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Animals",
                maxLength: 200,
                nullable: true);
        }
    }
}
