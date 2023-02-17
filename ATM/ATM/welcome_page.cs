namespace ATM
{
    public partial class welcome_page : Form
    {
        public welcome_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int initial;
        private void timer1_Tick(object sender, EventArgs e)
        {
            initial += 1;
            progressBar.Value = initial;
            myProgress.Text = "" + initial;
            if(progressBar.Value == 100) 
            { 
                progressBar.Value = 0;
                timer1.Stop();
                Login login= new Login();
                this.Hide();
                login.Show();
            }
        }

        private void welcome_page_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}