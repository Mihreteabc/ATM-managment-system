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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");
        string accnum = Login.AccNumber;        
        private void button1_Click(object sender, EventArgs e)
        {
            if (newPinTb.Text == "" || confPinTb.Text == "")
            {
                MessageBox.Show("Fill The fields");
            }
            else if(newPinTb.Text != confPinTb.Text)
            {
                MessageBox.Show("Pin Doesn't match");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update AccountTable set Pin=" + newPinTb.Text + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin updated successfuly");
                    con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
