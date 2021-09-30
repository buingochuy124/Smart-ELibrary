namespace Library.Models
{
    public class UpdateRequest
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentAuthor { get; set; }
        public string Description { get; set; }
        //
        public User User { get; set; }
    }
}