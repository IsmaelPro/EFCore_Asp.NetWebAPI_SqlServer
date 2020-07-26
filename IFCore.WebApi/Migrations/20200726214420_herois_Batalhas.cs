using Microsoft.EntityFrameworkCore.Migrations;

namespace IFCore.WebApi.Migrations
{
    public partial class herois_Batalhas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herois_Batalhas_BatalhaId",
                table: "Herois");

            migrationBuilder.DropIndex(
                name: "IX_Herois_BatalhaId",
                table: "Herois");

            migrationBuilder.DropColumn(
                name: "BatalhaId",
                table: "Herois");

            migrationBuilder.CreateTable(
                name: "HeroiBatalhas",
                columns: table => new
                {
                    HeroId = table.Column<int>(nullable: false),
                    BatalhaId = table.Column<int>(nullable: false),
                    HeroiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroiBatalhas", x => new { x.BatalhaId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_Batalhas_BatalhaId",
                        column: x => x.BatalhaId,
                        principalTable: "Batalhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_Herois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentidadeSecretas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReal = table.Column<int>(nullable: false),
                    IdentitidadeId = table.Column<int>(nullable: true),
                    HeroiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentidadeSecretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentidadeSecretas_Herois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentidadeSecretas_IdentidadeSecretas_IdentitidadeId",
                        column: x => x.IdentitidadeId,
                        principalTable: "IdentidadeSecretas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroiBatalhas_HeroiId",
                table: "HeroiBatalhas",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadeSecretas_HeroiId",
                table: "IdentidadeSecretas",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadeSecretas_IdentitidadeId",
                table: "IdentidadeSecretas",
                column: "IdentitidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroiBatalhas");

            migrationBuilder.DropTable(
                name: "IdentidadeSecretas");

            migrationBuilder.AddColumn<int>(
                name: "BatalhaId",
                table: "Herois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Herois_BatalhaId",
                table: "Herois",
                column: "BatalhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Herois_Batalhas_BatalhaId",
                table: "Herois",
                column: "BatalhaId",
                principalTable: "Batalhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
