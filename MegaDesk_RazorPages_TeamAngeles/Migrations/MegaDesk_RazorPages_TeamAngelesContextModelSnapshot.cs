﻿// <auto-generated />
using System;
using MegaDesk_RazorPages_TeamAngeles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDesk_RazorPages_TeamAngeles.Migrations
{
    [DbContext(typeof(MegaDesk_RazorPages_TeamAngelesContext))]
    partial class MegaDesk_RazorPages_TeamAngelesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDesk_RazorPages_TeamAngeles.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("DeskDepth")
                        .HasColumnType("real");

                    b.Property<string>("DeskMaterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("DeskWidth")
                        .HasColumnType("real");

                    b.Property<float>("DrawerCost")
                        .HasColumnType("real");

                    b.Property<int>("NumDrawers")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("QuotePrice")
                        .HasColumnType("real");

                    b.Property<float>("RushCost")
                        .HasColumnType("real");

                    b.Property<float>("RushDays")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Desk");
                });
#pragma warning restore 612, 618
        }
    }
}
