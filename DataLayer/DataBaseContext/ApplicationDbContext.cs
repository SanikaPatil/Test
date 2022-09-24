using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DataBaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Metric> MerticsData { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Metric>(entity =>
            {
                entity.HasKey(x => x.sr_no);

                entity.ToTable("MetricTable");

                entity.Property(e => e.Distance).IsRequired();

                entity.Property(e => e.Temperature).IsRequired();

                entity.Property(e => e.Weight).IsRequired();

            });
        }
    }
}
