using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckoutPaymentGateway.Migrations
{
    public partial class riskfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RiskId",
                table: "Payments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RiskId",
                table: "Payments");
        }
    }
}
