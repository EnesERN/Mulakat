using Microsoft.EntityFrameworkCore;
using Mulakat.Data.Extensions;
using Mulakat.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Context
{
    public class MulakatContext : DbContext
    {
        public MulakatContext(DbContextOptions<MulakatContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Movie> Movie { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.ID).HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<Movie>().Property(x => x.ID).HasDefaultValueSql("newsequentialid()");

            modelBuilder.RemovePluralizingTableNameConvention();
            modelBuilder.RemoveCascadeDeleteConvention();

            modelBuilder.SeedMovies();

            base.OnModelCreating(modelBuilder);
        }

        public int Commit()
        {
            return this.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await this.SaveChangesAsync();
        }
    }
}
