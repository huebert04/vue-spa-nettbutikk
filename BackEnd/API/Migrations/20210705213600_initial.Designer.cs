﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace API.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20210705213600_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("API.Data.ProductEntity", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.HasKey("ProductID");

                    b.ToTable("ProductSet");
                });
#pragma warning restore 612, 618
        }
    }
}
