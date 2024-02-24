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
    public class ItensAdicionaisMapping : IEntityTypeConfiguration<ItensAdicionais>
    {
        public void Configure(EntityTypeBuilder<ItensAdicionais> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Descricao)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(i => i.ValorDoAdicional)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.HasOne(i => i.ItemPedido)
                .WithMany(p => p.ItensAdicionais);

            builder.HasOne(i => i.CardapioAdicional)
                .WithMany(c => c.ItensAdicionais);

            builder.ToTable("ItensAdicionais");
        }
    }
}
