using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DNJ_Inventory_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Size = new Size(800, 600); // Set your desired size
            this.Visible = true;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void sUPPLIERPERSONALDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personal_details sp1 = new personal_details();
            sp1.Show();

        }

        private void sUPPLIERORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier_order so = new supplier_order();
            so.Show();
        }

        private void sUPPLIERORDERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier_order_details sod1 = new supplier_order_details();
            sod1.Show();
        }

        private void sUPPLIERPAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier_payment_details spd = new supplier_payment_details();
            spd.Show();
        }

        private void cUSTOMERPERSONALDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer_personal_details cpd = new customer_personal_details();
            cpd.Show();
        }

        private void cUSTOMERORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer_order co = new customer_order();
            co.Show();
        }

        private void cUSTOMERORDERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer_order_details cod = new customer_order_details();
            cod.Show();
        }

        private void pRODUCTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_details pd = new product_details();
            pd.Show();
        }

        private void lOGOUTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm l1 = new LoginForm();
            l1.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchasedDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void supplierPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}


