﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RTX.Data;

#nullable disable

namespace RTX.Migrations
{
    [DbContext(typeof(RTXContext))]
    [Migration("20240621020819_Adicionando dados")]
    partial class Adicionandodados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RTX.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Creme de leite ideal para preparo de um belo strognoff.",
                            Name = "Creme de leite",
                            Photo = "https://superprix.vteximg.com.br/arquivos/ids/208274-600-600/7898215151784--1-.jpg?v=637915926153930000",
                            Price = 2.5899999999999999
                        },
                        new
                        {
                            Id = 2,
                            Description = "Achocolado da vaquinha.",
                            Name = "Achocolatado Toddy",
                            Photo = "https://ibassets.com.br/ib.item.image.large/l-a61c4723589c44c1b15c32685f5cee67.png",
                            Price = 12.99
                        },
                        new
                        {
                            Id = 3,
                            Description = "Maionese premium feita com ingredientes selecionados.",
                            Name = "Maionese Heinz",
                            Photo = "https://ibassets.com.br/ib.item.image.large/l-0bb27cf2a14c450ead9ab29f0fa2b4d1.jpeg",
                            Price = 19.989999999999998
                        },
                        new
                        {
                            Id = 4,
                            Description = "Salgadinho sabor cheddar, o melhor de todos.",
                            Name = "Salgadinho Doritos",
                            Photo = "https://atacadaobr.vtexassets.com/arquivos/ids/252509/g.jpg?v=638353972719200000",
                            Price = 10.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Refrigerante de cola mais famoso do mundo",
                            Name = "Coca-Cola 2L",
                            Photo = "https://www.paodeacucar.com/img/uploads/1/120/24982120.png",
                            Price = 8.9900000000000002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}