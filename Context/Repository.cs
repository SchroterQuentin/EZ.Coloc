using System;
using EZ.Coloc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EZ.Coloc.Context
{
    public class Repository : IdentityDbContext<User>
    {
        public Repository(DbContextOptions<Repository> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=repository.db");
        }
        public DbSet<SimpleOperation> SimpleOperations { get; set; }
        public DbSet<SharedOperation> SharedOperation { get; set; }
        public DbSet<PercentUser> PercentUser { get; set; }

    }
}