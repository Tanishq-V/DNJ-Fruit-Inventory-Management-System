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
    public partial class supplier_order : Form
    {
        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter adapter;
        DataTable dt;

        public supplier_order()
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
        private void Getsupplier_order_id()
        {
            string s_orderid;
            string query = "select s_o_id from s_order order by s_o_id Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int idr = int.Parse(dr[0].ToString()) + 1;
                s_orderid = idr.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                s_orderid = ("00001");

            }
            else
            {
                s_orderid = ("00001");
            }
            con.Close();
            text_s_order_id.Text = s_orderid.ToString();
        }

        public void Getsupplier_id()
        {
            string supid;
            string query = "select s_id from s_order order by s_id Desc";
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
            text_supplier_id.Text = supid.ToString();
        }



        private void supplier_order_Load(object sender, EventArgs e)
        {
            Getsupplier_order_id();
            Getsupplier_id();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM s_order", con);
                    dt = new DataTable();

                    con.Open();

                    // Move the data retrieval code here
                    adapter.Fill(dt);
                    s_order_dataGridView.DataSource = dt;

                    // Also, fill the dataset here
                    this.s_order_TableAdapter.Fill(this.dnjsystemDataSet.s_order);
                    // Now, set the SelectionMode and assign the event handler
                    s_order_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    s_order_dataGridView.SelectionChanged += s_order_dataGridView_SelectionChanged;
                }

                // Now, the rest of your initialization code
                Getsupplier_order_id();
                Getsupplier_id();

                text_total.Text = " ";

            }


            catch (Exception)
            {
                // Handle exceptions here
            }

        }


        private void s_order_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (s_order_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = s_order_dataGridView.SelectedRows[0].Index;
                text_s_order_id.Text = s_order_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                text_supplier_id.Text = s_order_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(s_order_dataGridView.Rows[rowIndex].Cells[2].Value);
                text_total.Text = s_order_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }



        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.s_order' table. You can move, or remove it, as needed.
            this.s_order_TableAdapter.Fill(this.dnjsystemDataSet.s_order);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string s_order_id = text_s_order_id.Text;
            string supplier_id = text_supplier_id.Text;

            bool s_order_idExists = CheckIfIdExists(s_order_id);
            bool supplier_idExists = CheckIfIdExists(supplier_id);



            if (s_order_idExists)
            {
                if (text_s_order_id.Text != "" && text_supplier_id.Text != "" && text_total.Text != "" && dateTimePicker1.Text != "")
                {
                    string query = "UPDATE s_order SET s_id=@s_id, total=@total, date=@date WHERE s_o_id=@s_o_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@s_o_id", Convert.ToInt32(s_order_id));
                    cmd.Parameters.AddWithValue("@s_id", Convert.ToInt32(supplier_id));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt32(text_total.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    ClearTextBoxes();

                    MessageBox.Show("Data Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Getsupplier_order_id();
                    Getsupplier_id();
                }
                else
                {
                    MessageBox.Show("Please select row which you want to update", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (text_s_order_id.Text == "" || text_supplier_id.Text == "" || dateTimePicker1.Text == "" || text_total.Text == "")
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
            text_s_order_id.Text = "";
            text_supplier_id.Text = "";
            dateTimePicker1.Text = "";
            text_total.Text = "";
        }
        private void display_data()
        {
            string query = "SELECT * FROM s_order";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);
            s_order_dataGridView.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string order_id = text_s_order_id.Text;

            bool order_idExists = CheckIfIdExists(order_id, "s_o_id");
            bool supplier_idExists = CheckIfIdExists(text_supplier_id.Text, "s_id");

            if (order_idExists || supplier_idExists) 
            {
                MessageBox.Show("Order ID, already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (text_s_order_id.Text != "" && dateTimePicker1.Text != "" && text_total.Text != "")
                {
                    try
                    {
                        string query = "INSERT INTO s_order VALUES(@s_o_id, @s_id, @date,@total)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@s_o_id", Convert.ToInt32(text_s_order_id.Text));
                        cmd1.Parameters.AddWithValue("@s_id", Convert.ToInt32(text_supplier_id.Text));
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

        private void s_order_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (s_order_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = s_order_dataGridView.SelectedRows[0].Index;
                {
                    text_s_order_id.Text = s_order_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    text_supplier_id.Text = s_order_dataGridView.CurrentRow.Cells[1].Value.ToString();
                    dateTimePicker1.Text = s_order_dataGridView.CurrentRow.Cells[2].Value.ToString();
                    text_total.Text = s_order_dataGridView.CurrentRow.Cells[3].Value.ToString();

                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

            display_data();
            dateTimePicker1.Text = "";
            text_total.Text = "";

            Getsupplier_order_id();
            Getsupplier_id();

        }

        private void s_order_dataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
           
        }

        private void s_order_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SearchOrders(string searchTerm)
        {
            s_order_dataGridView.ClearSelection();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a valid search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in s_order_dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Check if the cell is not in the first column (ID column)
                    if (cell.ColumnIndex != 0 && cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                    {
                        row.Selected = true;
                        return; // Exit the method if a match is found
                    }
                    else if (cell.ColumnIndex == 0 && cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                    {
                        MessageBox.Show("Search in ID column is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method to prevent further search in ID column
                    }
                }
            }

            // Display a message if the search term is not found
            MessageBox.Show("No matching records found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void s_order_dataGridView_SelectionChanged_2(object sender, EventArgs e)
        {
            if (s_order_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = s_order_dataGridView.SelectedRows[0].Index;
                text_s_order_id.Text = s_order_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                text_supplier_id.Text = s_order_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(s_order_dataGridView.Rows[rowIndex].Cells[2].Value);
                text_total.Text = s_order_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            }
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
            s_order_dataGridView.DataSource = dv;
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {

            // Clear the filter and display the entire dataset in the DataGridView
            DataView dv = dt.DefaultView;
            dv.RowFilter = "";
            s_order_dataGridView.DataSource = dv;
        }

        private void total_Click(object sender, EventArgs e)
        {

            double total = 0;

            // Loop through each row in the DataGridView
            for (int i = 0; i < s_order_dataGridView.Rows.Count; i++)
            {
                // Check if the cell value in the 'Total' column is not null or empty
                if (s_order_dataGridView.Rows[i].Cells[3].Value != null && s_order_dataGridView.Rows[i].Cells[3].Value.ToString() != "")
                {
                    // Parse the cell value to a double and add it to the total
                    total += double.Parse(s_order_dataGridView.Rows[i].Cells[3].Value.ToString());
                }
            }

            // Display the total in the TextBox
            Cal_Total.Text = total.ToString();

            // Set the TextBox text to bold and red color
            Cal_Total.Font = new Font(Cal_Total.Font, FontStyle.Bold);
            Cal_Total.ForeColor = Color.Blue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

