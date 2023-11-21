using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Models;

public partial class MyDatabaseContext : DbContext
{


    public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Appuser> Appusers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("appuser_pkey");

            entity.ToTable("appuser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("address");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
