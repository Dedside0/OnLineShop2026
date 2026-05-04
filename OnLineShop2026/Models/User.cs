namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public User( string lastName, string firstName, string email, string imagePath = "images/chel.jpg")
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            ImagePath = imagePath;
            Id = Guid.NewGuid();
        }
    }
}
