using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaFacil.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TabelaPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    NumeroDoPedido = table.Column<string>(type: "varchar(50)", nullable: false),
                    QuantidadePizzas = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    MetodoPagamentoId = table.Column<Guid>(type: "char(36)", nullable: false),
                    StatusPedidoId = table.Column<Guid>(type: "char(36)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_MetodosPagamento_MetodoPagamentoId",
                        column: x => x.MetodoPagamentoId,
                        principalTable: "MetodosPagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedidos_StatusPedidos_StatusPedidoId",
                        column: x => x.StatusPedidoId,
                        principalTable: "StatusPedidos",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MetodoPagamentoId",
                table: "Pedidos",
                column: "MetodoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_StatusPedidoId",
                table: "Pedidos",
                column: "StatusPedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
