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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            int clientId = 0;
            string firstName = textBox1.Text;
            using ( var dbContext = new LibraryDbContext())
            {

                clientId = dbContext.Clients.FirstOrDefault(b => b.FirstName == firstName).Id;

            }
            DateTime returnedOn = DateTime.Now;
            int borrowedBooksId = int.Parse(comboBox1.Text);
           /* var returnbook = new ReturnedBook(borrowedBooksId, returnedOn, clientId);*/
        /*    db.ReturnBook(returnbook);*/


        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }
    }
}
