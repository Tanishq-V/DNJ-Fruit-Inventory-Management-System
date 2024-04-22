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
    public partial class customer_order_details : Form
    {

        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter adapter;
        DataTable dt;
        private string connectionString;
        private IEnumerable<string> allsupplierordernames;


        public customer_order_details()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
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

        private void Getcustomer_order_id()
        {
            string orderid;
            string query = "select o_id from customer_order_details order by o_id Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int idr = int.Parse(dr[0].ToString()) + 1;
                orderid = idr.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                orderid = ("00001");

            }
            else
            {
                orderid = ("00001");
            }
            con.Close();
            text_order_id.Text = orderid.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.customer_order_details' table. You can move, or remove it, as needed.
            this.c_order_detailsTableAdapter.Fill(this.dnjsystemDataSet.customer_order_details);
        }
        private void customer_order_details_Load(object sender, EventArgs e)
        {
            try
            {
                // Generate the customer order ID when the form loads
                Getcustomer_order_id();

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM customer_order_details", con);
                    dt = new DataTable();

                    con.Open();

                    // Move the data retrieval code here
                    adapter.Fill(dt);
                    c_order_details_dataGridView.DataSource = dt;

                    // Also, fill the dataset here
                    this.c_order_detailsTableAdapter.Fill(this.dnjsystemDataSet.customer_order_details);
                    // Now, set the SelectionMode and assign the event handler
                    c_order_details_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    c_order_details_dataGridView.SelectionChanged += c_order_details_dataGridView_SelectionChanged;

                }

                // Now, the rest of your initialization code
                Getcustomer_order_id();
                
            }
            catch (Exception)
            {
                // Handle exceptions here
            }
        }

        private void c_order_details_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string order_id = text_order_id.Text;

            bool order_idExists = CheckIfIdExists(order_id);
            if (order_idExists)
            {
                if (text_order_id.Text != "" && text_customer_name.Text != "" && text_fruit_name.Text != "" && text_variety.Text != "" && text_quantity.Text != "" && text_unit.Text != "" && text_price.Text != "")
                {
                    string query = "UPDATE customer_order_details SET c_name=@c_name, f_name=@f_name, variety=@variety, quant=@quant, unit=@unit, price=@price WHERE o_id=@o_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@o_id", Convert.ToInt32(order_id));
                    cmd.Parameters.AddWithValue("@c_name", text_customer_name.Text);
                    cmd.Parameters.AddWithValue("@f_name", text_fruit_name.Text);
                    cmd.Parameters.AddWithValue("@variety", text_variety.Text);
                    cmd.Parameters.AddWithValue("@quant", Convert.ToInt32(text_quantity.Text));
                    cmd.Parameters.AddWithValue("@unit", (text_unit.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(text_price.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    ClearTextBoxes();

                    MessageBox.Show("Data Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Getcustomer_order_id();
                }
                else
                {
                    MessageBox.Show("Please select row which you want to update", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (text_order_id.Text == "" || text_customer_name.Text == "" || text_fruit_name.Text == "" || text_variety.Text == "" || text_quantity.Text == "" || text_unit.Text == "" || text_price.Text == "")
                {
                    MessageBox.Show("Please fill in all the required fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Order ID, does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool CheckIfIdExists(string id)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void ClearTextBoxes()
        {
            text_order_id.Text = "";
            text_customer_name.Text = "";
            text_fruit_name.Text = "";
            text_variety.Text = "";
            text_quantity.Text = "";
            text_unit.Text = "";
            text_price.Text = "";
        }

        private void display_data()
        {
            string query = "SELECT * FROM customer_order_details";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);
            c_order_details_dataGridView.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string order_id = text_order_id.Text;

            bool order_idExists = CheckIfIdExists(order_id, "o_id");

            if (order_idExists) 
            {
                MessageBox.Show("Order ID, already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (text_order_id.Text != "" && text_customer_name.Text != "" && text_fruit_name.Text != "" && text_variety.Text != "" && text_quantity.Text != "" && text_price.Text != "")
                {
                    try
                    {
                        string query = "INSERT INTO customer_order_details VALUES(@o_id, @c_name,@f_name, @variety, @quant, @unit, @price)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@o_id", Convert.ToInt32(text_order_id.Text));
                        cmd1.Parameters.AddWithValue("@c_name", text_customer_name.Text);
                        cmd1.Parameters.AddWithValue("@f_name", text_fruit_name.Text);
                        cmd1.Parameters.AddWithValue("@variety", text_variety.Text);
                        cmd1.Parameters.AddWithValue("@quant", Convert.ToInt32(text_quantity.Text));
                        cmd1.Parameters.AddWithValue("@unit", text_unit.Text);
                        cmd1.Parameters.AddWithValue("@price", Convert.ToInt32(text_price.Text));

                        con.Open();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Data saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        display_data();
                        ClearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Empty Fields", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool CheckIfIdExists(string id, string columnName)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[columnName].ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void text_fruit_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsLetter(e.KeyChar)
                     && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Fruit Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_fruit_name.Focus();

            }
        }

        private void text_order_id_TextChanged(object sender, EventArgs e)
        {
            text_fruit_name.Text = "";
        }

        private void text_order_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Order ID cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_order_id_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                text_customer_name.Focus();
            }
        }

        private void text_fruit_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_variety.Focus();

            }
        }

        private void text_variety_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_quantity.Focus();
            }
        }

        private void text_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_unit.Focus();
            }
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Price cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_quantity.Focus();
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains("."))
            {
                e.Handled = true;
                MessageBox.Show("price can only contain one decimal point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_quantity.Focus();
            }
        }

        private void c_order_details_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (c_order_details_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = c_order_details_dataGridView.SelectedRows[0].Index;
                {
                    text_order_id.Text = c_order_details_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    text_customer_name.Text = c_order_details_dataGridView.CurrentRow.Cells[1].Value.ToString();
                    text_fruit_name.Text = c_order_details_dataGridView.CurrentRow.Cells[2].Value.ToString();
                    text_variety.Text = c_order_details_dataGridView.CurrentRow.Cells[3].Value.ToString();
                    text_quantity.Text = c_order_details_dataGridView.CurrentRow.Cells[4].Value.ToString();
                    text_unit.Text = c_order_details_dataGridView.CurrentRow.Cells[5].Value.ToString();
                    text_price.Text = c_order_details_dataGridView.CurrentRow.Cells[6].Value.ToString();
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display_data();
            text_customer_name.Text = "";
            text_fruit_name.Text = "";
            text_variety.Text = "";
            text_quantity.Text = "";
            text_unit.Text = "";
            text_price.Text = "";
            Getcustomer_order_id();
        }

        private void text_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsLetter(e.KeyChar)
               && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unit cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_unit.Focus();
            }
        }

        private void text_unit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_price.Focus();
            }
        }

        private void c_order_details_dataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (c_order_details_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = c_order_details_dataGridView.SelectedRows[0].Index;
                text_order_id.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                text_customer_name.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                text_fruit_name.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                text_variety.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                text_quantity.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
                text_unit.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[5].Value.ToString();
                text_price.Text = c_order_details_dataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            }
        }

        private void text_variety_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetter(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Variety cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_variety.Focus();
            }
        }

        private void text_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Quantity cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_quantity.Focus();
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains("."))
            {
                e.Handled = true;
                MessageBox.Show("Quantity can only contain one decimal point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_quantity.Focus();
            }
        }

        private void text_customer_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                                  && !char.IsLetter(e.KeyChar)
                                  && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A suppliers Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_customer_name.Focus();

            }
        }

        private void text_customer_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_fruit_name.Focus();
            }
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
                string filterExpression = $"c_name LIKE '%{keyword}%' OR f_name LIKE '%{keyword}%' OR variety LIKE '%{keyword}%' OR Convert(quant, 'System.String') LIKE '%{keyword}%' OR unit LIKE '%{keyword}%' OR Convert(price, 'System.String') LIKE '%{keyword}%'";
                Console.WriteLine("Filter Expression: " + filterExpression); // Debugging
                dv.RowFilter = filterExpression;
                Console.WriteLine("Filtered Rows Count: " + dv.Count); // Debugging
                c_order_details_dataGridView.DataSource = dv;
            }
            else
            {
                // If the search TextBox is empty, show all data
                DataView dv = dt.DefaultView;
                dv.RowFilter = ""; // Clear any existing filter
                c_order_details_dataGridView.DataSource = dv;
            }

        }

        private void text_customer_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void c_order_details_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

   

