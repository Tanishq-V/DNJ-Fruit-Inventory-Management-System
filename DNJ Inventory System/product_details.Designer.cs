namespace DNJ_Inventory_System
{
    partial class product_details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.text_fruit_id = new System.Windows.Forms.TextBox();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.text_variety = new System.Windows.Forms.TextBox();
            this.text_fruit_name = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.variety = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dnjsystemDataSet = new DNJ_Inventory_System.dnjsystemDataSet();
            this.product_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_detailsTableAdapter = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.product_detailsTableAdapter();
            this.tableAdapterManager = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager();
            this.product_details_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_details_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 90);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "SEARCH :";
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(651, 142);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(363, 22);
            this.text_search.TabIndex = 44;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // text_fruit_id
            // 
            this.text_fruit_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_fruit_id.Location = new System.Drawing.Point(329, 243);
            this.text_fruit_id.Name = "text_fruit_id";
            this.text_fruit_id.Size = new System.Drawing.Size(167, 22);
            this.text_fruit_id.TabIndex = 53;
            this.text_fruit_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_fruit_id_KeyDown);
            this.text_fruit_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_fruit_id_KeyPress);
            // 
            // text_quantity
            // 
            this.text_quantity.Location = new System.Drawing.Point(329, 335);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.Size = new System.Drawing.Size(167, 22);
            this.text_quantity.TabIndex = 52;
            this.text_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_quantity_KeyDown);
            this.text_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_quantity_KeyPress);
            // 
            // text_variety
            // 
            this.text_variety.AutoCompleteCustomSource.AddRange(new string[] {
            "Shimla (Kinnaur, Himachal Pradesh)",
            "Kashmiri (Kashmir Valley)",
            "Royal Gala",
            "Fuji",
            "Red Delicious",
            "Granny Smith",
            "Golden Delicious",
            "Robusta (Malbhog, Poovan)",
            "Cavendish/\'elakki\'/\'yelakki\' bananas",
            "Nendran (for cooking)",
            "Red Banana",
            "Nagpur",
            "Kinnow",
            "Valencia",
            "Mandarin",
            "Blood Orange",
            "Thompson Seedless",
            "Bangalore Blue",
            "Sharad Seedless",
            "Anab-e-Shahi",
            "Arkavati",
            "Mahabaleshwar (Maharashtra)",
            "Ooty (Tamil Nadu)",
            "Kodaikanal (Tamil Nadu)",
            "Alphonso (Hapus)",
            "Kesar",
            "Banganapalli (Safeda)",
            "Langra",
            "Dasheri",
            "Totapuri",
            "Kew",
            "Queen",
            "Mauritius",
            "Sugar Baby",
            "Ice Box",
            "Black Diamond",
            "Hayward (Green Kiwi)",
            "Shimla (Himachal Pradesh)",
            "Sharbati (Uttarakhand)",
            "Elberta",
            "Nashi (Asian Pear)",
            "China",
            "Patharnakh (Uttarakhand)",
            "Santa Rosa",
            "Japanese Plums",
            "Kagzi",
            "Eureka",
            "Italian",
            "Indian Sweet Lime",
            "Kaghzi (Seedless Lime)",
            "Solo",
            "Coorg",
            "Pusa Nanha"});
            this.text_variety.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_variety.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_variety.Location = new System.Drawing.Point(329, 307);
            this.text_variety.Name = "text_variety";
            this.text_variety.Size = new System.Drawing.Size(167, 22);
            this.text_variety.TabIndex = 51;
            this.text_variety.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_variety_KeyDown);
            // 
            // text_fruit_name
            // 
            this.text_fruit_name.AutoCompleteCustomSource.AddRange(new string[] {
            "Apples",
            "Bananas",
            "Oranges",
            "Grapes",
            "Strawberries",
            "Blueberries",
            "Mangoes",
            "Pineapples",
            "Watermelons",
            "Kiwifruits",
            "Peaches",
            "Pears",
            "Plums",
            "Cherries",
            "Lemons",
            "Limes",
            "Papayas",
            "Avocados",
            "Grapefruits"});
            this.text_fruit_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_fruit_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_fruit_name.Location = new System.Drawing.Point(329, 277);
            this.text_fruit_name.Name = "text_fruit_name";
            this.text_fruit_name.Size = new System.Drawing.Size(167, 22);
            this.text_fruit_name.TabIndex = 50;
            this.text_fruit_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_fruit_name_KeyDown);
            this.text_fruit_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_fruit_name_KeyPress);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.quantity.Location = new System.Drawing.Point(212, 335);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(109, 36);
            this.quantity.TabIndex = 49;
            this.quantity.Text = "Quantity :";
            // 
            // variety
            // 
            this.variety.AutoSize = true;
            this.variety.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.variety.Location = new System.Drawing.Point(227, 307);
            this.variety.Name = "variety";
            this.variety.Size = new System.Drawing.Size(94, 36);
            this.variety.TabIndex = 48;
            this.variety.Text = "Variety :";
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.f_name.Location = new System.Drawing.Point(189, 277);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(132, 36);
            this.f_name.TabIndex = 47;
            this.f_name.Text = "Fruit Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(227, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fruit Id :";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(324, 425);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 55);
            this.btn_update.TabIndex = 57;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(173, 425);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 55);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(483, 425);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(149, 55);
            this.btn_refresh.TabIndex = 55;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dnjsystemDataSet
            // 
            this.dnjsystemDataSet.DataSetName = "dnjsystemDataSet";
            // 
            // 
            // 
            this.dnjsystemDataSet.s_payment_details.TableName = "s_order_details";
            this.dnjsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_detailsBindingSource
            // 
            this.product_detailsBindingSource.DataMember = "product_details";
            this.product_detailsBindingSource.DataSource = this.dnjsystemDataSet;
            // 
            // product_detailsTableAdapter
            // 
            this.product_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_personal_detailsTableAdapter = null;
            this.tableAdapterManager.customer_order_detailsTableAdapter = null;
            this.tableAdapterManager.customer_orderTableAdapter = null;
            this.tableAdapterManager.product_detailsTableAdapter = this.product_detailsTableAdapter;
            this.tableAdapterManager.registration_detailsTableAdapter = null;
            this.tableAdapterManager.s_order_detailsTableAdapter = null;
            this.tableAdapterManager.s_orderTableAdapter = null;
            this.tableAdapterManager.s_personal_detailsTableAdapter = null;
            this.tableAdapterManager.supplier_payment_detailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_details_dataGridView
            // 
            this.product_details_dataGridView.AutoGenerateColumns = false;
            this.product_details_dataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.product_details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_details_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.product_details_dataGridView.DataSource = this.product_detailsBindingSource;
            this.product_details_dataGridView.Location = new System.Drawing.Point(549, 184);
            this.product_details_dataGridView.Name = "product_details_dataGridView";
            this.product_details_dataGridView.RowHeadersWidth = 51;
            this.product_details_dataGridView.RowTemplate.Height = 24;
            this.product_details_dataGridView.Size = new System.Drawing.Size(520, 220);
            this.product_details_dataGridView.TabIndex = 58;
            this.product_details_dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_details_dataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "f_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "F_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "f_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "F_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "variety";
            this.dataGridViewTextBoxColumn3.HeaderText = "Variety";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quant";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // product_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.product_details_dataGridView);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_fruit_id);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.text_variety);
            this.Controls.Add(this.text_fruit_name);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.variety);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "product_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product_details";
            this.Load += new System.EventHandler(this.product_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_details_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.TextBox text_fruit_id;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.TextBox text_variety;
        private System.Windows.Forms.TextBox text_fruit_name;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label variety;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_refresh;
        private dnjsystemDataSet dnjsystemDataSet;
        private System.Windows.Forms.BindingSource product_detailsBindingSource;
        private dnjsystemDataSetTableAdapters.product_detailsTableAdapter product_detailsTableAdapter;
        private dnjsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView product_details_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}