using LibraryWinforms.Business;
using LibraryWinforms.Data;
using LibraryWinforms.Data.Models;
using Microsoft.Data.SqlClient;
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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
            string[] books;
            using (var db = new LibraryDbContext())
            {
                books = db.Books.Select(b => b.Name).ToArray();
            }
            foreach (var name in books)
            {
                comboBox1.Items.Add(name);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LibraryBusiness libraryBusiness = new LibraryBusiness();
            int bookid = 0;
            string givenName = comboBox1.Text;
            using (var db = new LibraryDbContext())
            {
                //var books = from b in db.Books
                //            where b.Name.Equals(givenName)
                //            select b;
                //  bookid = db.Books.FirstOrDefault(b => b.Name==givenName).Id;
                bookid = db.Books.FirstOrDefault(b => b.Name == givenName).Id;

            }


            int clientId = 0;
            string firstName = textBox3.Text;
            using (var db = new LibraryDbContext())
            {

                clientId = db.Clients.FirstOrDefault(b => b.FirstName == firstName).Id;

            }
            DateTime borrowedOn = DateTime.Now;
            BorrowedBooks borrowedBook = new BorrowedBooks(bookid, borrowedOn, clientId);
            libraryBusiness.IssueBook(borrowedBook);
            MessageBox.Show("You got the book!!");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {


            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-SIUDAKR\\SQLEXPRESS; database=Library; integrated security=True; TrustServerCertificate=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select name from books", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();*/



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load_2(object sender, EventArgs e)
        {

        }
    }
}

