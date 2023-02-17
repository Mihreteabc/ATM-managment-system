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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");
        string accnum = Login.AccNumber;
        int balance;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNo='" + accnum + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = dt.Rows[0][0].ToString() + " Birr";
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (balance < 100)
            {
                MessageBox.Show("Insuficient balance");
            }
            else
            {
                int newbal = balance - 100;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Withdraw successful");
                    con.Close();
                    addTransactionFc1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (balance < 200)
            {
                MessageBox.Show("Insuficient balance");
            }
            else
            {
                int newbal = balance - 200;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Withdraw successful");
                    con.Close();
                    addTransactionFc2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (balance < 300)
            {
                MessageBox.Show("Insuficient balance");
            }
            else
            {
                int newbal = balance - 300;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Withdraw successful");
                    con.Close();
                    addTransactionFc3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (balance < 500)
            {
                MessageBox.Show("Insuficient balance");
            }
            else
            {
                int newbal = balance - 500;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Withdraw successful");
                    con.Close();
                    addTransactionFc4();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
            {
                MessageBox.Show("Insuficient balance");
            }
            else
            {
                int newbal = balance - 1000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Withdraw successful");
                    con.Close();
                    addTransactionFc5();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (balance < 2000)
            {
                MessageBox.Show("Insuficient balance");
            }
            else
            {
                int newbal = balance - 2000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance=" + newbal + "where AccNo='" + accnum + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Withdraw successful");
                    con.Close();
                    addTransactionFc6();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
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
        private void FastCash_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        private void addTransactionFc1()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + 100 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransactionFc2()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + 200 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransactionFc3()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + 300 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransactionFc4()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + 500 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransactionFc5()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + 1000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransactionFc6()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                String query = "insert into TransactionTable values('" + accnum + "','" + transactionType + "','" + 2000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
