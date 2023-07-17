using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityCore.Migrations
{
    /// <inheritdoc />
    public partial class six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "navchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "navchar(100)");

            migrationBuilder.CreateTable(
                name: "balances",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _CashBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _BankBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _MoneyGoingIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _MoneyPaidOut = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balances", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _ExportDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "donations",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _Fees = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _Intention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _ExportDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donations", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _Countries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _EstimatedTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    _ManagedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _TeamsOnTheGround = table.Column<int>(type: "int", nullable: false),
                    _ProjectInitiated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _ProjectCompleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    _Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x._id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "balances");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "donations");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "navchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "navchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
