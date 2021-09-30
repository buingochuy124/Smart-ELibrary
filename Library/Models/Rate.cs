namespace Library.Models
{
    public class Rate
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string UserId { get; set; }
        public int Vote { get; set; }


        public User User { get; set; }
        public Document Document { get; set; }
    }
}