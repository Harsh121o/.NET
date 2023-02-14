using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiloMRM3.Migrations
{
    /// <inheritdoc />
    public partial class addedgupta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Left_ADD",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Left_Axis",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Left_CYL",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Left_SPH",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Left_VISION",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Mobile",
                table: "PizzaOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "PizzaOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Right_ADD",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Right_AXIS",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Right_CYL",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Right_SPH",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Right_VISION",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "PizzaOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Items",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Left_ADD",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Left_Axis",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Left_CYL",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Left_SPH",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Left_VISION",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Right_ADD",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Right_AXIS",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Right_CYL",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Right_SPH",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Right_VISION",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "PizzaOrders");
        }
    }
}
