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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");
        string accnum = Login.AccNumber;
        int witBal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNo='" + accnum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Available balance "+dt.Rows[0][0].ToString() + " Birr";
            witBal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void addTransaction()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + withdrawAmtTb.Text + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int newbal;
        private void button1_Click(object sender, EventArgs e)
        {
            if (withdrawAmtTb.Text == "")
            {
                MessageBox.Show("Fill the field");
            }
            else if(Convert.ToInt32(withdrawAmtTb.Text) <= 0) 
            {
                MessageBox.Show("Enter valid amount");
            }
            else if(Convert.ToInt32(withdrawAmtTb.Text) > witBal)
            {
                MessageBox.Show("Inseficient balance");
            }
            else 
            {
                try
                {
                    newbal = witBal - Convert.ToInt32(withdrawAmtTb.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Withdraw successful");
                        con.Close();
                        addTransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
