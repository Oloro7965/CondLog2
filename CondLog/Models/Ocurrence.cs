namespace CondLog.Models
{
    public class Ocurrence
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; } = null!;
        public string PhoneNumber { get; private set; } = null!;
        public string Apartment { get; private set; } = null!;
        public string Block { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public DateTime Created { get; private set; }
        public string UserId { get; private set; }
        public User user { get; private set; }
    }
}
