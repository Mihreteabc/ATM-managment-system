using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            account acc = new account();
            acc.Show();
            this.Hide();
        }
        public static String? AccNumber;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTable where AccNo='"+AccNoTb.Text+"' and Pin='"+PinTb.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = AccNoTb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
            con.Close();
        }
    }
}
