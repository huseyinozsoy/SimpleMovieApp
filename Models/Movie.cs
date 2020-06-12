namespace SimpleMovieApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
    }
}