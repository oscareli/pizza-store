﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaStore.Infrastructure.Data;

namespace PizzaStore.Infrastructure.Migrations
{
    [DbContext(typeof(PizzaOrderContext))]
    partial class PizzaOrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaStore.ApplicationCore.Entities.PizzaOrder", b =>
                {
                    b.Property<int>("PizzaOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Personalizacao")
                        .HasColumnType("int");

                    b.Property<string>("Sabor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tamando")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TempoDePreparo")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PizzaOrderId");

                    b.ToTable("TB_PIZZA_ORDER");
                });
#pragma warning restore 612, 618
        }
    }
}
