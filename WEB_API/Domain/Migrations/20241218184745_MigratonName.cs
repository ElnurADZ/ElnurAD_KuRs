using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class MigratonName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADS",
                columns: table => new
                {
                    ID_ADS = table.Column<int>(type: "int", nullable: false),
                    Type_ADS = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier50", x => x.ID_ADS);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID_Clients = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Phone_number = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    blocked = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier2", x => x.ID_Clients);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID_Departament = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Adress = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Employe_count = table.Column<int>(type: "int", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier1", x => x.ID_Departament);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    ID_Partners = table.Column<int>(type: "int", nullable: false),
                    Name_Company = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Phone_number = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Company_activity = table.Column<string>(type: "char(1000)", unicode: false, fixedLength: true, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.ID_Partners);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    ID_Feedback = table.Column<int>(type: "int", nullable: false),
                    ID_Clients = table.Column<int>(type: "int", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Text = table.Column<string>(type: "char(1000)", unicode: false, fixedLength: true, maxLength: 1000, nullable: false),
                    Recommendation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier5", x => x.ID_Feedback);
                    table.ForeignKey(
                        name: "Relationship98",
                        column: x => x.ID_Clients,
                        principalTable: "Clients",
                        principalColumn: "ID_Clients");
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    ID_Office = table.Column<int>(type: "int", nullable: false),
                    ID_Departament = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Employe_count = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Adress = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier3", x => x.ID_Office);
                    table.ForeignKey(
                        name: "Relationship99",
                        column: x => x.ID_Departament,
                        principalTable: "Department",
                        principalColumn: "ID_Departament");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID_Emloyee = table.Column<int>(type: "int", nullable: false),
                    ID_Office = table.Column<int>(type: "int", nullable: false),
                    Post = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    FIO = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    Phone_number = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier4", x => x.ID_Emloyee);
                    table.ForeignKey(
                        name: "Relationship33",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                });

            migrationBuilder.CreateTable(
                name: "Method_connection",
                columns: table => new
                {
                    ID_Office = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Phone_number = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    VK = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    Instagram = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    Facebook = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier87", x => x.ID_Office);
                    table.ForeignKey(
                        name: "Relationship87",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                });

            migrationBuilder.CreateTable(
                name: "Office_ADS",
                columns: table => new
                {
                    ID_ADS_Office = table.Column<int>(type: "int", nullable: false),
                    ID_Office = table.Column<int>(type: "int", nullable: false),
                    ID_ADS = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Adress = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: false),
                    ADS_Coordinates = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier76", x => x.ID_ADS_Office);
                    table.ForeignKey(
                        name: "Relationship74",
                        column: x => x.ID_ADS,
                        principalTable: "ADS",
                        principalColumn: "ID_ADS");
                    table.ForeignKey(
                        name: "Relationship76",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                });

            migrationBuilder.CreateTable(
                name: "Office_capital",
                columns: table => new
                {
                    ID_Office_capital = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Old_Capital = table.Column<double>(type: "float", nullable: false),
                    New_capital = table.Column<double>(type: "float", nullable: false),
                    ID_Office = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier6", x => x.ID_Office_capital);
                    table.ForeignKey(
                        name: "Relationship47",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                });

            migrationBuilder.CreateTable(
                name: "Office/Partners",
                columns: table => new
                {
                    ID_Office = table.Column<int>(type: "int", nullable: false),
                    ID_Partners = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office/Partners", x => new { x.ID_Office, x.ID_Partners });
                    table.ForeignKey(
                        name: "Relationship40",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                    table.ForeignKey(
                        name: "Relationship41",
                        column: x => x.ID_Partners,
                        principalTable: "Partners",
                        principalColumn: "ID_Partners");
                });

            migrationBuilder.CreateTable(
                name: "Order_Clients",
                columns: table => new
                {
                    ID_Order_Clients = table.Column<int>(type: "int", nullable: false),
                    ID_Clients = table.Column<int>(type: "int", nullable: false),
                    ID_Office = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "char(1000)", unicode: false, fixedLength: true, maxLength: 1000, nullable: false),
                    Term = table.Column<DateTime>(type: "date", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Convenient_price = table.Column<double>(type: "float", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: true),
                    Wish = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier7", x => x.ID_Order_Clients);
                    table.ForeignKey(
                        name: "Relationship36",
                        column: x => x.ID_Clients,
                        principalTable: "Clients",
                        principalColumn: "ID_Clients");
                    table.ForeignKey(
                        name: "Relationship37",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    ID_Salary = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Money = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    ID_Emloyee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier60", x => x.ID_Salary);
                    table.ForeignKey(
                        name: "Relationship46",
                        column: x => x.ID_Emloyee,
                        principalTable: "Employee",
                        principalColumn: "ID_Emloyee");
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    ID_Vacations = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Remain = table.Column<int>(type: "int", nullable: false),
                    Used = table.Column<int>(type: "int", nullable: false),
                    Beginning_Vacations = table.Column<DateTime>(type: "date", nullable: false),
                    End_Vacations = table.Column<DateTime>(type: "date", nullable: false),
                    ID_Emloyee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier70", x => x.ID_Vacations);
                    table.ForeignKey(
                        name: "Relationship45",
                        column: x => x.ID_Emloyee,
                        principalTable: "Employee",
                        principalColumn: "ID_Emloyee");
                });

            migrationBuilder.CreateTable(
                name: "Payments_Clients",
                columns: table => new
                {
                    ID_Order_Clients = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "char(1000)", unicode: false, fixedLength: true, maxLength: 1000, nullable: false),
                    ID_Clients = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier8", x => x.ID_Order_Clients);
                    table.ForeignKey(
                        name: "Relationship43",
                        column: x => x.ID_Order_Clients,
                        principalTable: "Order_Clients",
                        principalColumn: "ID_Order_Clients");
                });

            migrationBuilder.CreateTable(
                name: "Report_Clients",
                columns: table => new
                {
                    ID_Report_Client = table.Column<int>(type: "int", nullable: false),
                    ID_Order_Clients = table.Column<int>(type: "int", nullable: false),
                    ID_Feedback = table.Column<int>(type: "int", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_Office_capital = table.Column<int>(type: "int", nullable: true),
                    ID_Office = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Unique_Identifier9", x => x.ID_Report_Client);
                    table.ForeignKey(
                        name: "Relationship29",
                        column: x => x.ID_Order_Clients,
                        principalTable: "Order_Clients",
                        principalColumn: "ID_Order_Clients");
                    table.ForeignKey(
                        name: "Relationship42",
                        column: x => x.ID_Feedback,
                        principalTable: "Feedback",
                        principalColumn: "ID_Feedback");
                    table.ForeignKey(
                        name: "Relationship49",
                        column: x => x.ID_Office_capital,
                        principalTable: "Office_capital",
                        principalColumn: "ID_Office_capital");
                    table.ForeignKey(
                        name: "Relationship50",
                        column: x => x.ID_Office,
                        principalTable: "Office",
                        principalColumn: "ID_Office");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relationship33",
                table: "Employee",
                column: "ID_Office");

            migrationBuilder.CreateIndex(
                name: "Relationship98",
                table: "Feedback",
                column: "ID_Clients");

            migrationBuilder.CreateIndex(
                name: "Relationship99",
                table: "Office",
                column: "ID_Departament");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship30_ADS",
                table: "Office_ADS",
                column: "ID_ADS");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship30_Office",
                table: "Office_ADS",
                column: "ID_Office");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship47",
                table: "Office_capital",
                column: "ID_Office");

            migrationBuilder.CreateIndex(
                name: "IX_Office/Partners_ID_Partners",
                table: "Office/Partners",
                column: "ID_Partners");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship36",
                table: "Order_Clients",
                column: "ID_Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship37",
                table: "Order_Clients",
                column: "ID_Office");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship43",
                table: "Payments_Clients",
                column: "ID_Order_Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship29",
                table: "Report_Clients",
                column: "ID_Order_Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship42",
                table: "Report_Clients",
                column: "ID_Feedback");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship49",
                table: "Report_Clients",
                column: "ID_Office_capital");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship50",
                table: "Report_Clients",
                column: "ID_Office");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship46",
                table: "Salary",
                column: "ID_Emloyee");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship45",
                table: "Vacations",
                column: "ID_Emloyee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Method_connection");

            migrationBuilder.DropTable(
                name: "Office_ADS");

            migrationBuilder.DropTable(
                name: "Office/Partners");

            migrationBuilder.DropTable(
                name: "Payments_Clients");

            migrationBuilder.DropTable(
                name: "Report_Clients");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "ADS");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Order_Clients");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Office_capital");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
