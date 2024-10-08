using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieApp.Data.Enum;

namespace MovieApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

        public Movie(int id, string name, string description, double price, string imageURL, DateTime startDate, DateTime endDate, MovieCategory movieCategory, int cinemaId, Cinema cinema, int producerId, Producer producer)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageURL = imageURL;
            StartDate = startDate;
            EndDate = endDate;
            MovieCategory = movieCategory;
            CinemaId = cinemaId;
            Cinema = cinema;
            ProducerId = producerId;
            Producer = producer;
        }
    }
}
