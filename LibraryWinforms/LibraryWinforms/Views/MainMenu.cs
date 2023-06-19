namespace LibraryWinforms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterBook regbook = new RegisterBook();
            regbook.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBook issuebook = new IssueBook();
            issuebook.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateAClient create = new CreateAClient();
            create.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}