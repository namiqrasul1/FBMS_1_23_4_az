using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Book
    {
        public Book(int id, string name, string author, string genre)
        {
            Id = id;
            Name = name;
            Author = author;
            Genre = genre;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Some? Some { get; set; }


        public override string ToString() => $"{Id} {Name} {Author} {Genre}";
    }
}
