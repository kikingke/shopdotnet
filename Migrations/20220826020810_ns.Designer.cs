﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shopdotnet.Data;

#nullable disable

namespace shopdotnet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220826020810_ns")]
    partial class ns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("shopdotnet.Data.Entities.Category", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"), 1L, 1);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Category_ID");

                    b.HasIndex("Category_Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.City", b =>
                {
                    b.Property<int>("City_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("City_ID"), 1L, 1);

                    b.Property<string>("City_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("State_ID")
                        .HasColumnType("int");

                    b.HasKey("City_ID");

                    b.HasAlternateKey("City_Name")
                        .HasName("StateId");

                    b.HasIndex("State_ID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.Country", b =>
                {
                    b.Property<int>("Country_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Country_ID"), 1L, 1);

                    b.Property<string>("Country_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Country_ID");

                    b.HasIndex("Country_Name")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.State", b =>
                {
                    b.Property<int>("State_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("State_ID"), 1L, 1);

                    b.Property<int>("Country_ID")
                        .HasColumnType("int");

                    b.Property<string>("State_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("State_ID");

                    b.HasAlternateKey("State_Name")
                        .HasName("CountryId");

                    b.HasIndex("Country_ID");

                    b.ToTable("States");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.City", b =>
                {
                    b.HasOne("shopdotnet.Data.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("State_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.State", b =>
                {
                    b.HasOne("shopdotnet.Data.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("Country_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("shopdotnet.Data.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
