﻿// <auto-generated />
using System;
using InmobiliariaSosa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InmobiliariaSosa.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InmobiliariaSosa.Models.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("FechaCancelado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDesde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHasta")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdGarante")
                        .HasColumnType("int");

                    b.Property<int>("IdInmueble")
                        .HasColumnType("int");

                    b.Property<int>("IdInquilino")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdInmueble");

                    b.HasIndex("IdInquilino");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Garante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Garante");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Inmueble", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ambiente")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Latitud")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitud")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Superficie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inmueble");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Inquilino", b =>
                {
                    b.Property<int>("idInquilino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idInquilino");

                    b.ToTable("Inquilino");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContratoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumeroPago")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContratoId");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Propietario", b =>
                {
                    b.Property<int>("idPropietario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("avatar")
                        .HasColumnType("int");

                    b.Property<string>("clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPropietario");

                    b.ToTable("Propietario");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveNueva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "admin",
                            Avatar = "/Uploadsvatar_1.jpg",
                            Clave = "GAKKw6Co5EiIGNiZC1OfQC6offL+e8CoEs3SX0LIrHA=",
                            Email = "admin@mail.com",
                            Nombre = "admin",
                            Rol = 1
                        });
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Contrato", b =>
                {
                    b.HasOne("InmobiliariaSosa.Models.Inmueble", "Inmueble")
                        .WithMany()
                        .HasForeignKey("IdInmueble")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InmobiliariaSosa.Models.Inquilino", "Inquilino")
                        .WithMany()
                        .HasForeignKey("IdInquilino")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inmueble");

                    b.Navigation("Inquilino");
                });

            modelBuilder.Entity("InmobiliariaSosa.Models.Pago", b =>
                {
                    b.HasOne("InmobiliariaSosa.Models.Contrato", "Contrato")
                        .WithMany()
                        .HasForeignKey("ContratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contrato");
                });
#pragma warning restore 612, 618
        }
    }
}
