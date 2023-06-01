using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinforms.Data.Models
{
    public class Book
    {
        public Book(int id, string name, string author, DateTime firstEdition, string genre)
        {
            Id = id;
            Name = name;
            Author = author;
            FirstEdition = firstEdition;
            Genre = genre;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime FirstEdition { get; set; }
        public string Genre { get; set; }
    }
}
