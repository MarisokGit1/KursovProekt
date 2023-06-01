using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinforms.Data.Models
{
    public class BorrowedBooks
    {
        public int Id { get; set; }
        public Book book { get; set; }
        public Client client { get; set; }
     

    }
}
