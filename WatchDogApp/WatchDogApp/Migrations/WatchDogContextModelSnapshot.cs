﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WatchDogApp.Data;

#nullable disable

namespace WatchDogApp.Migrations
{
    [DbContext(typeof(WatchDogContext))]
    partial class WatchDogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WatchDogApp.models.Entity.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDown")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("domains");
                });

            modelBuilder.Entity("WatchDogApp.models.Entity.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDown")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("histories");
                });

            modelBuilder.Entity("WatchDogApp.models.Entity.History", b =>
                {
                    b.HasOne("WatchDogApp.models.Entity.Domain", "DomainName")
                        .WithMany("history")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DomainName");
                });

            modelBuilder.Entity("WatchDogApp.models.Entity.Domain", b =>
                {
                    b.Navigation("history");
                });
#pragma warning restore 612, 618
        }
    }
}