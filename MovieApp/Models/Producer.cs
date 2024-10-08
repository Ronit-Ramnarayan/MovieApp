using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

        public Producer(int id, string profilePic, string fullName, string bio)
        {
            Id = id;
            ProfilePictureURL = profilePic;
            FullName = fullName;
            Bio = bio;
        }
    }
}
