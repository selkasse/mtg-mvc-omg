﻿// <auto-generated />
using System;
using MTG_MVC_OMG.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MTG_MVC_OMG.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210102083912_addCollectionOfPlayersToFormatModel2")]
    partial class addCollectionOfPlayersToFormatModel2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MTG_MVC_OMG.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Format", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Format");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PreferredColorId")
                        .HasColumnType("int");

                    b.Property<int?>("PreferredFormatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreferredColorId");

                    b.HasIndex("PreferredFormatId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Player", b =>
                {
                    b.HasOne("MTG_MVC_OMG.Models.Color", "PreferredColor")
                        .WithMany()
                        .HasForeignKey("PreferredColorId");

                    b.HasOne("MTG_MVC_OMG.Models.Format", "PreferredFormat")
                        .WithMany("Players")
                        .HasForeignKey("PreferredFormatId");

                    b.Navigation("PreferredColor");

                    b.Navigation("PreferredFormat");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Format", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
