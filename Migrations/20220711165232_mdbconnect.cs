using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupServer.Migrations
{
    public partial class mdbconnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false),
                    admin_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    securityQ1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Medicine_ID = table.Column<int>(type: "int", nullable: false),
                    Medicine_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MF_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXP_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price_Rs = table.Column<int>(type: "int", nullable: false),
                    Category_Of_Medicine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Medicine_ID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_No = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confirm_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
