using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public Actor(int id, string profilePic, string fullName, string bio)
        {
            Id = id;
            ProfilePictureURL = profilePic;
            FullName = fullName;
            Bio = bio;
        }
    }
}
