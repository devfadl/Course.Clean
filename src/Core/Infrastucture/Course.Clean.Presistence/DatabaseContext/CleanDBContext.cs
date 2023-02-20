using Course.Clean.Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Presistence.DatabaseContext
{
    public class CleanDBContext :DbContext
    {
        public CleanDBContext(DbContextOptions<CleanDBContext> options) :base(options) { }
        public DbSet<LeavTypes> LeaveTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CleanDBContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in base.ChangeTracker.Entries<AuditableBaseEntity>().Where(a=>a.State == EntityState.Added || a.State == EntityState.Modified))
            {
                item.Entity.ModifyDate = DateTime.Now;
                if(item.State == EntityState.Added)
                {
                    item.Entity.CreationDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
