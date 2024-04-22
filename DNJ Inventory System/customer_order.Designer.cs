namespace DNJ_Inventory_System
{
    partial class customer_order
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
            this.label3 = new System.Windows.Forms.Label();
            this.text_customer_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.text_total = new System.Windows.Forms.TextBox();
            this.text_order_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dnjsystemDataSet = new DNJ_Inventory_System.dnjsystemDataSet();
            this.customer_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_order_TableAdapter = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.customer_orderTableAdapter();
            this.tableAdapterManager = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager();
            this.c_order_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Button();
            this.Cal_Total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_order_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 100);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(429, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customer Id :";
            // 
            // text_customer_id
            // 
            this.text_customer_id.Location = new System.Drawing.Point(264, 285);
            this.text_customer_id.Name = "text_customer_id";
            this.text_customer_id.Size = new System.Drawing.Size(161, 22);
            this.text_customer_id.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // text_total
            // 
            this.text_total.Location = new System.Drawing.Point(264, 357);
            this.text_total.Name = "text_total";
            this.text_total.Size = new System.Drawing.Size(161, 22);
            this.text_total.TabIndex = 28;
            this.text_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_total_KeyPress);
            // 
            // text_order_id
            // 
            this.text_order_id.Location = new System.Drawing.Point(264, 253);
            this.text_order_id.Name = "text_order_id";
            this.text_order_id.Size = new System.Drawing.Size(161, 22);
            this.text_order_id.TabIndex = 27;
            this.text_order_id.TextChanged += new System.EventHandler(this.text_order_id_TextChanged);
            this.text_order_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_order_id_KeyDown);
            this.text_order_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_order_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total :";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(187, 316);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(71, 36);
            this.date.TabIndex = 25;
            this.date.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Purchase Id :";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(352, 434);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(151, 51);
            this.btn_refresh.TabIndex = 34;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(194, 434);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(141, 55);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(54, 434);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 55);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // customer_orderBindingSource
            // 
            this.customer_orderBindingSource.DataMember = "customer_order";
            this.customer_orderBindingSource.DataSource = this.dnjsystemDataSet;
            // 
            // c_order_TableAdapter
            // 
            this.c_order_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_personal_detailsTableAdapter = null;
            this.tableAdapterManager.customer_order_detailsTableAdapter = null;
            this.tableAdapterManager.customer_orderTableAdapter = this.c_order_TableAdapter;
            this.tableAdapterManager.product_detailsTableAdapter = null;
            this.tableAdapterManager.registration_detailsTableAdapter = null;
            this.tableAdapterManager.s_order_detailsTableAdapter = null;
            this.tableAdapterManager.s_orderTableAdapter = null;
            this.tableAdapterManager.s_personal_detailsTableAdapter = null;
            this.tableAdapterManager.supplier_payment_detailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // c_order_dataGridView
            // 
            this.c_order_dataGridView.AutoGenerateColumns = false;
            this.c_order_dataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.c_order_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_order_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.c_order_dataGridView.DataSource = this.customer_orderBindingSource;
            this.c_order_dataGridView.Location = new System.Drawing.Point(480, 194);
            this.c_order_dataGridView.Name = "c_order_dataGridView";
            this.c_order_dataGridView.RowHeadersWidth = 51;
            this.c_order_dataGridView.RowTemplate.Height = 24;
            this.c_order_dataGridView.Size = new System.Drawing.Size(552, 234);
            this.c_order_dataGridView.TabIndex = 37;
            this.c_order_dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_order_dataGridView_CellEnter);
            this.c_order_dataGridView.SelectionChanged += new System.EventHandler(this.c_order_dataGridView_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_o_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "C_O_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "C_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(491, 151);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(749, 151);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "FROM :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "TO :";
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_filter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filter.Location = new System.Drawing.Point(955, 136);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(133, 51);
            this.btn_filter.TabIndex = 40;
            this.btn_filter.Text = "SEARCH";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ClearFilter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ClearFilter.Location = new System.Drawing.Point(969, 428);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(119, 48);
            this.btn_ClearFilter.TabIndex = 41;
            this.btn_ClearFilter.Text = "CLEAR";
            this.btn_ClearFilter.UseVisualStyleBackColor = false;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.total.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total.Location = new System.Drawing.Point(541, 434);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(132, 51);
            this.total.TabIndex = 42;
            this.total.Text = "TOTAL";
            this.total.UseVisualStyleBackColor = false;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // Cal_Total
            // 
            this.Cal_Total.AutoSize = true;
            this.Cal_Total.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Cal_Total.Location = new System.Drawing.Point(686, 446);
            this.Cal_Total.Name = "Cal_Total";
            this.Cal_Total.Size = new System.Drawing.Size(27, 36);
            this.Cal_Total.TabIndex = 43;
            this.Cal_Total.Text = "0";
            // 
            // customer_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.Cal_Total);
            this.Controls.Add(this.total);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.c_order_dataGridView);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_customer_id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.text_order_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "customer_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer_purchase";
            this.Load += new System.EventHandler(this.customer_order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_order_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_customer_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.TextBox text_order_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private dnjsystemDataSet dnjsystemDataSet;
        private System.Windows.Forms.BindingSource customer_orderBindingSource;
        private dnjsystemDataSetTableAdapters.customer_orderTableAdapter c_order_TableAdapter;
        private dnjsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView c_order_dataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Label Cal_Total;
    }
}