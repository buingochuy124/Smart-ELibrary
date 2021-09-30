using System;

namespace Library.Models
{
    public class AccessRequest
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public int DocumentId { get; set; }
        public DateTime UnlockDate { get; set; }
        public DateTime CloseDate { get; set; }
        public Boolean IsAccept { get; set; }


        public Document Document { get; set; }
        public User User { get; set; }
    }
}