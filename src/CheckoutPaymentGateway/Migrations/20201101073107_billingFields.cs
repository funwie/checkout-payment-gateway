using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckoutPaymentGateway.Migrations
{
    public partial class billingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "billing_city",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "billing_name",
                table: "Payments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "billing_city",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "billing_name",
                table: "Payments");
        }
    }
}
