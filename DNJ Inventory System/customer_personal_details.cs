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

namespace DNJ_Inventory_System
{
    public partial class customer_personal_details : Form
    {
        public customer_personal_details()
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

        public void Getcustomerid()
        {
            string cusid;
            string query = "select c_id from c_personal_details order by c_id Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int idr = int.Parse(dr[0].ToString()) + 1;
                cusid = idr.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                cusid = ("00001");

            }
            else
            {
                cusid = ("00001");
            }
            con.Close();
            text_id.Text = cusid.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c_personal_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.c_personal_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dnjsystemDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.c_personal_details' table. You can move, or remove it, as needed.
            this.c_personal_detailsTableAdapter.Fill(this.dnjsystemDataSet.c_personal_details);

        }
        private void customer_personal_details_Load(object sender, EventArgs e)
        {
            Getcustomerid();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM c_personal_details", con);
                    dt = new DataTable();

                    con.Open();

                    //Move the data retrieval code here
                    adapter.Fill(dt);
                    c_personal_details_dataGridView.DataSource = dt;

                    //Also, fill the dataset here
                    this.c_personal_detailsTableAdapter.Fill(this.dnjsystemDataSet.c_personal_details);
                }

                //Now, the rest of your initialization code
                Getcustomerid();
               


            }

            catch (Exception)
            {
                // MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = text_id.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in c_personal_details_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    idExists = true;
                    break;
                }
            }

            if (idExists)
            {
                if (text_id.Text != "" && text_name.Text != "" && text_state.Text != "" && text_city.Text != "" && text_district.Text != "" && text_contact.Text != "")
                {
                    string query = "UPDATE c_personal_details SET c_name=@c_name, state=@state, city=@city, district=@district, address=@address, contact=@contact WHERE c_id=@c_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@c_id", Convert.ToInt32(text_id.Text));
                    cmd.Parameters.AddWithValue("@c_name", text_name.Text);
                    cmd.Parameters.AddWithValue("@state", text_state.Text);
                    cmd.Parameters.AddWithValue("@city", text_city.Text);
                    cmd.Parameters.AddWithValue("@district", text_district.Text);
                    cmd.Parameters.AddWithValue("@contact", text_contact.Text);

                    // Check if address is provided, if not, set it to NULL
                    if (string.IsNullOrEmpty(text_address.Text))
                    {
                        cmd.Parameters.AddWithValue("@address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address", text_address.Text);
                    }

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    display_data();

                    text_id.Text = "";
                    text_name.Text = "";
                    text_state.Text = "";
                    text_city.Text = "";
                    text_district.Text = "";
                    text_address.Text = "";
                    text_contact.Text = "";

                    MessageBox.Show("Data Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Getcustomerid();
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ID Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void display_data()
        {
            string query = "SELECT * FROM c_personal_details";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c_personal_details_dataGridView.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand comcheckid = new SqlCommand("select c_id from c_personal_details where c_id=" + text_id.Text + "", con);
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
                    // Validate contact number length
                    // Validate contact number
                    if (text_contact.TextLength != 10 || !text_contact.Text.StartsWith("6") && !text_contact.Text.StartsWith("7") && !text_contact.Text.StartsWith("8") && !text_contact.Text.StartsWith("9"))
                    {
                        MessageBox.Show("Contact number must be 10 digits and start with 6, 7, 8, or 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if contact number is not valid
                    }


                    // Clear error provider
                    errorProvider1.Clear();

                    // Prepare the SQL query with parameters
                    string query = "INSERT INTO c_personal_details (c_id, c_name, state, city, district, address, contact) VALUES (@c_id, @c_name, @state, @city, @district, @address, @contact)";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@c_id", text_id.Text);
                    cmd1.Parameters.AddWithValue("@c_name", text_name.Text);
                    cmd1.Parameters.AddWithValue("@state", text_state.Text);
                    cmd1.Parameters.AddWithValue("@city", text_city.Text);

                    // Check if district is provided, if not, set it to NULL
                    if (string.IsNullOrEmpty(text_district.Text))
                    {
                        cmd1.Parameters.AddWithValue("@district", DBNull.Value);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@district", text_district.Text);
                    }

                    // Check if address is provided, if not, set it to NULL
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

        }

        private void text_id_TextChanged(object sender, EventArgs e)
        {
            text_name.Text = "";
        }

        private void text_cusid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Customer ID cannot contain Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        }

        private void text_city_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void text_district_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void text_address_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void c_personal_details_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text_id.Text = c_personal_details_dataGridView.CurrentRow.Cells[0].Value.ToString();
            text_name.Text = c_personal_details_dataGridView.CurrentRow.Cells[1].Value.ToString();
            text_state.Text = c_personal_details_dataGridView.CurrentRow.Cells[2].Value.ToString();
            text_city.Text = c_personal_details_dataGridView.CurrentRow.Cells[3].Value.ToString();
            text_district.Text = c_personal_details_dataGridView.CurrentRow.Cells[4].Value.ToString();
            text_address.Text = c_personal_details_dataGridView.CurrentRow.Cells[5].Value.ToString();
            text_contact.Text = c_personal_details_dataGridView.CurrentRow.Cells[6].Value.ToString();
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
            Getcustomerid();
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
                string filterExpression = $"c_name LIKE '%{keyword}%' OR state LIKE '%{keyword}%' OR city LIKE '%{keyword}%' OR district LIKE '%{keyword}%' OR address LIKE '%{keyword}%' OR Convert(contact, 'System.String') LIKE '%{keyword}%'";
                Console.WriteLine("Filter Expression: " + filterExpression); // Debugging
                dv.RowFilter = filterExpression;
                Console.WriteLine("Filtered Rows Count: " + dv.Count); // Debugging
                c_personal_details_dataGridView.DataSource = dv;
            }
            else
            {
                // If the search TextBox is empty, show all data
                DataView dv = dt.DefaultView;
                dv.RowFilter = ""; // Clear any existing filter
                c_personal_details_dataGridView.DataSource = dv;
            }
            // Clear the textboxes
            ClearTextBoxes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void c_personal_details_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void text_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_city_KeyDown1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                text_district.Focus();
            }
        }

        private void text_district_KeyDown1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                text_address.Focus();
            }
        }

        private void text_address_KeyDown1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                text_contact.Focus();
            }
        }

        private void text_state_KeyDown1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                text_city.Focus();
            }
        }

        private void district_Click(object sender, EventArgs e)
        {

        }
    }
    }


