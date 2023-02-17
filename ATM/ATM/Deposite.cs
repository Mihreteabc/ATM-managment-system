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
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;

namespace ATM
{
    public partial class Deposite : Form
    {
        public Deposite()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");
        string accnum = Login.AccNumber;
        private void addTransaction()
        {
            string transactionType = "Deposite";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + depositeAmountTb.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Account Created Succefully!");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(depositeAmountTb.Text==""||Convert.ToInt32(depositeAmountTb.Text) <= 0)
            {
                MessageBox.Show("Enter the amount you want to deposite ");
            }
            else
            {
                
                newbal = prevbal+Convert.ToInt32(depositeAmountTb.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money deposite successfuly");
                    con.Close();
                    addTransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }catch(Exception ex) 
                    {
                    MessageBox.Show(ex.Message);
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int prevbal, newbal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNo='" + accnum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            prevbal = Convert.ToInt32(dt.Rows[0][0].ToString());

            con.Close();
        }
        private void Deposite_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
