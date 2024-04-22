namespace DNJ_Inventory_System
{
    partial class supplier_payment_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier_payment_details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_supplier_name = new System.Windows.Forms.TextBox();
            this.text_account_holder_name = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.Label();
            this.text_payment_number = new System.Windows.Forms.TextBox();
            this.text_transaction_mode = new System.Windows.Forms.TextBox();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.text_payment_id = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.variety = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.Label();
            this.s_id = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dnjsystemDataSet = new DNJ_Inventory_System.dnjsystemDataSet();
            this.supplier_payment_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_payment_detailsTableAdapter = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.supplier_payment_detailsTableAdapter();
            this.tableAdapterManager = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager();
            this.s_payment_details_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.MprintDocument = new System.Drawing.Printing.PrintDocument();
            this.MprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_payment_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_payment_details_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 90);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(385, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Supplier Payment Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_supplier_name
            // 
            this.text_supplier_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_supplier_name.Location = new System.Drawing.Point(361, 217);
            this.text_supplier_name.Name = "text_supplier_name";
            this.text_supplier_name.Size = new System.Drawing.Size(137, 22);
            this.text_supplier_name.TabIndex = 56;
            this.text_supplier_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_supplier_name_KeyDown);
            this.text_supplier_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_supplier_name_KeyPress);
            // 
            // text_account_holder_name
            // 
            this.text_account_holder_name.Location = new System.Drawing.Point(361, 341);
            this.text_account_holder_name.Name = "text_account_holder_name";
            this.text_account_holder_name.Size = new System.Drawing.Size(137, 22);
            this.text_account_holder_name.TabIndex = 55;
            this.text_account_holder_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_account_holder_name_KeyDown);
            this.text_account_holder_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_account_holder_name_KeyPress);
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.unit.Location = new System.Drawing.Point(110, 332);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(236, 36);
            this.unit.TabIndex = 54;
            this.unit.Text = "Account Holder Name :";
            // 
            // text_payment_number
            // 
            this.text_payment_number.Location = new System.Drawing.Point(361, 371);
            this.text_payment_number.Name = "text_payment_number";
            this.text_payment_number.Size = new System.Drawing.Size(137, 22);
            this.text_payment_number.TabIndex = 53;
            this.text_payment_number.TextChanged += new System.EventHandler(this.text_payment_number_TextChanged);
            this.text_payment_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_payment_number_KeyPress);
            // 
            // text_transaction_mode
            // 
            this.text_transaction_mode.AutoCompleteCustomSource.AddRange(new string[] {
            "cash",
            "online"});
            this.text_transaction_mode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_transaction_mode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_transaction_mode.Location = new System.Drawing.Point(361, 309);
            this.text_transaction_mode.Name = "text_transaction_mode";
            this.text_transaction_mode.Size = new System.Drawing.Size(137, 22);
            this.text_transaction_mode.TabIndex = 52;
            this.text_transaction_mode.Text = " - select cash/online -";
            this.text_transaction_mode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_transaction_mode_KeyDown);
            this.text_transaction_mode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_transaction_mode_KeyPress);
            // 
            // text_amount
            // 
            this.text_amount.Location = new System.Drawing.Point(361, 281);
            this.text_amount.Name = "text_amount";
            this.text_amount.Size = new System.Drawing.Size(137, 22);
            this.text_amount.TabIndex = 51;
            this.text_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_amount_KeyDown);
            this.text_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_amount_KeyPress);
            // 
            // text_payment_id
            // 
            this.text_payment_id.Location = new System.Drawing.Point(360, 185);
            this.text_payment_id.Name = "text_payment_id";
            this.text_payment_id.Size = new System.Drawing.Size(138, 22);
            this.text_payment_id.TabIndex = 49;
            this.text_payment_id.TextChanged += new System.EventHandler(this.text_payment_id_TextChanged);
            this.text_payment_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_payment_id_KeyDown);
            this.text_payment_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_payment_id_KeyPress);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.price.Location = new System.Drawing.Point(68, 366);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(277, 36);
            this.price.TabIndex = 48;
            this.price.Text = "Payment Contact Number  :";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.quantity.Location = new System.Drawing.Point(143, 304);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(203, 36);
            this.quantity.TabIndex = 47;
            this.quantity.Text = "Transaction Mode  :";
            this.quantity.Click += new System.EventHandler(this.quantity_Click);
            // 
            // variety
            // 
            this.variety.AutoSize = true;
            this.variety.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.variety.Location = new System.Drawing.Point(243, 276);
            this.variety.Name = "variety";
            this.variety.Size = new System.Drawing.Size(102, 36);
            this.variety.TabIndex = 46;
            this.variety.Text = "Amount :";
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.f_name.Location = new System.Drawing.Point(274, 250);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(71, 36);
            this.f_name.TabIndex = 45;
            this.f_name.Text = "Date :";
            // 
            // s_id
            // 
            this.s_id.AutoSize = true;
            this.s_id.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.s_id.Location = new System.Drawing.Point(180, 217);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(166, 36);
            this.s_id.TabIndex = 44;
            this.s_id.Text = "Supplier Name :";
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.order_id.Location = new System.Drawing.Point(212, 185);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(133, 36);
            this.order_id.TabIndex = 43;
            this.order_id.Text = "Payment Id :";
            this.order_id.Click += new System.EventHandler(this.order_id_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(360, 253);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 22);
            this.dateTimePicker.TabIndex = 57;
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_KeyDown);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(261, 432);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 53);
            this.btn_update.TabIndex = 60;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(126, 432);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 55);
            this.btn_save.TabIndex = 59;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(927, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 55);
            this.button2.TabIndex = 62;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(647, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 55);
            this.button1.TabIndex = 63;
            this.button1.Text = "PRINT PREVIEW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(409, 430);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(150, 55);
            this.btn_refresh.TabIndex = 64;
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
            // supplier_payment_detailsBindingSource
            // 
            this.supplier_payment_detailsBindingSource.DataMember = "supplier_payment_details";
            this.supplier_payment_detailsBindingSource.DataSource = this.dnjsystemDataSet;
            // 
            // s_payment_detailsTableAdapter
            // 
            this.s_payment_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_personal_detailsTableAdapter = null;
            this.tableAdapterManager.customer_order_detailsTableAdapter = null;
            this.tableAdapterManager.customer_orderTableAdapter = null;
            this.tableAdapterManager.product_detailsTableAdapter = null;
            this.tableAdapterManager.registration_detailsTableAdapter = null;
            this.tableAdapterManager.s_order_detailsTableAdapter = null;
            this.tableAdapterManager.s_orderTableAdapter = null;
            this.tableAdapterManager.s_personal_detailsTableAdapter = null;
            this.tableAdapterManager.supplier_payment_detailsTableAdapter = this.s_payment_detailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // s_payment_details_dataGridView
            // 
            this.s_payment_details_dataGridView.AutoGenerateColumns = false;
            this.s_payment_details_dataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.s_payment_details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.s_payment_details_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.s_payment_details_dataGridView.DataSource = this.supplier_payment_detailsBindingSource;
            this.s_payment_details_dataGridView.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.s_payment_details_dataGridView.Location = new System.Drawing.Point(537, 185);
            this.s_payment_details_dataGridView.Name = "s_payment_details_dataGridView";
            this.s_payment_details_dataGridView.RowHeadersWidth = 51;
            this.s_payment_details_dataGridView.RowTemplate.Height = 24;
            this.s_payment_details_dataGridView.Size = new System.Drawing.Size(530, 220);
            this.s_payment_details_dataGridView.TabIndex = 65;
            this.s_payment_details_dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.s_payment_details_dataGridView_CellEnter);
            this.s_payment_details_dataGridView.SelectionChanged += new System.EventHandler(this.s_payment_details_dataGridView_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "p_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "p_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "s_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "s_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "transaction_mode";
            this.dataGridViewTextBoxColumn5.HeaderText = "transaction_mode";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "account_holder_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "account_holder_name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn7.HeaderText = "contact";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 67;
            this.label2.Text = "SEARCH :";
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(647, 143);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(399, 22);
            this.text_search.TabIndex = 66;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // MprintDocument
            // 
            this.MprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MprintDocument_PrintPage);
            // 
            // MprintPreviewDialog
            // 
            this.MprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.MprintPreviewDialog.Enabled = true;
            this.MprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("MprintPreviewDialog.Icon")));
            this.MprintPreviewDialog.Name = "MprintPreviewDialog";
            this.MprintPreviewDialog.Visible = false;
            // 
            // supplier_payment_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.s_payment_details_dataGridView);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.text_supplier_name);
            this.Controls.Add(this.text_account_holder_name);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.text_payment_number);
            this.Controls.Add(this.text_transaction_mode);
            this.Controls.Add(this.text_amount);
            this.Controls.Add(this.text_payment_id);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.variety);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "supplier_payment_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supplier_payment_details";
            this.Load += new System.EventHandler(this.supplier_payment_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_payment_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_payment_details_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_supplier_name;
        private System.Windows.Forms.TextBox text_account_holder_name;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox text_payment_number;
        private System.Windows.Forms.TextBox text_transaction_mode;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label variety;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label s_id;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_refresh;
        private dnjsystemDataSet dnjsystemDataSet;
        private System.Windows.Forms.BindingSource supplier_payment_detailsBindingSource;
        private dnjsystemDataSetTableAdapters.supplier_payment_detailsTableAdapter s_payment_detailsTableAdapter;
        private dnjsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView s_payment_details_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.TextBox text_payment_id;
        private System.Drawing.Printing.PrintDocument MprintDocument;
        private System.Windows.Forms.PrintPreviewDialog MprintPreviewDialog;
    }
}