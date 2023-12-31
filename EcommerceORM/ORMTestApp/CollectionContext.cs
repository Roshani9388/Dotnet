﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;
using Microsoft.EntityFrameworkCore;

namespace DAL;


public class CollectionContext : DbContext
{
    public DbSet<Department> Departments { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = @"server=192.168.10.150;port=3306;user=dac22;password=welcome;database=dac22_campus";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>(entity => {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Location).IsRequired();

        });
        modelBuilder.Entity<Department>().ToTable("departments");

    }
}
