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

namespace DNJ_Inventory_System
{
    public partial class LoginForm : Form
    {
        //connection establish//
        public LoginForm()
        {
            InitializeComponent();
        }
        string Conn = (@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");




        private void btn_2_Click(object sender, EventArgs e)
        {

        }
        private void btn_register_Click(object sender, EventArgs e)
        {

            login_details e1 = new login_details();
            e1.Show();
            this.Hide();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Subscribe to the CheckBox's CheckedChanged event
            check_pass.CheckedChanged += new EventHandler(check_pass_CheckedChanged);
            MaximizeBox = false;
        }
        private void text_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_password.Focus();
            }
        }

        private void text_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();
            }
        }
        private void btn_login_Enter(object sender, EventArgs e)
        {
            try
            {
                if (text_username.Text == "" && text_password.Text == "")
                {
                    MessageBox.Show("Please Enter Username and password");

                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    SqlCommand cmd = new SqlCommand("select * from registration_details where username=@username and password=@password", con);
                    cmd.Parameters.AddWithValue("@username", text_username.Text);
                    cmd.Parameters.AddWithValue("@password", text_password.Text);
                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successfull");
                        this.Hide();
                        Dashboard d1 = new Dashboard();
                        d1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = text_username.Text;
            string password = text_password.Text;

            if (username.Equals(username, StringComparison.Ordinal) &&
                password.Equals(password, StringComparison.Ordinal))
            {
                try
                {
                    if (text_username.Text == "" && text_password.Text == "")
                    {
                        MessageBox.Show("Please Enter the Username and Password");
                    }
                    else
                    {
                        string queryText = "select Count(*) from  registration_details" + "where username=@username and password=@password COLLATE SQL_Latin1_general_CP1_CS_AS";
                        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
                        SqlCommand cmd = new SqlCommand(queryText, cn);
                        {
                            cn.Open();
                            cmd.Parameters.AddWithValue("@username", text_username.Text);
                            cmd.Parameters.AddWithValue("@password", text_password.Text);
                            int result = Convert.ToInt32(cmd.ExecuteScalar());
                            if (result > 0)
                            {
                                MessageBox.Show("Login Successfull");
                                this.Hide();
                                Dashboard d1 = new Dashboard();
                                d1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username Or Password");
                            }
                            check_pass.Checked = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password");


            }

        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            text_password.PasswordChar = check_pass.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


    






