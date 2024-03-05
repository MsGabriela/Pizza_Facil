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
    public class ItensPedidoMapping : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(EntityTypeBuilder<ItensPedido> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ValorDoItem)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(i => i.Observacoes)
                .HasColumnType("varchar(200)");

            builder.HasOne(i => i.Pedido)
                .WithMany(p => p.ItensPedido);

            builder.HasOne(i => i.Cardapio)
                .WithMany(c => c.ItensPedido);
        }
    }
}
