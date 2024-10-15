using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Droguerias",
                columns: table => new
                {
                    DrogueriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuit = table.Column<int>(type: "int", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Droguerias", x => x.DrogueriaId);
                });

            migrationBuilder.CreateTable(
                name: "Monodrogas",
                columns: table => new
                {
                    MonodrogaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monodrogas", x => x.MonodrogaId);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreComercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsVentaLibre = table.Column<bool>(type: "bit", nullable: false),
                    PrecioVenta = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    MonodrogaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.MedicamentoId);
                    table.ForeignKey(
                        name: "FK_Medicamentos_Monodrogas_MonodrogaId",
                        column: x => x.MonodrogaId,
                        principalTable: "Monodrogas",
                        principalColumn: "MonodrogaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_MonodrogaId",
                table: "Medicamentos",
                column: "MonodrogaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Droguerias");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Monodrogas");
        }
    }
}
