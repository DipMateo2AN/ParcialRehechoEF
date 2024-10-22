﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Vista.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241022221359_ListaIntermedia")]
    partial class ListaIntermedia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DrogueriaMedicamento", b =>
                {
                    b.Property<int>("DrogueriasDrogueriaId")
                        .HasColumnType("int");

                    b.Property<int>("MedicamentosMedicamentoId")
                        .HasColumnType("int");

                    b.HasKey("DrogueriasDrogueriaId", "MedicamentosMedicamentoId");

                    b.HasIndex("MedicamentosMedicamentoId");

                    b.ToTable("DrogueriaMedicamento");
                });

            modelBuilder.Entity("Modelo.Drogueria", b =>
                {
                    b.Property<int>("DrogueriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrogueriaId"));

                    b.Property<int>("Cuit")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrogueriaId");

                    b.ToTable("Droguerias");
                });

            modelBuilder.Entity("Modelo.Medicamento", b =>
                {
                    b.Property<int>("MedicamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicamentoId"));

                    b.Property<bool>("EsVentaLibre")
                        .HasColumnType("bit");

                    b.Property<string>("MonodrogaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreComercial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrecioVenta")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int");

                    b.HasKey("MedicamentoId");

                    b.HasIndex("MonodrogaId");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("Modelo.Monodroga", b =>
                {
                    b.Property<string>("MonodrogaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonodrogaId");

                    b.ToTable("Monodrogas");
                });

            modelBuilder.Entity("DrogueriaMedicamento", b =>
                {
                    b.HasOne("Modelo.Drogueria", null)
                        .WithMany()
                        .HasForeignKey("DrogueriasDrogueriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Medicamento", null)
                        .WithMany()
                        .HasForeignKey("MedicamentosMedicamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.Medicamento", b =>
                {
                    b.HasOne("Modelo.Monodroga", "Monodroga")
                        .WithMany()
                        .HasForeignKey("MonodrogaId");

                    b.Navigation("Monodroga");
                });
#pragma warning restore 612, 618
        }
    }
}
