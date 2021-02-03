using MedialCare.Models.Entities;
using MedialCare.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Data.Configurations
{
    public class PolicyOnEmployeeConfiguration : IEntityTypeConfiguration<PolicyOnEmployee>
    {
        public void Configure(EntityTypeBuilder<PolicyOnEmployee> builder)
        {
            builder.ToTable("PolicyOnEmployees");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.StartDate).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.EndDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasDefaultValue(Status.Request);
            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);

            builder.HasOne(x => x.User).WithMany(x => x.PolicyOnEmployees).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Policy).WithMany(x => x.PolicyOnEmployee).HasForeignKey(x => x.PolicyId);
        }
    }
}
