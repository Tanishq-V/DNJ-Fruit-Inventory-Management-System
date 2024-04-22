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
    public partial class login_details : Form
    {
        public login_details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        private void login_details_Load(object sender, EventArgs e)
        {
            check_pass.CheckedChanged += new EventHandler(check_pass_CheckedChanged);
            MaximizeBox = false;
        }
        private void text_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void text_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)
               && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //con.Open();
            SqlCommand comcheckid = new SqlCommand("SELECT username FROM registration_details WHERE username='" + text_Username.Text + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(comcheckid);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (text_FullName.Text != "" && text_Username.Text != "" && text_password.Text != "")
                {
                    String str = @"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True";
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO registration_details (name,username,password) VALUES('" + text_FullName.Text + "','" + text_Username.Text + "','" + text_password.Text + "')", con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data saved Successfully.");
                    con.Close();
                    LoginForm l1 = new LoginForm();
                    l1.Show();
                    this.Hide();
                }
                else if (text_FullName.Text.Trim() == "" || text_Username.Text.Trim() == "" || text_password.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill all required fields.", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            text_password.PasswordChar = check_pass.Checked ? '\0' : '*';
        }
    }
    }

        
    

