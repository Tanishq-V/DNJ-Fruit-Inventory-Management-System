namespace DNJ_Inventory_System
{
    partial class customer_order_details
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
            this.text_unit = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.text_variety = new System.Windows.Forms.TextBox();
            this.text_fruit_name = new System.Windows.Forms.TextBox();
            this.text_order_id = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.variety = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.Label();
            this.s_id = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.Label();
            this.text_customer_name = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.dnjsystemDataSet = new DNJ_Inventory_System.dnjsystemDataSet();
            this.customer_order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_order_detailsTableAdapter = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.customer_order_detailsTableAdapter();
            this.tableAdapterManager = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager();
            this.c_order_details_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_order_details_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // text_unit
            // 
            this.text_unit.AutoCompleteCustomSource.AddRange(new string[] {
            "KG",
            "CRATE"});
            this.text_unit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_unit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_unit.Location = new System.Drawing.Point(288, 349);
            this.text_unit.Name = "text_unit";
            this.text_unit.Size = new System.Drawing.Size(124, 22);
            this.text_unit.TabIndex = 36;
            this.text_unit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_unit_KeyDown);
            this.text_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_unit_KeyPress);
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(214, 344);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(66, 36);
            this.unit.TabIndex = 35;
            this.unit.Text = "Unit :";
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(288, 379);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(124, 22);
            this.text_price.TabIndex = 34;
            this.text_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_price_KeyPress);
            // 
            // text_quantity
            // 
            this.text_quantity.Location = new System.Drawing.Point(288, 317);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.Size = new System.Drawing.Size(124, 22);
            this.text_quantity.TabIndex = 33;
            this.text_quantity.TextChanged += new System.EventHandler(this.text_quantity_TextChanged);
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
            this.text_variety.Location = new System.Drawing.Point(288, 289);
            this.text_variety.Name = "text_variety";
            this.text_variety.Size = new System.Drawing.Size(124, 22);
            this.text_variety.TabIndex = 32;
            this.text_variety.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_variety_KeyDown);
            this.text_variety.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_variety_KeyPress);
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
            this.text_fruit_name.Location = new System.Drawing.Point(288, 259);
            this.text_fruit_name.Name = "text_fruit_name";
            this.text_fruit_name.Size = new System.Drawing.Size(124, 22);
            this.text_fruit_name.TabIndex = 31;
            this.text_fruit_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_fruit_name_KeyDown);
            this.text_fruit_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_fruit_name_KeyPress);
            // 
            // text_order_id
            // 
            this.text_order_id.Location = new System.Drawing.Point(287, 193);
            this.text_order_id.Name = "text_order_id";
            this.text_order_id.Size = new System.Drawing.Size(125, 22);
            this.text_order_id.TabIndex = 30;
            this.text_order_id.TextChanged += new System.EventHandler(this.text_order_id_TextChanged);
            this.text_order_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_order_id_KeyDown);
            this.text_order_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_order_id_KeyPress);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(207, 374);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(73, 36);
            this.price.TabIndex = 29;
            this.price.Text = "Price :";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(171, 312);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(109, 36);
            this.quantity.TabIndex = 28;
            this.quantity.Text = "Quantity :";
            // 
            // variety
            // 
            this.variety.AutoSize = true;
            this.variety.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variety.Location = new System.Drawing.Point(186, 284);
            this.variety.Name = "variety";
            this.variety.Size = new System.Drawing.Size(94, 36);
            this.variety.TabIndex = 27;
            this.variety.Text = "Variety :";
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_name.Location = new System.Drawing.Point(148, 253);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(132, 36);
            this.f_name.TabIndex = 26;
            this.f_name.Text = "Fruit Name :";
            // 
            // s_id
            // 
            this.s_id.AutoSize = true;
            this.s_id.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_id.Location = new System.Drawing.Point(103, 220);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(178, 36);
            this.s_id.TabIndex = 25;
            this.s_id.Text = "Customer Name :";
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id.Location = new System.Drawing.Point(145, 189);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(135, 36);
            this.order_id.TabIndex = 24;
            this.order_id.Text = "Purchase Id :";
            // 
            // text_customer_name
            // 
            this.text_customer_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_customer_name.Location = new System.Drawing.Point(288, 225);
            this.text_customer_name.Name = "text_customer_name";
            this.text_customer_name.Size = new System.Drawing.Size(124, 22);
            this.text_customer_name.TabIndex = 37;
            this.text_customer_name.TextChanged += new System.EventHandler(this.text_customer_name_TextChanged);
            this.text_customer_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_customer_name_KeyDown);
            this.text_customer_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_customer_name_KeyPress);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(427, 427);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(145, 55);
            this.btn_refresh.TabIndex = 38;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(268, 428);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(144, 53);
            this.btn_update.TabIndex = 40;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(114, 430);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(134, 53);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Purchase Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "SEARCH :";
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(596, 146);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(419, 22);
            this.text_search.TabIndex = 42;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
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
            // customer_order_detailsBindingSource
            // 
            this.customer_order_detailsBindingSource.DataMember = "customer_order_details";
            this.customer_order_detailsBindingSource.DataSource = this.dnjsystemDataSet;
            // 
            // c_order_detailsTableAdapter
            // 
            this.c_order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_personal_detailsTableAdapter = null;
            this.tableAdapterManager.customer_order_detailsTableAdapter = this.c_order_detailsTableAdapter;
            this.tableAdapterManager.customer_orderTableAdapter = null;
            this.tableAdapterManager.product_detailsTableAdapter = null;
            this.tableAdapterManager.registration_detailsTableAdapter = null;
            this.tableAdapterManager.s_order_detailsTableAdapter = null;
            this.tableAdapterManager.s_orderTableAdapter = null;
            this.tableAdapterManager.s_personal_detailsTableAdapter = null;
            this.tableAdapterManager.supplier_payment_detailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // c_order_details_dataGridView
            // 
            this.c_order_details_dataGridView.AutoGenerateColumns = false;
            this.c_order_details_dataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.c_order_details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_order_details_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.c_order_details_dataGridView.DataSource = this.customer_order_detailsBindingSource;
            this.c_order_details_dataGridView.Location = new System.Drawing.Point(480, 189);
            this.c_order_details_dataGridView.Name = "c_order_details_dataGridView";
            this.c_order_details_dataGridView.RowHeadersWidth = 51;
            this.c_order_details_dataGridView.RowTemplate.Height = 24;
            this.c_order_details_dataGridView.Size = new System.Drawing.Size(570, 220);
            this.c_order_details_dataGridView.TabIndex = 44;
            this.c_order_details_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_order_details_dataGridView_CellContentClick);
            this.c_order_details_dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_order_details_dataGridView_CellEnter);
            this.c_order_details_dataGridView.SelectionChanged += new System.EventHandler(this.c_order_details_dataGridView_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "o_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "O_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "C_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "f_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "F_Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "variety";
            this.dataGridViewTextBoxColumn4.HeaderText = "Variety";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quant";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // customer_order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.c_order_details_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.text_customer_name);
            this.Controls.Add(this.text_unit);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.text_variety);
            this.Controls.Add(this.text_fruit_name);
            this.Controls.Add(this.text_order_id);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.variety);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.order_id);
            this.MaximizeBox = false;
            this.Name = "customer_order_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer_purchase_details";
            this.Load += new System.EventHandler(this.customer_order_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_order_details_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_unit;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.TextBox text_variety;
        private System.Windows.Forms.TextBox text_fruit_name;
        private System.Windows.Forms.TextBox text_order_id;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label variety;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label s_id;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.TextBox text_customer_name;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_search;
        private dnjsystemDataSet dnjsystemDataSet;
        private System.Windows.Forms.BindingSource customer_order_detailsBindingSource;
        private dnjsystemDataSetTableAdapters.customer_order_detailsTableAdapter c_order_detailsTableAdapter;
        private dnjsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView c_order_details_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}