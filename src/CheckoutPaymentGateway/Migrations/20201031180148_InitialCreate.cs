using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckoutPaymentGateway.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Owner = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: false),
                    ExpiryMonth = table.Column<string>(nullable: true),
                    ExpiryYear = table.Column<string>(nullable: true),
                    Last4 = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<string>(nullable: true),
                    Fingerprint = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CvvCheck = table.Column<string>(nullable: true),
                    AvsCheck = table.Column<string>(nullable: true),
                    SourceType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    Bank = table.Column<string>(nullable: true),
                    PublickKey = table.Column<string>(nullable: true),
                    SecretKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RequestedOn = table.Column<DateTimeOffset>(nullable: false),
                    Amount = table.Column<long>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    PaymentIp = table.Column<string>(nullable: true),
                    SourceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phonns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CountryCode = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Owner = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phonns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Flagged = table.Column<bool>(nullable: true),
                    FlaggedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThreeDSEnrollments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Downgraded = table.Column<bool>(nullable: true),
                    Enrolled = table.Column<string>(nullable: true),
                    SignatureValid = table.Column<string>(nullable: true),
                    AuthenticationResponse = table.Column<string>(nullable: true),
                    Cryptogram = table.Column<string>(nullable: true),
                    Xid = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    PaymentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreeDSEnrollments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Phonns");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "ThreeDSEnrollments");
        }
    }
}
