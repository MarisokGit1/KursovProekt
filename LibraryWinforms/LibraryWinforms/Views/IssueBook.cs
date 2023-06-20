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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* LibraryBusiness libraryBusiness = new LibraryBusiness();
            string bookname;
            int bookid = 0;
            int clientid = 0;
            DateTime borrowedOn = DateTime.Now;
            BorrowedBooks borrowedBook = new BorrowedBooks(bookid, borrowedOn, clientid);
            libraryBusiness.IssueBook(borrowedBook);*/
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("Select Name from Books", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();



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
    }
}

