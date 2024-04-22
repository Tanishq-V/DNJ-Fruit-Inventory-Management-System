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
    public partial class supplier_payment_details : Form
    {
        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter adapter;
        DataTable dt;
        private string connectionString;
        private IEnumerable<string> allsupplierordernames;


        public supplier_payment_details()
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
        private void Getsupplier_payment_id()
        {
            string orderid;
            string query = "select p_id from supplier_payment_details order by p_id Desc";
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
            text_payment_id.Text = orderid.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnjsystemDataSet.supplier_payment_details' table. You can move, or remove it, as needed.
            this.s_payment_detailsTableAdapter.Fill(this.dnjsystemDataSet.supplier_payment_details);
        }
        private void supplier_payment_details_Load(object sender, EventArgs e)
        {
            Getsupplier_payment_id();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7O11E2P5\SQLEXPRESS;Initial Catalog=dnjsystem;User ID=tanya;Password=1234;Encrypt=True;TrustServerCertificate=True"))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM supplier_payment_details", con);
                    dt = new DataTable();

                    con.Open();

                    // Move the data retrieval code here
                    adapter.Fill(dt);
                    s_payment_details_dataGridView.DataSource = dt;

                    // Also, fill the dataset here
                    this.s_payment_detailsTableAdapter.Fill(this.dnjsystemDataSet.supplier_payment_details);
                    // Now, set the SelectionMode and assign the event handler
                    s_payment_details_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    s_payment_details_dataGridView.SelectionChanged += s_payment_details_dataGridView_SelectionChanged;

                }

                // Now, the rest of your initialization code
                Getsupplier_payment_id();

                text_supplier_name.Text = " ";
                dateTimePicker.Text = " ";
                text_amount.Text = " ";
                text_transaction_mode.Text = " ";
                text_account_holder_name.Text = " ";
                text_payment_number.Text = " ";
            }
            catch (Exception)
            {
                // Handle exceptions here
            }
        }

        private void s_payment_details_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string p_id = text_payment_id.Text;

            bool p_idExists = CheckIfIdExists(p_id);



            if (p_idExists)
            {
                if (text_payment_id.Text != "" && text_supplier_name.Text != "" && dateTimePicker.Text != "" && text_amount.Text != "" && text_transaction_mode.Text != "" && text_account_holder_name.Text != "" && text_payment_number.Text != "")
                {
                    string query = "UPDATE supplier_payment_details SET s_name=@s_name, date=@date, amount=@amount, transaction_mode=@transaction_mode, account_holder_name=@account_holder_name,contact=@contact WHERE p_id=@p_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@p_id", Convert.ToInt32(p_id));
                    cmd.Parameters.AddWithValue("@s_name", text_supplier_name.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@amount",(text_amount.Text));
                    cmd.Parameters.AddWithValue("@transaction_mode", text_transaction_mode.Text);
                    cmd.Parameters.AddWithValue("@account_holder_name", (text_account_holder_name.Text));
                    cmd.Parameters.AddWithValue("@contact",(text_payment_number.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    ClearTextBoxes();

                    MessageBox.Show("Data Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Getsupplier_payment_id();
                  
                }
                else
                {
                    MessageBox.Show("Please select row which you want to update", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (text_payment_id.Text == "" || text_supplier_name.Text == "" || dateTimePicker.Text == "" || text_transaction_mode.Text == "" || text_amount.Text == "" || text_account_holder_name.Text == "" || text_payment_number.Text == "")
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
            text_payment_id.Text = "";
            text_supplier_name.Text = " ";
            dateTimePicker.Text = "";
            text_amount.Text = " ";
            text_transaction_mode.Text = " ";
            text_account_holder_name.Text = " ";
            text_payment_number.Text = " ";

        }
        private void display_data()
        {
            string query = "SELECT * FROM supplier_payment_details";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            dt.Clear();
            da.Fill(dt);
            s_payment_details_dataGridView.DataSource = dt;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string p_id = text_payment_id.Text;

            bool p_idExists = CheckIfIdExists(p_id, "p_id");

            if (p_idExists)
            {
                MessageBox.Show("Order ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (text_payment_id.Text != "" && text_supplier_name.Text != "" && dateTimePicker.Text != "" && text_amount.Text != "" && text_transaction_mode.Text != "")
                {
                    try
                    {
                        string query = "INSERT INTO supplier_payment_details VALUES(@p_id, @s_name,@date, @amount, @transaction_mode, @account_holder_name, @contact)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@p_id", Convert.ToInt32(p_id));
                        cmd1.Parameters.AddWithValue("@s_name", text_supplier_name.Text);
                        cmd1.Parameters.AddWithValue("@date", dateTimePicker.Text);
                        cmd1.Parameters.AddWithValue("@amount", Convert.ToInt32(text_amount.Text));
                        cmd1.Parameters.AddWithValue("@transaction_mode", text_transaction_mode.Text);

                        // Check if the transaction mode is "Online"
                        if (text_transaction_mode.Text == "online")
                        {
                            // Check if both contact number and account holder name are provided
                            if (string.IsNullOrWhiteSpace(text_account_holder_name.Text) || string.IsNullOrWhiteSpace(text_payment_number.Text))
                            {
                                MessageBox.Show("Please provide both account holder name and contact number for online transaction", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; // Exit the method, preventing further execution
                            }

                            cmd1.Parameters.AddWithValue("@account_holder_name", text_account_holder_name.Text);
                            cmd1.Parameters.AddWithValue("@contact", text_payment_number.Text);
                        }
                        else
                        {
                            // For Cash mode, set these parameters as null
                            cmd1.Parameters.AddWithValue("@account_holder_name", DBNull.Value);
                            cmd1.Parameters.AddWithValue("@contact", DBNull.Value);
                        }

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
        private void text_payment_id_TextChanged(object sender, EventArgs e)
        {
            text_supplier_name.Text = "";
        }

        private void text_payment_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Order ID cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_payment_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_supplier_name.Focus();
            }
        }

        private void s_payment_details_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (s_payment_details_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = s_payment_details_dataGridView.SelectedRows[0].Index;
                {
                    text_payment_id.Text = s_payment_details_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    text_supplier_name.Text = s_payment_details_dataGridView.CurrentRow.Cells[1].Value.ToString();
                    dateTimePicker.Text = s_payment_details_dataGridView.CurrentRow.Cells[2].Value.ToString();
                    text_amount.Text = s_payment_details_dataGridView.CurrentRow.Cells[3].Value.ToString();
                    text_transaction_mode.Text = s_payment_details_dataGridView.CurrentRow.Cells[4].Value.ToString();
                    text_account_holder_name.Text = s_payment_details_dataGridView.CurrentRow.Cells[5].Value.ToString();
                    text_payment_number.Text = s_payment_details_dataGridView.CurrentRow.Cells[6].Value.ToString();
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
                display_data();
                text_supplier_name.Text = " ";
                dateTimePicker.Text = "";
                text_amount.Text = " ";
                text_transaction_mode.Text = " ";
                text_account_holder_name.Text = " ";
                text_payment_number.Text = " ";
                Getsupplier_payment_id();
        }

        private void s_payment_details_dataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (s_payment_details_dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = s_payment_details_dataGridView.SelectedRows[0].Index;
                text_payment_id.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                text_supplier_name.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                dateTimePicker.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                text_amount.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                text_transaction_mode.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
                text_account_holder_name.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[5].Value.ToString();
                text_payment_number.Text = s_payment_details_dataGridView.Rows[rowIndex].Cells[6].Value.ToString();

            }
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            /// Get the search keyword from the TextBox
            string keyword = text_search.Text;

            // Check if the keyword is not empty
            if (!string.IsNullOrEmpty(keyword))
            {
                // Filter the DataGridView based on the keyword
                DataView dv = dt.DefaultView;
                string filterExpression = $"s_name LIKE '%{keyword}%' OR Convert(date, 'System.String') LIKE '%{keyword}%' OR Convert(amount, 'System.String') LIKE '%{keyword}%' OR transaction_mode LIKE '%{keyword}%' OR account_holder_name LIKE '%{keyword}%' OR Convert(contact, 'System.String') LIKE '%{keyword}%'";
                Console.WriteLine("Filter Expression: " + filterExpression); // Debugging
                dv.RowFilter = filterExpression;
                Console.WriteLine("Filtered Rows Count: " + dv.Count); // Debugging
                s_payment_details_dataGridView.DataSource = dv;
            }
            else
            {
                // If the search TextBox is empty, show all data
                DataView dv = dt.DefaultView;
                dv.RowFilter = ""; // Clear any existing filter
                s_payment_details_dataGridView.DataSource = dv;
            }

        }
        private bool IsFormValid()
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(text_supplier_name.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker.Text) ||
                string.IsNullOrWhiteSpace(text_amount.Text) ||
                string.IsNullOrWhiteSpace(text_transaction_mode.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // If the transaction mode is "Online", check if account holder name and contact are provided
            if (IsOnlineMode())
            {
                if (string.IsNullOrWhiteSpace(text_account_holder_name.Text) || string.IsNullOrWhiteSpace(text_payment_number.Text))
                {
                    MessageBox.Show("Please provide both account holder name and contact number for online transaction.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Validate contact number length (assuming it should be 10 digits)
                if (text_payment_number.Text.Length != 10)
                {
                    MessageBox.Show("Please enter a valid 10-digit contact number.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private bool IsOnlineMode()
        {
            // Check if the transaction mode is "Online"
            return text_transaction_mode.Text.ToLower() == "online";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the form is valid
            if (!IsFormValid())
            {
                return;
            }

            // If form is valid, proceed with print preview
            MprintPreviewDialog.Document = MprintDocument;
            MprintPreviewDialog.ShowDialog();
        }


        private void MprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("DNJ MERCHANT AND COMMISSION AGENT  ", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.DarkRed, new Point(40, 50));
            e.Graphics.DrawString("INVOICE ", new Font("Times New Roman", 50, FontStyle.Bold), Brushes.Black, new Point(250, 150));

            e.Graphics.DrawString("Supplier Name : " + text_supplier_name.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(25, 300));
                e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(550, 300));

            String dashline = "___________________________________________________________________________________________________________________";
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Bold), Brushes.DarkRed, new Point(0, 350));

                e.Graphics.DrawString("Supplier Name : " + text_supplier_name.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(25, 475));
            e.Graphics.DrawString("Amount : " + text_amount.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(25, 550));
            e.Graphics.DrawString("Transaction Mode : " + text_transaction_mode.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(25, 625));
            e.Graphics.DrawString("Account Holder Name: " + text_account_holder_name.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(25, 700));
            e.Graphics.DrawString("Payment Contact Number: " + text_payment_number.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(25, 775));
            String dashline1 = "____________________________________________________________________________________________________________________________________";
             e.Graphics.DrawString(dashline1, new Font("Arial", 11, FontStyle.Bold), Brushes.DarkRed, new Point(0, 950));
                
}

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the form is valid
            if (!IsFormValid())
            {
                return;
            }

            // If form is valid, proceed with printing
            MprintDocument.Print();

        }

        private void text_payment_number_TextChanged(object sender, EventArgs e)
        {
            if (text_payment_number.TextLength == 10)
            {
                text_payment_number.ForeColor = Color.Black;
            }
            else
            {
                text_payment_number.ForeColor = Color.Red;

            }
        }

        private void text_payment_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A phone Number cannot contains Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_payment_number.Focus();
            }
        }

        private void text_supplier_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker.Focus();
            }
        }

        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_amount.Focus();
            }
        }

        private void text_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_transaction_mode.Focus();
            }
        }

        private void text_transaction_mode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_account_holder_name.Focus();
            }
        }

        private void text_account_holder_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_payment_number.Focus();
            }
        }

        private void text_supplier_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsLetter(e.KeyChar)
                     && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Supplier Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_supplier_name.Focus();

            }
        }

        private void text_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsDigit(e.KeyChar))
                     
            {
                e.Handled = true;
                MessageBox.Show("Amount cannot contains letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_amount.Focus();

            }
        }

        private void text_transaction_mode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsLetter(e.KeyChar)
                     && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Transaction Mode cannot contains Numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_transaction_mode.Focus();

            }
        }

        private void text_account_holder_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsLetter(e.KeyChar)
                     && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Account holder  Name cannot contains Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_account_holder_name.Focus();

            }
        }

        private void quantity_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void order_id_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    } 


    

