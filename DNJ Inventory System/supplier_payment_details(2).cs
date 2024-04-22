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

        //private IEnumerable<string> allsuppliernames;


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
                    this.s_payment_detailsTableAdapter.Fill(this.dnjsystemDataSet.s_payment_details);
                    // Now, set the SelectionMode and assign the event handler
                    s_payment_details_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    s_payment_details_dataGridView.SelectionChanged += s_payment_details_dataGridView_SelectionChanged;

                    // Populate supplier names ComboBox
                   // Populate_comboBox_supplier_name();
                    // Populate fruit names list
                   // PopulateFruitNames();

                }

                // Now, the rest of your initialization code
                Getsupplier_payment_id();
                //Getsupplier_id();
                //Getfruit_id();

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            string order_id = text_payment_id.Text;
            //string supplier_id = text_supplier_name.Text;
            //string fruit_id = text_fruit_id.Text;

            bool order_idExists = CheckIfIdExists(order_id);
            //bool supplier_idExists = CheckIfIdExists(supplier_id);
            //bool fruit_idExists = CheckIfIdExists(fruit_id);



            if (order_idExists)
            {
                if (text_payment_id.Text != "" && text_supplier_name.Text != "" && dateTimePicker.Text != "" && text_amount.Text != "" && text_transaction_mode.Text != "" && text_account_holder_name.Text != "" && text_payment_number.Text != "")
                {
                    string query = "UPDATE s_order_details SET s_name=@s_name, f_name=@f_name, variety=@variety, quant=@quant, unit=@unit, price=@price WHERE o_id=@o_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@p_id", Convert.ToInt32(order_id));
                    cmd.Parameters.AddWithValue("@s_name", text_supplier_name.Text);
                    // cmd.Parameters.AddWithValue("@f_id", Convert.ToInt32(fruit_id));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@amount", text_variety.Text);
                    cmd.Parameters.AddWithValue("@transaction_mode",text_transaction_mode.Text);
                    cmd.Parameters.AddWithValue("@account_holder_name", (text_account_holder_name.Text));
                    cmd.Parameters.AddWithValue("@contact", Convert.ToInt32(text_payment_number.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    ClearTextBoxes();

                    MessageBox.Show("Data Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Getsupplier_payment_id();
                    //Getsupplier_id();
                    //Getfruit_id();
                }
                else
                {
                    MessageBox.Show("Please select row which you want to update", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (text_payment_id.Text == "" || text_supplier_name.Text == "" || dateTimePicker.Text == "" || text_transaction_mode.Text == "" || text_amount.Text=="" || text_account_holder_name.Text == "" || text_payment_number.Text != t == "")
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
            dateTimePicker.Text = " ";
            text_amount.Text = " ";
            text_transaction_mode.Text = " ";
            text_account_holder_name.Text = " ";
            text_payment_number.Text = " ";

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

    }
}
    }
}
