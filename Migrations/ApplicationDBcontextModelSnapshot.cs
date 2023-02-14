﻿// <auto-generated />
using HiloMRM3.NewFolder1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HiloMRM3.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    partial class ApplicationDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HiloMRM3.NewFolder.PizzaOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Items")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Left_ADD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Left_Axis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Left_CYL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Left_SPH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Left_VISION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Right_ADD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Right_AXIS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Right_CYL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Right_SPH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Right_VISION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PizzaOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
