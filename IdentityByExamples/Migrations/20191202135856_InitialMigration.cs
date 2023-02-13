using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Dpi = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Children = table.Column<int>(nullable: false),
                    SalaryBase = table.Column<decimal>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
