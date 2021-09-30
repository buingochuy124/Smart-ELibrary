using System.Collections.Generic;

namespace Library.Models
{
    public class User
    {
        public string Role;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; }
        public string ProfilePicture { get; set; }

        public ICollection<UpdateRequest> UpdateRequests { get; set; }
        public ICollection<AccessRequest> AccessRequests { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}