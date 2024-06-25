using CondLog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CondLog.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        internal void Seed()
        {
            _modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "2f77923c-6f14-4248-9d58-93819b5c4d94",
                    Name = "Usuário",
                    NormalizedName = "USUÁRIO"
                }
                );

            var hasher = new PasswordHasher<IdentityUser>();

            _modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "2e5317bb-05bf-4474-bc10-01b4eda8946a",
                    Name = "Pedro",
                    PhoneNumber = "(87) 3685-4252",
                    Apartment = "603",
                    Block = "A",
                    Email = "pedrorc2602@gmail.com",
                    EmailConfirmed = true,
                    UserName = "pedrorc2602@gmail.com",
                    NormalizedEmail = "PEDRORC2602@GMAIL.COM",
                    NormalizedUserName = "PEDRORC2602@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "123456")
                }
                );
            _modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string> {
                            RoleId= "2f77923c-6f14-4248-9d58-93819b5c4d94",
                            UserId= "2e5317bb-05bf-4474-bc10-01b4eda8946a"

                    }

                );
        }
    }
}
