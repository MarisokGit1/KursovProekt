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
            DateTime date = DateTime.Now;
            string genre = textBox4.Text;
            int id = 0;
 
            Book book = new Book(id++,name,author,date,genre);
            db.books.Add(book);
            MessageBox.Show("Your book was successfully added!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
