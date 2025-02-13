﻿using Database.Picking.Entities;
using Database.Picking.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Picking
{
    public class PickingDbContext : DbContext
    {
        public PickingDbContext(DbContextOptions<PickingDbContext> options) : base(options) { }
        
        public DbSet<OrderPickingEntity> OrderPickings { get; set; }
        public DbSet<OrderPickingDetailEntity> OrderPickingDetails { get; set; }
        public DbSet<OrderPickingStatusEntity> OrderPickingStatus { get; set; }
        public DbSet<OrderPickingProcessEntity> OrderPickingProcesses { get; set; }
        public DbSet<PickingItemEntity> PickingItems { get; set; }
        public DbSet<PickingItemDetailEntity> PickingItemDetails { get; set; }
        public DbSet<OrderPickingStatusEntity> PickingItemStatus { get; set; }
        public DbSet<PickingItemProcessEntity> PickingItemProcesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderPickingEntityMap());
            modelBuilder.ApplyConfiguration(new OrderPickingDetailEntityMap());
            modelBuilder.ApplyConfiguration(new OrderPickingStatusEntityMap());
            modelBuilder.ApplyConfiguration(new OrderPickingProcessEntityMap());
            modelBuilder.ApplyConfiguration(new PickingItemEntityMap());
            modelBuilder.ApplyConfiguration(new PickingItemDetailEntityMap());
            modelBuilder.ApplyConfiguration(new PickingItemStatusEntityMap());
            modelBuilder.ApplyConfiguration(new PickingItemProcessEntityMap());
        }
    }
}
