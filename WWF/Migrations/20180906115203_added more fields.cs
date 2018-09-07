using Microsoft.EntityFrameworkCore.Migrations;

namespace WWF.Migrations
{
    public partial class addedmorefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine4",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "FormSubmissions",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "FormSubmissions",
                maxLength: 35,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "AddressLine4",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "County",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "FormSubmissions");

            migrationBuilder.DropColumn(
                name: "Town",
                table: "FormSubmissions");
        }
    }
}
