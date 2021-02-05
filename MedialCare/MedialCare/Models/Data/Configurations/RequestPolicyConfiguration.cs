using MedialCare.Models.Data.Entities;
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
    public class RequestPolicyConfiguration : IEntityTypeConfiguration<RequestPolicy>
    {
        public void Configure(EntityTypeBuilder<RequestPolicy> builder)
        {
            builder.ToTable("RequestPolicies");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.PolicyID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Request);
          
            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);




        }
    }
}
