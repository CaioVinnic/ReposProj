﻿// <auto-generated />
using System;
using AppLanches.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppLanches.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190920190955_Pedidos")]
    partial class Pedidos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppLanches.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarrinhoCompraId")
                        .HasMaxLength(200);

                    b.Property<int?>("LancheId");

                    b.Property<int>("Quantidade");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("LancheId");

                    b.ToTable("CarrinhoCompraItens");
                });

            modelBuilder.Entity("AppLanches.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaNome")
                        .HasMaxLength(100);

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("AppLanches.Models.Lanche", b =>
                {
                    b.Property<int>("LancheId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId");

                    b.Property<string>("DescricaoCurta")
                        .HasMaxLength(100);

                    b.Property<string>("DescricaoDetalhada")
                        .HasMaxLength(255);

                    b.Property<bool>("EmEstoque");

                    b.Property<string>("ImagemThumbnailUrl")
                        .HasMaxLength(200);

                    b.Property<string>("ImagemUrl")
                        .HasMaxLength(200);

                    b.Property<bool>("IsLanchePreferido");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<decimal>("Preco");

                    b.HasKey("LancheId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Lanches");
                });

            modelBuilder.Entity("AppLanches.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Endereco1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Endereco2")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .HasMaxLength(10);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("PedidoEnviado");

                    b.Property<decimal>("PedidoTotal");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("AppLanches.Models.PedidoDetalhe", b =>
                {
                    b.Property<int>("PedidoDetalheId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LancheId");

                    b.Property<int>("PedidoId");

                    b.Property<decimal>("Preco");

                    b.Property<int>("Quantidade");

                    b.HasKey("PedidoDetalheId");

                    b.HasIndex("LancheId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidoDetalhes");
                });

            modelBuilder.Entity("AppLanches.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("AppLanches.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId");
                });

            modelBuilder.Entity("AppLanches.Models.Lanche", b =>
                {
                    b.HasOne("AppLanches.Models.Categoria", "Categoria")
                        .WithMany("Lanche")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AppLanches.Models.PedidoDetalhe", b =>
                {
                    b.HasOne("AppLanches.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppLanches.Models.Pedido", "Pedido")
                        .WithMany("PedidoItens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
