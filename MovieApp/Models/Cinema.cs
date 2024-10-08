using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
        public Cinema(int id, string logo, string name, string description)
        {
            Id = id;
            Logo = logo;
            Name = name;
            Description = description;
        }
    }
}
