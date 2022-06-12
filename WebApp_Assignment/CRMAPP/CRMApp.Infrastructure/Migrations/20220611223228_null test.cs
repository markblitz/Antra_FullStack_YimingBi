﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMApp.Infrastructure.Migrations
{
    public partial class nulltest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "ntext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);
        }
    }
}
