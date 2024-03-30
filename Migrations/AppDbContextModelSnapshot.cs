﻿// <auto-generated />
using System;
using CadastroFotografo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroFotografo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CadastroFotografo.Model.Fotografo", b =>
                {
                    b.Property<int>("FotografoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("CameraFotografica")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataUltimaVisita")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FotografoId");

                    b.ToTable("Fotografos");
                });

            modelBuilder.Entity("CadastroFotografo.Model.Visita", b =>
                {
                    b.Property<int>("VisitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DataHora")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("FotografoId")
                        .HasColumnType("int");

                    b.HasKey("VisitaId");

                    b.HasIndex("FotografoId");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("CadastroFotografo.Model.Visita", b =>
                {
                    b.HasOne("CadastroFotografo.Model.Fotografo", "Fotografos")
                        .WithMany("Visitas")
                        .HasForeignKey("FotografoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fotografos");
                });

            modelBuilder.Entity("CadastroFotografo.Model.Fotografo", b =>
                {
                    b.Navigation("Visitas");
                });
#pragma warning restore 612, 618
        }
    }
}
