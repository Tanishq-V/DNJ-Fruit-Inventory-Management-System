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
    public partial class product_details : Form
    {
        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter adapter;
        DataTable dt;
        private string connectionString;
        private IEnumerable<string> allsupplierordernames;
        private object text_remaining_quantity;
        public product_details()
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
            string query = "select f_id from product_details order by f_id Desc";
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
            text_fruit_id.Text = orderid.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.product_details' table. You can move, or remove it, as needed.
            this.product_detailsTableAdapter.Fill(this.dnjsystemDataSet.product_details);
        }
        private void product_details_Load(object sender, EventArgs e)
        {
            Getcustomer_order_id();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM product_details", con);
                    dt = new DataTable();

                    con.Open();

                    // Move the data retrieval code here
                    adapter.Fill(dt);
                    product_details_dataGridView.DataSource = dt;

                    // Also, fill the dataset here
                    this.product_detailsTableAdapter.Fill(this.dnjsystemDataSet.product_details);
                    // Now, set the SelectionMode and assign the event handler
                    product_details_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    product_details_dataGridView.SelectionChanged += product_details_dataGridView_SelectionChanged;

                }

                // Now, the rest of your initialization code
                Getcustomer_order_id();

                text_fruit_name.Text = " ";
                text_variety.Text = " ";
                text_quantity.Text = " ";
               
            }
            catch (Exception)
            {
                // Handle exceptions here
            }
        }

        private void product_details_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (product_details_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = product_details_dataGridView.SelectedRows[0].Index;
                text_fruit_id.Text = product_details_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                text_fruit_name.Text = product_details_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                text_variety.Text = product_details_dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }
        
        private void btn_update_Click(object sender, EventArgs e)
        {
            string fruit_id = text_fruit_id.Text;

            bool fruit_idExists = CheckIfIdExists(fruit_id);
            if (fruit_idExists)
            {
                if (text_fruit_id.Text != "" && text_fruit_name.Text != "" && text_variety.Text != "" && text_quantity.Text !="")
                {
                    string query = "UPDATE product_details SET  f_name=@f_name, variety=@variety, quant=@quant WHERE f_id=@f_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f_id", Convert.ToInt32(fruit_id));
                    
                    cmd.Parameters.AddWithValue("@f_name", text_fruit_name.Text);
                    cmd.Parameters.AddWithValue("@variety", text_variety.Text);
                    cmd.Parameters.AddWithValue("@quant", Convert.ToInt32(text_quantity.Text));
                    

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
                if (text_fruit_id.Text ==  "" || text_fruit_name.Text == "" || text_variety.Text == "" || text_quantity.Text == "" )
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
            text_fruit_id.Text = "";
            text_fruit_name.Text = "";
            text_variety.Text = "";
            text_quantity.Text = "";
        }

        private void display_data()
        {
            string query = "SELECT * FROM product_details";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);
            product_details_dataGridView.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string order_id = text_fruit_id.Text;

            bool order_idExists = CheckIfIdExists(order_id, "f_id");

            if (order_idExists) 
            {
                MessageBox.Show("Order ID, already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (text_fruit_id.Text !=  "" && text_fruit_name.Text != "" && text_variety.Text != "" && text_quantity.Text != "")
                {
                    try
                    {
                        string query = "INSERT INTO product_details VALUES(@f_id,@f_name, @variety, @quant)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@f_id", Convert.ToInt32(text_fruit_id.Text));
                       
                        cmd1.Parameters.AddWithValue("@f_name", text_fruit_name.Text);
                        cmd1.Parameters.AddWithValue("@variety", text_variety.Text);
                        cmd1.Parameters.AddWithValue("@quant", Convert.ToInt32(text_quantity.Text));
                        

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

        private void product_details_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (product_details_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = product_details_dataGridView.SelectedRows[0].Index;
                {

                    text_fruit_id.Text = product_details_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    text_fruit_name.Text = product_details_dataGridView.CurrentRow.Cells[1].Value.ToString();
                    text_variety.Text = product_details_dataGridView.CurrentRow.Cells[2].Value.ToString();
                    text_quantity.Text = product_details_dataGridView.CurrentRow.Cells[3].Value.ToString();
                   
                }
            }
    }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display_data();
            
            text_fruit_name.Text = "";
            text_variety.Text = "";
            text_quantity.Text = "";
         
            Getcustomer_order_id();
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
                string filterExpression = $"f_name LIKE '%{keyword}%' OR variety LIKE '%{keyword}%' OR Convert(quant, 'System.String') LIKE '%{keyword}%'";
                Console.WriteLine("Filter Expression: " + filterExpression); // Debugging
                dv.RowFilter = filterExpression;
                Console.WriteLine("Filtered Rows Count: " + dv.Count); // Debugging
                product_details_dataGridView.DataSource = dv;
            }
            else
            {
                // If the search TextBox is empty, show all data
                DataView dv = dt.DefaultView;
                dv.RowFilter = ""; // Clear any existing filter
                product_details_dataGridView.DataSource = dv;
            }
        }
        private void text_fruit_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_fruit_name.Focus();
            }
        }

        private void text_fruit_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_variety.Focus();
            }
        }

        private void text_quantity_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void text_variety_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_quantity.Focus();
            }
        }

        private void text_fruit_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Fruit ID cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_fruit_name.Focus();
            }
        }

        private void text_fruit_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                                  && !char.IsLetter(e.KeyChar)
                                  && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Fruit Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
    }
    

