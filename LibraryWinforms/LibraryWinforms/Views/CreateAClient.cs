using LibraryWinforms.Data.Models;
using LibraryWinforms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryWinforms.Business;

namespace LibraryWinforms
{
    public partial class CreateAClient : Form
    {
        public CreateAClient()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CreateAClient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibraryBusiness libraryBusiness = new LibraryBusiness();
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox3.Text;
            string phoneNum = textBox4.Text;
            int age = int.Parse(textBox5.Text);
            var password = textBox6.Text;
            Client client = new Client(firstName, lastName, email, age, phoneNum, password);
            libraryBusiness.AddClient(client);
            MessageBox.Show("The client was succsesfully added!");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CreateAClient_Load_1(object sender, EventArgs e)
        {

        }
    }
}
