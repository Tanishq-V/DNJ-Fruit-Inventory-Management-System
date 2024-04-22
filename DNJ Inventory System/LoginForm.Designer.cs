namespace DNJ_Inventory_System
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dnjsystemDataSet1 = new DNJ_Inventory_System.dnjsystemDataSet();
            this.registration_detailsTableAdapter1 = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.registration_detailsTableAdapter();
            this.check_pass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet1.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to DNJ Merchant and\r\n           Commission Agent\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(764, 218);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(240, 22);
            this.text_username.TabIndex = 2;
            this.text_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_username_KeyDown);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(764, 275);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(240, 22);
            this.text_password.TabIndex = 3;
            this.text_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(697, 372);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 42);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.Enter += new System.EventHandler(this.btn_login_Enter);
            // 
            // btn_2
            // 
            this.btn_2.AutoSize = true;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_2.Location = new System.Drawing.Point(643, 437);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(176, 18);
            this.btn_2.TabIndex = 9;
            this.btn_2.Text = "Don\'t have an Account  ? ";
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_register
            // 
            this.btn_register.AutoSize = true;
            this.btn_register.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(816, 436);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(73, 19);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "Register";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(389, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 100);
            this.panel1.TabIndex = 12;
            // 
            // dnjsystemDataSet1
            // 
            this.dnjsystemDataSet1.DataSetName = "dnjsystemDataSet";
            // 
            // 
            // 
            this.dnjsystemDataSet1.s_payment_details.TableName = "s_order_details";
            this.dnjsystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registration_detailsTableAdapter1
            // 
            this.registration_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // check_pass
            // 
            this.check_pass.AutoSize = true;
            this.check_pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_pass.Location = new System.Drawing.Point(855, 331);
            this.check_pass.Name = "check_pass";
            this.check_pass.Size = new System.Drawing.Size(125, 20);
            this.check_pass.TabIndex = 13;
            this.check_pass.Text = "Show Password";
            this.check_pass.UseVisualStyleBackColor = true;
            this.check_pass.CheckedChanged += new System.EventHandler(this.check_pass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "USERNAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "PASSWORD :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DNJ_Inventory_System.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(574, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DNJ_Inventory_System.Properties.Resources.username1;
            this.pictureBox2.Location = new System.Drawing.Point(574, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DNJ_Inventory_System.Properties.Resources.fr1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_pass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet1.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label btn_2;
        private System.Windows.Forms.Label btn_register;
        private System.Windows.Forms.Panel panel1;
        private dnjsystemDataSet dnjsystemDataSet1;
        private dnjsystemDataSetTableAdapters.registration_detailsTableAdapter registration_detailsTableAdapter1;
        private System.Windows.Forms.CheckBox check_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}