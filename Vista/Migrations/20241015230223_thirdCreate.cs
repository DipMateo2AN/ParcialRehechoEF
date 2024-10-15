using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Migrations
{
    /// <inheritdoc />
    public partial class thirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
