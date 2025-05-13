using System;
using System.Collections.Generic;
using Cakeshop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CakeShop.Persistance.Context;

public partial class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the one-to-many relationship between Item and Ingredient
        modelBuilder.Entity<Item>()
            .HasMany(i => i.Ingredients)       // An Item has many Ingredients
            .WithOne(ing => ing.Item)          // An Ingredient belongs to one Item
            .HasForeignKey(ing => ing.ItemId)  // Using Ingredient.ItemId as the foreign key
            .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete ingredients if an item is deleted
    }
}
