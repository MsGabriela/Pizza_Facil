using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaFacil.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TabelaItensAdicionais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItensAdicionais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ValorDoAdicional = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 100, nullable: false),
                    ItemPedidoId = table.Column<Guid>(type: "char(36)", nullable: false),
                    CardapioAdicionalId = table.Column<Guid>(type: "char(36)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensAdicionais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensAdicionais_CardapioAdicionais_CardapioAdicionalId",
                        column: x => x.CardapioAdicionalId,
                        principalTable: "CardapioAdicionais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItensAdicionais_ItensPedido_ItemPedidoId",
                        column: x => x.ItemPedidoId,
                        principalTable: "ItensPedido",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ItensAdicionais_CardapioAdicionalId",
                table: "ItensAdicionais",
                column: "CardapioAdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensAdicionais_ItemPedidoId",
                table: "ItensAdicionais",
                column: "ItemPedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensAdicionais");
        }
    }
}
