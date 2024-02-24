using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaFacil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Infra.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.NumeroDoPedido)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.QuantidadePizzas)
                .IsRequired();

            builder.Property(p => p.ValorTotal)
                .HasColumnType("decimal(5,2)")
                .IsRequired();

            builder.HasOne(p => p.MetodoPagamento)
                .WithMany(mp => mp.Pedidos);

            builder.HasOne(p => p.StatusPedido)
                .WithMany(sp => sp.Pedidos);

            builder.ToTable("Pedidos");
        }
    }
}
