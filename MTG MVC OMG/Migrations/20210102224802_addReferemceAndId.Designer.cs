﻿// <auto-generated />
using MTG_MVC_OMG.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MTG_MVC_OMG.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210102224802_addReferemceAndId")]
    partial class addReferemceAndId
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

                    b.ToTable("Colors");
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

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreferredColorId")
                        .HasColumnType("int");

                    b.Property<int>("PreferredFormatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreferredColorId");

                    b.HasIndex("PreferredFormatId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Player", b =>
                {
                    b.HasOne("MTG_MVC_OMG.Models.Color", "PreferredColor")
                        .WithMany("Players")
                        .HasForeignKey("PreferredColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MTG_MVC_OMG.Models.Format", "PreferredFormat")
                        .WithMany("Players")
                        .HasForeignKey("PreferredFormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PreferredColor");

                    b.Navigation("PreferredFormat");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Color", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("MTG_MVC_OMG.Models.Format", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
