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
    public partial class customer_order : Form
    {
        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter adapter;
        DataTable dt;
        private object c_id;

        public customer_order()
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
            string query = "select c_o_id from customer_order order by c_o_id Desc";
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
        public void Getcustomer_id()
        {
            string supid;
            string query = "select c_id from customer_order order by c_id Desc";
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
            text_customer_id.Text = supid.ToString();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customer_order_Load(object sender, EventArgs e)
        {
            try
            {
                // Generate the customer order ID when the form loads
                Getcustomer_order_id();

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM customer_order", con);
                    dt = new DataTable();

                    con.Open();
                    adapter.Fill(dt);
                    con.Close();

                    // Bind the DataGridView directly to the DataTable
                    c_order_dataGridView.DataSource = dt;

                    // Set the SelectionMode and assign the event handler
                    c_order_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    c_order_dataGridView.SelectionChanged += c_order_dataGridView_SelectionChanged;
                }

                // Generate the customer ID when the form loads
                Getcustomer_id();

                // Now, the rest of your initialization code
                text_total.Text = " ";
            }
            catch (Exception)
            {
                // Handle exceptions here
            }
        
    }

    
    private void c_order_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.customer_order' table. You can move, or remove it, as needed.
            this.c_order_TableAdapter.Fill(this.dnjsystemDataSet.customer_order);

        }
        private void c_order_dataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (c_order_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = c_order_dataGridView.SelectedRows[0].Index;
                text_order_id.Text = c_order_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                text_customer_id.Text = c_order_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(c_order_dataGridView.Rows[rowIndex].Cells[2].Value);
                text_total.Text = c_order_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string c_o_id = text_order_id.Text;
            string customer_id = text_customer_id.Text;
           

            bool c_o_idExists = CheckIfIdExists(c_o_id);
            bool customer_idExists = CheckIfIdExists(customer_id);
           
            
            if (c_o_idExists)
            {
                if (text_order_id.Text != "" && text_customer_id.Text != "" && text_total.Text != "" && dateTimePicker1.Text != "")
                {
                    string query = "UPDATE customer_order SET c_id=@c_id, total=@total, date=@date WHERE c_o_id=@c_o_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@c_o_id", Convert.ToInt32(c_o_id));
                    cmd.Parameters.AddWithValue("@c_id", Convert.ToInt32(c_id));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt32(text_total.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    ClearTextBoxes();

                    MessageBox.Show("Data Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Getcustomer_order_id();
                    Getcustomer_id();
                }
                else
                {
                    MessageBox.Show("Please select row which you want to update", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (text_order_id.Text == "" || (text_customer_id.Text == "" || dateTimePicker1.Text == "" || text_total.Text == ""))
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

        private bool ClearTextBoxes(string id)
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
            text_customer_id.Text = "";
            text_order_id.Text = "";
            dateTimePicker1.Text = "";
            text_total.Text = "";
        }
        private void display_data()
        {

            string query = "SELECT * FROM customer_order";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);
            c_order_dataGridView.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string order_id = text_order_id.Text;
            
            bool order_idExists = CheckIfIdExists(order_id, "c_o_id");
            bool customer_idExists = CheckIfIdExists(text_customer_id.Text, "c_id");
 

            if (order_idExists || customer_idExists) 
            {
                MessageBox.Show("Order ID, already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((text_order_id.Text == "" || text_customer_id.Text == "" || dateTimePicker1.Text != "" && text_total.Text != ""))
                {
                    try
                    {
                        string query = "INSERT INTO customer_order VALUES(@c_o_id,@c_id, @date,@total)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@c_o_id", Convert.ToInt32(text_order_id.Text));
                        cmd1.Parameters.AddWithValue("@c_id", Convert.ToInt32(text_order_id.Text));
                        cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                        cmd1.Parameters.AddWithValue("@total", Convert.ToInt32(text_total.Text));


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

        private void text_order_id_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
        }

        private void text_order_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
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

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
              && !char.IsDigit(e.KeyChar)
              && !char.IsLetter(e.KeyChar)
              && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Please select date, typing anything is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
              && !char.IsDigit(e.KeyChar)
              && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Total cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
                MessageBox.Show("total can only contain one decimal point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_total.Focus();
            }
        }

        private void c_order_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (c_order_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = c_order_dataGridView.SelectedRows[0].Index;
                {
                    text_order_id.Text = c_order_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    text_customer_id.Text = c_order_dataGridView.CurrentRow.Cells[1].Value.ToString();
                    dateTimePicker1.Text = c_order_dataGridView.CurrentRow.Cells[2].Value.ToString();
                    text_total.Text = c_order_dataGridView.CurrentRow.Cells[3].Value.ToString();

                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display_data();
            dateTimePicker1.Text = "";
            text_total.Text = "";

            Getcustomer_order_id();
            Getcustomer_id();
        }
        private void btn_filter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1); // End of the selected day

            // Validate the selected date range
            if (toDate < fromDate)
            {
                MessageBox.Show("End date must be after the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filter the DataGridView based on the selected date range
            DataView dv = dt.DefaultView;
            string filterExpression = $"date >= #{fromDate.ToString("MM/dd/yyyy")}# AND date <= #{toDate.ToString("MM/dd/yyyy")}#";
            dv.RowFilter = filterExpression;
            c_order_dataGridView.DataSource = dv;
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            // Clear the filter and display the entire dataset in the DataGridView
            DataView dv = dt.DefaultView;
            dv.RowFilter = "";
            c_order_dataGridView.DataSource = dv;
        }

        private void total_Click(object sender, EventArgs e)
        {
            double total = 0;

            // Loop through each row in the DataGridView
            for (int i = 0; i < c_order_dataGridView.Rows.Count; i++)
            {
                // Check if the cell value in the 'Total' column is not null or empty
                if (c_order_dataGridView.Rows[i].Cells[3].Value != null && c_order_dataGridView.Rows[i].Cells[3].Value.ToString() != "")
                {
                    // Parse the cell value to a double and add it to the total
                    total += double.Parse(c_order_dataGridView.Rows[i].Cells[3].Value.ToString());
                }
            }

            // Display the total in the TextBox
            Cal_Total.Text = total.ToString();

            // Set the TextBox text to bold and red color
            Cal_Total.Font = new Font(Cal_Total.Font, FontStyle.Bold);
            Cal_Total.ForeColor = Color.Blue;
        }
    }
}

