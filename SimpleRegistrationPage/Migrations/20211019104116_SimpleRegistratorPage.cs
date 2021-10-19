using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleRegistrationPage.Migrations
{
    public partial class SimpleRegistratorPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(100)", nullable: false),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(1000)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    phone = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AccountsFrontEnd");
        }
    }
}
