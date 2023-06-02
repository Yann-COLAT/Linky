﻿// <auto-generated />
using Linky.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Linky.API.Migrations
{
    [DbContext(typeof(LinkyContext))]
    partial class LinkyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Linky.Entities.Entities.Indicator", b =>
                {
                    b.Property<int>("IdIndicator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIndicator"));

                    b.Property<double>("ConsumIndicator")
                        .HasColumnType("float");

                    b.Property<int>("NumIndicator")
                        .HasColumnType("int");

                    b.Property<double>("PowerIndicator")
                        .HasColumnType("float");

                    b.Property<bool>("SwitchOnIndicator")
                        .HasColumnType("bit");

                    b.HasKey("IdIndicator");

                    b.ToTable("Indicator", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}