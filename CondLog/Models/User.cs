using CondLog.Data;
using Microsoft.Extensions.WebEncoders.Testing;

namespace CondLog.Models
{
    public class User:ApplicationUser
    {
        //public Guid Id { get; private set; }
        public string Name { get; set; } = null!;
        //public string PhoneNumber { get; private set; } = null!;
        public string Apartment { get; set; } = null!;
        public string Block { get; set; } = null!;
        //public string Email { get; private set; } = null!;
        //public string Password { get; private set; } = null!;
        //public string teste { get; set; }
        public ICollection<Ocurrence> UserOcurrences { get; private set; } = new List<Ocurrence>();
        public bool IsDeleted { get; private set; }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
