using LibraryWinforms.Business;
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

namespace LibraryWinforms
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            int[] borrowedbooks;
            using (var db = new LibraryDbContext())
            {
                borrowedbooks = db.BorrowedBooks.Select(b => b.Id).ToArray();
            }
            foreach (var name in borrowedbooks)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new LibraryBusiness();
            int textIncmbBox = int.Parse(comboBox1.Text);
            db.DeleteBorrowBook(textIncmbBox);

        }
    }
}
