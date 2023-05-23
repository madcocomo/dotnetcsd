using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Models;
using System.Collections.Generic;

namespace SupermarketAPI.Data
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }

    }
}