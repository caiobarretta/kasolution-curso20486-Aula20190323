using FN.Store.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.Data
{
    public class StoreDataContext : DbContext, IDataContext
    {
        private readonly IConfiguration _config;

        private string _conn => _config.GetConnectionString("StoreConnection");

        public StoreDataContext(IConfiguration config)
        {
            _config = config;
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produtos { get; set; }

        public string GetStringConn() => _conn;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_conn);

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Seed();
    }
}
