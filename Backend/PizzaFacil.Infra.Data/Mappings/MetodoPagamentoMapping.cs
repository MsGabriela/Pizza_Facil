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
    public class MetodoPagamentoMapping : IEntityTypeConfiguration<MetodoPagamento>
    {
        public void Configure(EntityTypeBuilder<MetodoPagamento> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.ToTable("MetodosPagamento");
        }
    }
}
