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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihreteab\Documents\dbATM.mdf;Integrated Security=True;Connect Timeout=30");

        private void button12_Click(object sender, EventArgs e)
        {
            int bal=0;
            if(AccNameTb.Text =="" || AccNoTb.Text =="" || FnameTb.Text=="" || PhoneTb.Text=="" || AddressTb.Text=="" || OccupationTb.Text=="" || PinTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "insert into AccountTable values('"+AccNoTb.Text+"','"+AccNameTb.Text+"','"+FnameTb.Text+"','"+DobDate.Value.Date+"','"+PhoneTb.Text+"','"+AddressTb.Text+"','"+EducationTb.SelectedItem.ToString()+"','"+OccupationTb.Text+"','"+PinTb.Text+"','"+bal+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Succefully!");
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Load(object sender, EventArgs e)
        {

        }
    }
}
