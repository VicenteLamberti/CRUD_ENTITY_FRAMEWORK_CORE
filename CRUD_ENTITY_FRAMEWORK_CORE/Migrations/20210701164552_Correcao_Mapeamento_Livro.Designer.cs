﻿// <auto-generated />
using System;
using CRUD_ENTITY_FRAMEWORK_CORE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210701164552_Correcao_Mapeamento_Livro")]
    partial class Correcao_Mapeamento_Livro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CRUD_ENTITY_FRAMEWORK_CORE.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Software"
                        });
                });

            modelBuilder.Entity("CRUD_ENTITY_FRAMEWORK_CORE.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(151)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("DATETIME");

                    b.Property<decimal>("Preco")
                        .HasColumnType("NUMERIC(38,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("Titulo")
                        .HasDatabaseName("IX_Livro_Titulo");

                    b.ToTable("Livro");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Autor = "Autor 1",
                            CategoriaId = 1,
                            DataEntrada = new DateTime(2021, 7, 1, 13, 45, 51, 762, DateTimeKind.Local).AddTicks(8559),
                            Preco = 50m,
                            Quantidade = 10,
                            Titulo = "Titulo 1"
                        },
                        new
                        {
                            Id = 2,
                            Autor = "Autor 2",
                            CategoriaId = 1,
                            DataEntrada = new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5951),
                            Preco = 770m,
                            Quantidade = 10,
                            Titulo = "Titulo 2"
                        },
                        new
                        {
                            Id = 3,
                            Autor = "Autor 3",
                            CategoriaId = 1,
                            DataEntrada = new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5985),
                            Preco = 580m,
                            Quantidade = 10,
                            Titulo = "Titulo 3"
                        },
                        new
                        {
                            Id = 4,
                            Autor = "Autor 4",
                            CategoriaId = 1,
                            DataEntrada = new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5987),
                            Preco = 30m,
                            Quantidade = 10,
                            Titulo = "Titulo 4"
                        },
                        new
                        {
                            Id = 5,
                            Autor = "Autor 5",
                            CategoriaId = 1,
                            DataEntrada = new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5988),
                            Preco = 250m,
                            Quantidade = 10,
                            Titulo = "Titulo 5"
                        },
                        new
                        {
                            Id = 6,
                            Autor = "Autor 6",
                            CategoriaId = 1,
                            DataEntrada = new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5996),
                            Preco = 505m,
                            Quantidade = 10,
                            Titulo = "Titulo 6"
                        });
                });

            modelBuilder.Entity("CRUD_ENTITY_FRAMEWORK_CORE.Models.Livro", b =>
                {
                    b.HasOne("CRUD_ENTITY_FRAMEWORK_CORE.Models.Categoria", "Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("CRUD_ENTITY_FRAMEWORK_CORE.Models.Categoria", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}