using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSWebApi;

namespace MSWebApi.Data
{
    public class MSWebApiContext : DbContext
    {
        public MSWebApiContext (DbContextOptions<MSWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<MSWebApi.Member> Member { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MSWebApi.Member>().ToTable("Member");
        }
    }
}
