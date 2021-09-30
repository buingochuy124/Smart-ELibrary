using System;

namespace Library.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Nane { get; set; }


        public int DocumentId { get; set; }
        public string Content { get; set; }
        public Boolean IsUnlock { get; set; }



        public Document Document { get; set; }
    }
}