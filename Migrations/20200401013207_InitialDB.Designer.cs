﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

namespace CSharpeAvaliacaoMVCLocadora.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200401013207_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Dias")
                        .HasColumnType("int");

                    b.Property<int>("FilmesLocados")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Models.Filme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DataLancamento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EstoqueAtual")
                        .HasColumnType("int");

                    b.Property<int>("EstoqueTotal")
                        .HasColumnType("int");

                    b.Property<int>("Locado")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Models.Locacao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Models.Locacao", b =>
                {
                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });
#pragma warning restore 612, 618
        }
    }
}
