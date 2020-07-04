using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
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
                    Personalizacao = table.Column<string>(nullable: true),
                    ValorTotal = table.Column<double>(nullable: false),
                    TempoDePreparo = table.Column<int>(nullable: false)
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
