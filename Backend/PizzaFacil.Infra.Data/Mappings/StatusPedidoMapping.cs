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
    public class StatusPedidoMapping : IEntityTypeConfiguration<StatusPedido>
    {
        public void Configure(EntityTypeBuilder<StatusPedido> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.ToTable("StatusPedidos");
        }
    }
}
