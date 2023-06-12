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
            optionsBuilder.UseSqlServer("Server=.; Database=LibraryDb; " +
                "Integrated Security=true");
        }
        public LibraryDbContext()
        {
            this.Database.Migrate();
        }
        public DbSet<Book> books { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<BorrowedBooks> BorrowedBooks { get; set; }
    }
}
