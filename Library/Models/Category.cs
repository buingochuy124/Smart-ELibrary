using System.Collections.Generic;

namespace Library.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DocumentCategory> DocumentCategories { get; set; }

    }
}