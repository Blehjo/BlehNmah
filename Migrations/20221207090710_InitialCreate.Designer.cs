﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesBlehNmah.Data;

#nullable disable

namespace RazorPagesBlehNmah.Migrations
{
    [DbContext(typeof(RazorPagesGalleryContext))]
    [Migration("20221207090710_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("RazorPagesBlehNmah.Models.Collection", b =>
                {
                    b.Property<int>("CollectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CollectionName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("CollectionID");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("RazorPagesBlehNmah.Models.Painting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CollectionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Medium")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CollectionID");

                    b.ToTable("Painting");
                });

            modelBuilder.Entity("RazorPagesBlehNmah.Models.Photograph", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CollectionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CollectionID");

                    b.ToTable("Photograph");
                });

            modelBuilder.Entity("RazorPagesBlehNmah.Models.Painting", b =>
                {
                    b.HasOne("RazorPagesBlehNmah.Models.Collection", "Collection")
                        .WithMany("Paintings")
                        .HasForeignKey("CollectionID");

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("RazorPagesBlehNmah.Models.Photograph", b =>
                {
                    b.HasOne("RazorPagesBlehNmah.Models.Collection", "Collection")
                        .WithMany("Photographs")
                        .HasForeignKey("CollectionID");

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("RazorPagesBlehNmah.Models.Collection", b =>
                {
                    b.Navigation("Paintings");

                    b.Navigation("Photographs");
                });
#pragma warning restore 612, 618
        }
    }
}
