using LibraryWinforms.Data;
using LibraryWinforms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinforms.Business
{
    public class LibraryBusiness
    {
        private LibraryDbContext dbContext;
        //Create
      /*  public void ReturnBook(ReturnedBook returnedBook)
        {
            using (dbContext = new LibraryDbContext())
            {
                dbContext.ReturnedBooks.Add(returnedBook);
                dbContext.SaveChanges();
            }
        }*/
        public void RegisterBook(Book book)
        {
            using (dbContext = new LibraryDbContext())
            {
                dbContext.Books.Add(book);
                dbContext.SaveChanges();
            }
        }
        public void AddClient(Client client)
        {
            using (dbContext = new LibraryDbContext())
            {
                dbContext.Clients.Add(client);
                dbContext.SaveChanges();
            }
        }
        public void IssueBook(BorrowedBooks borrowedBooks)
        {
            using (dbContext = new LibraryDbContext())
            {
                dbContext.BorrowedBooks.Add(borrowedBooks);
                dbContext.SaveChanges();
            }
        }
        //Read
        public List<Book> GetAllBooks()
        {
            using (dbContext = new LibraryDbContext())
            {
                return dbContext.Books.ToList();
            }
        }
        public Book GetBook(int id)
        {
            using (dbContext = new LibraryDbContext())
            {
                return dbContext.Books.Find(id);
            }
        }
        public List<Client> GetAllClients()
        {
            using (dbContext = new LibraryDbContext())
            {
                return dbContext.Clients.ToList();
            }
        }
        public Client GetClient(int id)
        {
            using (dbContext = new LibraryDbContext())
            {
                return dbContext.Clients.Find(id);
            }
        }
       //Update
        public void UpdateBook(Book book)
        {
            using (dbContext = new LibraryDbContext())
            {
                var item = dbContext.Books.Find(book.Id);
                if (item != null)
                {
                    dbContext.Entry(item).CurrentValues.SetValues(book);
                    dbContext.SaveChanges();
                }
            }
        }
        public void UpdateClient(Client client)
        {
            using (dbContext = new LibraryDbContext())
            {
                var item = dbContext.Clients.Find(client.Id);
                if (item != null)
                {
                    dbContext.Entry(item).CurrentValues.SetValues(client);
                    dbContext.SaveChanges();
                }
            }
        }
        //Delete
        public void DeleteBook(int id)
        {
            using (dbContext = new LibraryDbContext())
            {
                var book = dbContext.Books.Find(id);
                if (book != null)
                {
                    dbContext.Books.Remove(book);
                    dbContext.SaveChanges();

                }
            }
        }
        public void DeleteClient(int id)
        {
            using (dbContext = new LibraryDbContext())
            {
                var client = dbContext.Clients.Find(id);
                if (client != null)
                {
                    dbContext.Clients.Remove(client);
                    dbContext.SaveChanges();
                    
                }
            }
        }

        public void DeleteBorrowBook(int id)
        {
            using (dbContext = new LibraryDbContext())
            {
                var borrowedBooks = dbContext.BorrowedBooks.Find(id);
                if (borrowedBooks != null)
                {
                    dbContext.BorrowedBooks.Remove(borrowedBooks);
                    dbContext.SaveChanges();

                }
            }
        }

    }
}
