using CondLog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CondLog.Data.Configurations
{
    public class OcurrenceConfiguration : IEntityTypeConfiguration<Ocurrence>
    {
        public void Configure(EntityTypeBuilder<Ocurrence> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
