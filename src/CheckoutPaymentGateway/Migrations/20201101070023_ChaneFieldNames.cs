using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckoutPaymentGateway.Migrations
{
    public partial class ChaneFieldNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "successUrl",
                table: "Payments",
                newName: "SuccessUrl");

            migrationBuilder.RenameColumn(
                name: "previousPaymentId",
                table: "Payments",
                newName: "PreviousPaymentId");

            migrationBuilder.RenameColumn(
                name: "merchantInitiated",
                table: "Payments",
                newName: "MerchantInitiated");

            migrationBuilder.RenameColumn(
                name: "failureUrl",
                table: "Payments",
                newName: "FailureUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessUrl",
                table: "Payments",
                newName: "successUrl");

            migrationBuilder.RenameColumn(
                name: "PreviousPaymentId",
                table: "Payments",
                newName: "previousPaymentId");

            migrationBuilder.RenameColumn(
                name: "MerchantInitiated",
                table: "Payments",
                newName: "merchantInitiated");

            migrationBuilder.RenameColumn(
                name: "FailureUrl",
                table: "Payments",
                newName: "failureUrl");
        }
    }
}
