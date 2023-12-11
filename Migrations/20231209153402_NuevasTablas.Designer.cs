﻿// <auto-generated />
using APIProductos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIProductos.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231209153402_NuevasTablas")]
    partial class NuevasTablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIProductos.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Descripcion = "Desc1",
                            Imagen = "https://images.ctfassets.net/63bmaubptoky/8e6EHyyhZoA2rEb_gcW_Wqp1UYa-QFOfol6A_hLTDo4/d07539f9788941b43e301c741bc144ce/what-is-software-CA-Capterra-Header.png",
                            Nombre = "Producto1",
                            Precio = 50m,
                            Stock = 13
                        });
                });

            modelBuilder.Entity("APIProductos.Models.ProductoEnCarrito", b =>
                {
                    b.Property<int>("IdProductoEnCarrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProductoEnCarrito"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("ProductoIdProducto")
                        .HasColumnType("int");

                    b.HasKey("IdProductoEnCarrito");

                    b.HasIndex("ProductoIdProducto");

                    b.ToTable("ProductosEnCarrito");
                });

            modelBuilder.Entity("APIProductos.Models.Resena", b =>
                {
                    b.Property<int>("IdResena")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdResena"));

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViniloId")
                        .HasColumnType("int");

                    b.HasKey("IdResena");

                    b.ToTable("Resenas");
                });

            modelBuilder.Entity("APIProductos.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Apellidos = "Admin",
                            Contrasenia = "empanada123",
                            Correo = "admin@gmail.com",
                            Nombre = "Admin",
                            Rol = "admin"
                        });
                });

            modelBuilder.Entity("APIProductos.Models.ProductoEnCarrito", b =>
                {
                    b.HasOne("APIProductos.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}