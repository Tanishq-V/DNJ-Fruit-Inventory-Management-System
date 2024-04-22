using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DNJ_Inventory_System
{
    public partial class personal_details : Form
    {
        public personal_details()
        {
            InitializeComponent();
        }
        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // to disable copy paste
        {
            if ((keyData == k_copy) || (keyData == k_paste))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter adapter;
        DataTable dt;
        private object textBoxValueToSearch;

        public void Getsupplierid()
        {
            string supid;
            string query = "select s_id from s_personal_details order by s_id Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int idr = int.Parse(dr[0].ToString()) + 1;
                supid = idr.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                supid = ("00001");

            }
            else
            {
                supid = ("00001");
            }
            con.Close();
            text_id.Text = supid.ToString();
        }

        private void personal_details_Load(object sender, EventArgs e)
        {
           Getsupplierid(); // Get and display the supplier ID

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM s_personal_details", con);
                    dt = new DataTable(); // Assign to the class-level dt variable

                    con.Open();

                    // Move the data retrieval code here
                    adapter.Fill(dt);
                    s_personal_details_dataGridView.DataSource = dt;

                    // Also, fill the dataset here
                    this.s_personal_detailsTableAdapter.Fill(this.dnjsystemDataSet.s_personal_details);
                }

                Getsupplierid(); // Get and display the supplier ID
            }
            catch (Exception)
            {
                // Handle exceptions here
            }

        }


        // Method to clear all textboxes except ID
        private void ClearTextBoxesExceptID()
        {
            text_name.Text = "";
            text_state.Text = "";
            text_city.Text = "";
            text_district.Text = "";
            text_address.Text = "";
            text_contact.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.staff_details' table. You can move, or remove it, as needed.
            this.s_personal_detailsTableAdapter.Fill(this.dnjsystemDataSet.s_personal_details);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = text_id.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in s_personal_details_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    idExists = true;
                }
            }

            if (idExists)
            {
                if (text_id.Text != "" && text_name.Text != "" && text_state.Text != "" && text_city.Text != "" && text_district.Text != "" && text_contact.Text != "")
                {
                    string query = "UPDATE s_personal_details set s_name=@s_name,state=@state,city=@city,district=@district,address=@address,contact=@contact WHERE s_id=@s_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@s_id", Convert.ToInt32(text_id.Text));
                    cmd.Parameters.AddWithValue("@s_name", (text_name.Text));
                    cmd.Parameters.AddWithValue("@state", (text_state.Text));
                    cmd.Parameters.AddWithValue("@city", (text_city.Text));
                    cmd.Parameters.AddWithValue("@district", (text_district.Text));
                    cmd.Parameters.AddWithValue("@address", string.IsNullOrEmpty(text_address.Text) ? DBNull.Value : (object)text_address.Text); // Handle empty address
                    cmd.Parameters.AddWithValue("@contact", (text_contact.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    text_id.Text = " ";
                    text_name.Text = " ";
                    text_state.Text = "";
                    text_city.Text = " ";
                    text_district.Text = " ";
                    text_address.Text = " ";
                    text_contact.Text = " ";

                    MessageBox.Show("Data Successfully Updated", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Getsupplierid();
                }
                else
                {
                    MessageBox.Show("Please select row which you want to update", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ID Does Not Exist.");

            }
        }


        private void display_data()
        {
            string query = "SELECT * FROM s_personal_details";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            s_personal_details_dataGridView.DataSource = dt;
            con.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand comcheckid = new SqlCommand("select s_id from s_personal_details where s_id=" + text_id.Text + "", con);
            SqlDataAdapter sd = new SqlDataAdapter(comcheckid);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Id is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (text_id.Text != "" && text_name.Text != "" && text_state.Text != "" && text_city.Text != "" && text_district.Text != "" && text_contact.Text != "")
                {
                    // Validate contact number length and format
                    if (text_contact.TextLength != 10 || !text_contact.Text.StartsWith("6") && !text_contact.Text.StartsWith("7") && !text_contact.Text.StartsWith("8") && !text_contact.Text.StartsWith("9"))
                    {
                        MessageBox.Show("Contact number must be 10 digits and start with 6, 7, 8, or 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if contact number is not valid
                    }

                    // Clear error provider
                    errorProvider1.Clear();

                    // Insert data into database
                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO s_personal_details (s_id, s_name, state, city, district, address, contact) VALUES(@s_id, @s_name, @state, @city, @district, @address, @contact)", con);
                    cmd1.Parameters.AddWithValue("@s_id", text_id.Text);
                    cmd1.Parameters.AddWithValue("@s_name", text_name.Text);
                    cmd1.Parameters.AddWithValue("@state", text_state.Text);
                    cmd1.Parameters.AddWithValue("@city", text_city.Text);
                    cmd1.Parameters.AddWithValue("@district", text_district.Text);

                    // Check if address is provided, if not, set it to DBNull.Value
                    if (string.IsNullOrEmpty(text_address.Text))
                    {
                        cmd1.Parameters.AddWithValue("@address", DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@address", text_address.Text);
                    }

                    cmd1.Parameters.AddWithValue("@contact", text_contact.Text);

                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data saved Successfully.");
                    display_data();

                    text_name.Text = "";
                    text_state.Text = "";
                    text_city.Text = "";
                    text_district.Text = "";
                    text_address.Text = "";
                    text_contact.Text = "";
                    Getsupplierid();
                }
                else
                {
                    MessageBox.Show("Please Fill Empty Fields", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }





        private void text_contact_TextChanged(object sender, EventArgs e)
        {
            if (text_contact.TextLength == 10)
            {
                text_contact.ForeColor = Color.Black;
            }
            else
            {
                text_contact.ForeColor = Color.Red;

            }
        }
        private void text_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A phone Number cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_contact.Focus();
            }
        }
        private void text_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("A Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_name.Focus();
            }
        }
        private void text_id_TextChanged(object sender, EventArgs e)
        {
            text_name.Text = "";
        }
        private void text_supname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void text_supid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Supplier ID cannot contain Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_supname_TextChanged(object sender, EventArgs e)
        {

        }


        private void text_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_name.Focus();
            }
        }

        private void text_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_state.Focus();
            }
        }

        private void text_state_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_city.Focus();
            }
        }

        private void text_city_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_district.Focus();
            }
        }

        private void text_district_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_address.Focus();
            }
        }

        private void text_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_contact.Focus();
            }
        }
        private void text_name_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                      && !char.IsLetter(e.KeyChar)
                      && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_name.Focus();

            }
        }

        private void s_personal_details_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text_id.Text = s_personal_details_dataGridView.CurrentRow.Cells[0].Value.ToString();
            text_name.Text = s_personal_details_dataGridView.CurrentRow.Cells[1].Value.ToString();
            text_state.Text = s_personal_details_dataGridView.CurrentRow.Cells[2].Value.ToString();
            text_city.Text = s_personal_details_dataGridView.CurrentRow.Cells[3].Value.ToString();
            text_district.Text = s_personal_details_dataGridView.CurrentRow.Cells[4].Value.ToString();
            text_address.Text = s_personal_details_dataGridView.CurrentRow.Cells[5].Value.ToString();
            text_contact.Text = s_personal_details_dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display_data();
            text_name.Text = "";
            text_state.Text = "";
            text_city.Text = "";
            text_district.Text = "";
            text_address.Text = "";
            text_contact.Text = "";
            Getsupplierid();
        }

        private void text_contact_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[6789]\d*$");

            if (re.IsMatch(text_contact.Text.Trim()) == false || text_contact.Text.Length != 10)
            {
                errorProvider2.SetError(text_contact, "Invalid Mobile Number");
                text_contact.Focus();
            }
            else
            {
                errorProvider2.SetError(text_contact, string.Empty);
            }

        }

        private void s_personal_details_dataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void s_personal_details_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                      && !char.IsLetter(e.KeyChar)
                      && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A City/Village cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_city.Focus();

            }

        }

        private void text_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                      && !char.IsLetter(e.KeyChar)
                      && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A State cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_state.Focus();

            }
        }

        private void text_district_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                      && !char.IsLetter(e.KeyChar)
                      && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A District cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_district.Focus();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_state_TextChanged(object sender, EventArgs e)
        {

        }
        public void searchData(string valuetosearch)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void s_personal_details_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        // Method to clear textboxes
        private void ClearTextBoxes()
        {
            
            text_name.Text = "";
            text_state.Text = "";
            text_city.Text = "";
            text_district.Text = "";
            text_address.Text = "";
            text_contact.Text = "";
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from the TextBox
            string keyword = text_search.Text;

            // Check if the keyword is not empty
            if (!string.IsNullOrEmpty(keyword))
            {
                // Filter the DataGridView based on the keyword
                DataView dv = dt.DefaultView;
                string filterExpression = $"s_name LIKE '%{keyword}%' OR state LIKE '%{keyword}%' OR city LIKE '%{keyword}%' OR district LIKE '%{keyword}%' OR address LIKE '%{keyword}%' OR Convert(contact, 'System.String') LIKE '%{keyword}%'";
                Console.WriteLine("Filter Expression: " + filterExpression); // Debugging
                dv.RowFilter = filterExpression;
                Console.WriteLine("Filtered Rows Count: " + dv.Count); // Debugging
                s_personal_details_dataGridView.DataSource = dv;
            }
            else
            {
                // If the search TextBox is empty, show all data
                DataView dv = dt.DefaultView;
                dv.RowFilter = ""; // Clear any existing filter
                s_personal_details_dataGridView.DataSource = dv;
            }

            // Clear the textboxes
            ClearTextBoxes();
        }

        private void s_id_Click(object sender, EventArgs e)
        {

        }

        private void s_name_Click(object sender, EventArgs e)
        {

        }
    }
}








