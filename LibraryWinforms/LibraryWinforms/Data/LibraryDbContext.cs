using LibraryWinforms.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWinforms.Data
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Library; " +
                "Integrated Security=true; TrustServerCertificate=true;");
        }
        public LibraryDbContext()
        {
           this.Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BorrowedBooks> BorrowedBooks { get; set; }
    }
}
