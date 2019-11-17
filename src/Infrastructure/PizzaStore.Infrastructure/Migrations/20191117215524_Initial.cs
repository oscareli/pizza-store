using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PIZZA_ORDER",
                columns: table => new
                {
                    PizzaOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(nullable: false),
                    Sabor = table.Column<string>(nullable: true),
                    Tamando = table.Column<string>(nullable: true),
                    Personalizacao = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    TempoDePreparo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PIZZA_ORDER", x => x.PizzaOrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PIZZA_ORDER");
        }
    }
}
