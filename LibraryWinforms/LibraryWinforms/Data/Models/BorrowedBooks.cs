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
        public int BookId { get; set; }
        public int ClientId { get; set; }   
        public virtual Book book { get; set; }
        public virtual Client client { get; set; }
     

    }
}
