using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }
        public static String? AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNolbl.Text = "Account Number: " + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposite deposite= new Deposite();
            deposite.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin changePin= new ChangePin();
            changePin.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw withdraw= new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MiniStatement miniSt = new MiniStatement();
            miniSt.Show();
            this.Hide();
        }
    }
}
