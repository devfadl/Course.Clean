using Course.Clean.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Clean.Presistence.Configurations
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeavTypes>
    {
        public void Configure(EntityTypeBuilder<LeavTypes> builder)
        {
            builder.ToTable("LeaveTypes");
            builder.HasKey(x => x.Id);
            builder.Property(a=>a.IsActive).HasDefaultValue(true);
            builder.Property(a => a.CreationDate).HasColumnType("datetime");
            builder.Property(a => a.ModifyDate).HasColumnType("datetime");
        }
    }
}
