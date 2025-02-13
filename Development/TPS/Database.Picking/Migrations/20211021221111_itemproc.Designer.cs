﻿// <auto-generated />
using System;
using Database.Picking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Picking.Migrations
{
    [DbContext(typeof(PickingDbContext))]
    [Migration("20211021221111_itemproc")]
    partial class itemproc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingDetailEntity", b =>
                {
                    b.Property<string>("OrderPicking_Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(511)
                        .HasColumnType("varchar(511)");

                    b.HasKey("OrderPicking_Id", "Name");

                    b.ToTable("Picking.OrderPickingDetail");
                });

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Picking.OrderPicking");
                });

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingProcessEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Container")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OrderPicking_Id")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Sector")
                        .HasColumnType("longtext");

                    b.Property<int>("Status_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderPicking_Id");

                    b.HasIndex("Status_Id");

                    b.ToTable("Picking.OrderPickingProcess");
                });

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Picking.OrderPickingStatus");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 2000,
                            Status = "WIP"
                        },
                        new
                        {
                            Id = 3000,
                            Status = "READY"
                        },
                        new
                        {
                            Id = 4000,
                            Status = "PICKED"
                        });
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemDetailEntity", b =>
                {
                    b.Property<string>("PickingItem_Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(511)
                        .HasColumnType("varchar(511)");

                    b.HasKey("PickingItem_Id", "Name");

                    b.ToTable("Picking.PickingItemDetail");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("OrderPicking_Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("OrderPicking_Id");

                    b.ToTable("Picking.PickingItem");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemProcessEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PickingItem_Id")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Status_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PickingItem_Id");

                    b.HasIndex("Status_Id");

                    b.ToTable("Picking.PickingItemProcess");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Picking.PickingItemStatus");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 1500,
                            Status = "PENDING_READING"
                        },
                        new
                        {
                            Id = 2000,
                            Status = "NO_READING"
                        },
                        new
                        {
                            Id = 3000,
                            Status = "MISSING"
                        },
                        new
                        {
                            Id = 4000,
                            Status = "PICKED"
                        });
                });

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingDetailEntity", b =>
                {
                    b.HasOne("Database.Picking.Entities.OrderPickingEntity", "OrderPicking")
                        .WithMany("Details")
                        .HasForeignKey("OrderPicking_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderPicking");
                });

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingProcessEntity", b =>
                {
                    b.HasOne("Database.Picking.Entities.OrderPickingEntity", "OrderPicking")
                        .WithMany("Processes")
                        .HasForeignKey("OrderPicking_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Picking.Entities.OrderPickingStatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("Status_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderPicking");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemDetailEntity", b =>
                {
                    b.HasOne("Database.Picking.Entities.PickingItemEntity", "PickingItem")
                        .WithMany("Details")
                        .HasForeignKey("PickingItem_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PickingItem");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemEntity", b =>
                {
                    b.HasOne("Database.Picking.Entities.OrderPickingEntity", "OrderPicking")
                        .WithMany("Items")
                        .HasForeignKey("OrderPicking_Id");

                    b.Navigation("OrderPicking");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemProcessEntity", b =>
                {
                    b.HasOne("Database.Picking.Entities.PickingItemEntity", "PickingItem")
                        .WithMany("Processes")
                        .HasForeignKey("PickingItem_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Picking.Entities.PickingItemStatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("Status_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PickingItem");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Database.Picking.Entities.OrderPickingEntity", b =>
                {
                    b.Navigation("Details");

                    b.Navigation("Items");

                    b.Navigation("Processes");
                });

            modelBuilder.Entity("Database.Picking.Entities.PickingItemEntity", b =>
                {
                    b.Navigation("Details");

                    b.Navigation("Processes");
                });
#pragma warning restore 612, 618
        }
    }
}
