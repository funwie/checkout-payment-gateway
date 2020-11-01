using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckoutPaymentGateway.Migrations
{
    public partial class AddPaymentFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "failureUrl",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "merchantInitiated",
                table: "Payments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "previousPaymentId",
                table: "Payments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "successUrl",
                table: "Payments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "failureUrl",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "merchantInitiated",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "previousPaymentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "successUrl",
                table: "Payments");
        }
    }
}
