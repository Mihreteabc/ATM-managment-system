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
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");
        string accnum = Login.AccNumber;
        private void mini()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from TransactionTable where AccNo='" + accnum + "'", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniDVG.DataSource = ds.Tables[0];
            con.Close();
        }
        private void MiniStatement_Load(object sender, EventArgs e)
        {
            mini();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
