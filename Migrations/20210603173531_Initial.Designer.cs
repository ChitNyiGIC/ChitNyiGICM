﻿// <auto-generated />
using CRUDWithMysqlAndAspNetCoreMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDWithMysqlAndAspNetCoreMVC.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210603173531_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("CRUDWithMysqlAndAspNetCoreMVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<short>("Age")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<short>("IsPlayer")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
