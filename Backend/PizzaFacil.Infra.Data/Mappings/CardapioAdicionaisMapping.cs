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
    public class CardapioAdicionaisMapping : IEntityTypeConfiguration<CardapioAdicionais>
    {
        public void Configure(EntityTypeBuilder<CardapioAdicionais> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.Valor)
                .HasColumnType("decimal(5,2)")
                .IsRequired();

            builder.ToTable("CardapioAdicionais");
        }
    }
}
