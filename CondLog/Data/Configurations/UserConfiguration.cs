using CondLog.Models;
using Microsoft.EntityFrameworkCore;

namespace CondLog.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuários");

            //builder.HasKey(x => x.Id);
            builder.HasMany(x => x.UserOcurrences).
                WithOne(x => x.user).HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
