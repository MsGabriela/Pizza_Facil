﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaFacil.Infra.Data.Context;

#nullable disable

namespace PizzaFacil.Infra.Data.Migrations
{
    [DbContext(typeof(PizzaFacilDbContext))]
    [Migration("20240224171911_TabelaItensPedido")]
    partial class TabelaItensPedido
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PizzaFacil.Domain.Entities.Cardapio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Cardapio", (string)null);
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.CardapioAdicionais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("CardapioAdicionais", (string)null);
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.ItensPedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("CardapioId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("ValorDoItem")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("CardapioId");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.MetodoPagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MetodosPagamento", (string)null);
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("MetodoPagamentoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("NumeroDoPedido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("QuantidadePizzas")
                        .HasColumnType("int");

                    b.Property<Guid>("StatusPedidoId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("MetodoPagamentoId");

                    b.HasIndex("StatusPedidoId");

                    b.ToTable("Pedidos", (string)null);
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.StatusPedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("StatusPedidos", (string)null);
                });

            modelBuilder.Entity("PizzaFacil.Domain.Models.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.Cardapio", b =>
                {
                    b.HasOne("PizzaFacil.Domain.Models.Categoria", "Categoria")
                        .WithMany("Pizzas")
                        .HasForeignKey("CategoriaId")
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.ItensPedido", b =>
                {
                    b.HasOne("PizzaFacil.Domain.Entities.Cardapio", "Cardapio")
                        .WithMany("ItensPedido")
                        .HasForeignKey("CardapioId")
                        .IsRequired();

                    b.HasOne("PizzaFacil.Domain.Entities.Pedido", "Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId")
                        .IsRequired();

                    b.Navigation("Cardapio");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("PizzaFacil.Domain.Entities.MetodoPagamento", "MetodoPagamento")
                        .WithMany("Pedidos")
                        .HasForeignKey("MetodoPagamentoId")
                        .IsRequired();

                    b.HasOne("PizzaFacil.Domain.Entities.StatusPedido", "StatusPedido")
                        .WithMany("Pedidos")
                        .HasForeignKey("StatusPedidoId")
                        .IsRequired();

                    b.Navigation("MetodoPagamento");

                    b.Navigation("StatusPedido");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.Cardapio", b =>
                {
                    b.Navigation("ItensPedido");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.MetodoPagamento", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("ItensPedido");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Entities.StatusPedido", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("PizzaFacil.Domain.Models.Categoria", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
