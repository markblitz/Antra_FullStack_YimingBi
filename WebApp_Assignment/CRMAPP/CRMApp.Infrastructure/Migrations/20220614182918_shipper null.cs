using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMApp.Infrastructure.Migrations
{
    public partial class shippernull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shipper",
                type: "varchar(24)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(24)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shipper",
                type: "varchar(24)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldNullable: true);
        }
    }
}
