﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinforms.Data.Models
{
    public class BorrowedBooks
    {
        public BorrowedBooks(int bookId, DateTime borrowedOn, int clientId)
        {
            BookId = bookId;
            this.BorrowedOn = borrowedOn;
            ClientId = clientId;
        }

        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedOn { get; set; }
        public int ClientId { get; set; }   
        public virtual Book book { get; set; }
        public virtual Client client { get; set; }
     

    }
}
