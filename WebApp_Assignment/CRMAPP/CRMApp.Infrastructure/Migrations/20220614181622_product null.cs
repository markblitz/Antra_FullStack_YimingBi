using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMApp.Infrastructure.Migrations
{
    public partial class productnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "UnitsOnOrder",
                table: "Product",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "UnitsInStock",
                table: "Product",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Product",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<short>(
                name: "ReorderLevel",
                table: "Product",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "QuantityPerUnit",
                table: "Product",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "UnitsOnOrder",
                table: "Product",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "UnitsInStock",
                table: "Product",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Product",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "ReorderLevel",
                table: "Product",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuantityPerUnit",
                table: "Product",
                type: "varchar(25)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);
        }
    }
}
