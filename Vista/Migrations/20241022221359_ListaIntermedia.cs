using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Migrations
{
    /// <inheritdoc />
    public partial class ListaIntermedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Droguerias_DrogueriaId",
                table: "Medicamentos");

            migrationBuilder.DropIndex(
                name: "IX_Medicamentos_DrogueriaId",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "DrogueriaId",
                table: "Medicamentos");

            migrationBuilder.CreateTable(
                name: "DrogueriaMedicamento",
                columns: table => new
                {
                    DrogueriasDrogueriaId = table.Column<int>(type: "int", nullable: false),
                    MedicamentosMedicamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrogueriaMedicamento", x => new { x.DrogueriasDrogueriaId, x.MedicamentosMedicamentoId });
                    table.ForeignKey(
                        name: "FK_DrogueriaMedicamento_Droguerias_DrogueriasDrogueriaId",
                        column: x => x.DrogueriasDrogueriaId,
                        principalTable: "Droguerias",
                        principalColumn: "DrogueriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrogueriaMedicamento_Medicamentos_MedicamentosMedicamentoId",
                        column: x => x.MedicamentosMedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrogueriaMedicamento_MedicamentosMedicamentoId",
                table: "DrogueriaMedicamento",
                column: "MedicamentosMedicamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrogueriaMedicamento");

            migrationBuilder.AddColumn<int>(
                name: "DrogueriaId",
                table: "Medicamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_DrogueriaId",
                table: "Medicamentos",
                column: "DrogueriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Droguerias_DrogueriaId",
                table: "Medicamentos",
                column: "DrogueriaId",
                principalTable: "Droguerias",
                principalColumn: "DrogueriaId");
        }
    }
}
