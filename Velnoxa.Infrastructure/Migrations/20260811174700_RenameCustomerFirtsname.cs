using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Velnoxa.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameCustomerFirtsname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Companies_companyId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "Customers",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fristname",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_companyId",
                table: "Customers",
                newName: "IX_Customers_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Companies_CompanyId",
                table: "Customers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Companies_CompanyId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Customers",
                newName: "companyId");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "fristname");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_CompanyId",
                table: "Customers",
                newName: "IX_Customers_companyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Companies_companyId",
                table: "Customers",
                column: "companyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
