using Microsoft.EntityFrameworkCore.Migrations;

namespace JurcauIulia_Pizzerie.Migrations
{
    public partial class AluatPizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzerieID",
                table: "Pizza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Aluat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipAluat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pizzerie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumePizzerie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzerie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AluatPizza",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaID = table.Column<int>(type: "int", nullable: false),
                    AluatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AluatPizza", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AluatPizza_Aluat_AluatID",
                        column: x => x.AluatID,
                        principalTable: "Aluat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AluatPizza_Pizza_PizzaID",
                        column: x => x.PizzaID,
                        principalTable: "Pizza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_PizzerieID",
                table: "Pizza",
                column: "PizzerieID");

            migrationBuilder.CreateIndex(
                name: "IX_AluatPizza_AluatID",
                table: "AluatPizza",
                column: "AluatID");

            migrationBuilder.CreateIndex(
                name: "IX_AluatPizza_PizzaID",
                table: "AluatPizza",
                column: "PizzaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Pizzerie_PizzerieID",
                table: "Pizza",
                column: "PizzerieID",
                principalTable: "Pizzerie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Pizzerie_PizzerieID",
                table: "Pizza");

            migrationBuilder.DropTable(
                name: "AluatPizza");

            migrationBuilder.DropTable(
                name: "Pizzerie");

            migrationBuilder.DropTable(
                name: "Aluat");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_PizzerieID",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "PizzerieID",
                table: "Pizza");
        }
    }
}
