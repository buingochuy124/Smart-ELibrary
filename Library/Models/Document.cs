using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }  
        public DateTime Update { get; set; } = DateTime.Today;
        public string Description { get; set; }
        public double Price { get; set; }
        public Boolean status { get; set; }
        public string Image { get; set; }

        public ICollection<DocumentCategory> DocumentCategories;
        public ICollection<Chapter> Chapters;
        public ICollection<AccessRequest> AccessRequests { get; set; }
        public ICollection<Rate> Rates;
    }
}
