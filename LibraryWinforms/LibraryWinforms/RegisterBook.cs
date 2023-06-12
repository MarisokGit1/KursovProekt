using LibraryWinforms.Data;
using LibraryWinforms.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryWinforms
{
    public partial class RegisterBook : Form
    {
        public RegisterBook()
        {
            InitializeComponent();
        }

        private void RegisterBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryDbContext db = new LibraryDbContext();
            string name = textBox1.Text;
            string author = textBox2.Text;
            string date = textBox3.Text;
            DateTime dateTime = DateTime.Parse(date);
            string genre = textBox4.Text;
            Book book = new Book(name, author, dateTime, genre);
            db.books.Add(book);
            db.SaveChanges();
            MessageBox.Show("Your book was successfully added!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
