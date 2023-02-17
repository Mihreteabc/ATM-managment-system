using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNo='"+AccNumberlbl.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = dt.Rows[0][0].ToString()+" Birr";

            con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = Home.AccNumber;
            getbalance();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
