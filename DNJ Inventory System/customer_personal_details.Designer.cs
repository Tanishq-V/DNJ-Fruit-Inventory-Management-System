namespace DNJ_Inventory_System
{
    partial class customer_personal_details
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.text_contact = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_district = new System.Windows.Forms.TextBox();
            this.text_city = new System.Windows.Forms.TextBox();
            this.text_state = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.c_name = new System.Windows.Forms.Label();
            this.c_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.dnjsystemDataSet = new DNJ_Inventory_System.dnjsystemDataSet();
            this.c_personal_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_personal_detailsTableAdapter = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.c_personal_detailsTableAdapter();
            this.tableAdapterManager = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager();
            this.c_personal_details_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_personal_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_personal_details_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(485, 437);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(154, 56);
            this.btn_refresh.TabIndex = 19;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(307, 439);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(146, 55);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(140, 438);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 55);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // text_contact
            // 
            this.text_contact.Location = new System.Drawing.Point(273, 378);
            this.text_contact.Name = "text_contact";
            this.text_contact.Size = new System.Drawing.Size(161, 22);
            this.text_contact.TabIndex = 33;
            this.text_contact.TextChanged += new System.EventHandler(this.text_contact_TextChanged);
            this.text_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_contact_KeyPress);
            this.text_contact.Leave += new System.EventHandler(this.text_contact_Leave);
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(273, 348);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(161, 22);
            this.text_address.TabIndex = 32;
            this.text_address.TextChanged += new System.EventHandler(this.text_address_TextChanged);
            this.text_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_address_KeyDown1);
            // 
            // text_district
            // 
            this.text_district.AutoCompleteCustomSource.AddRange(new string[] {
            "Mumbai City",
            "Mumbai Suburban",
            "Thane",
            "Palghar",
            "Raigad",
            "Ratnagiri",
            "Sindhudurg",
            "Nashik",
            "Dhule",
            "Jalgaon",
            "Ahmednagar",
            "Pune",
            "Solapur",
            "Satara",
            "Sangli",
            "Kolhapur",
            "Aurangabad",
            "Jalna",
            "Beed",
            "Osmanabad",
            "Nanded",
            "Latur",
            "Parbhani",
            "Hingoli",
            "Nagpur",
            "Wardha",
            "Bhandara",
            "Gondia",
            "Chandrapur",
            "Gadchiroli",
            "Buldhana",
            "Akola",
            "Washim",
            "Amravati",
            "Yavatmal",
            "Ahmedabad",
            "Amreli",
            "Anand",
            "Aravalli",
            "Banaskantha",
            "Bharuch",
            "Bhavnagar",
            "Botad",
            "Chhota Udaipur",
            "Dahod",
            "Dang",
            "Devbhoomi Dwarka",
            "Gandhinagar",
            "Gir Somnath",
            "Jamnagar",
            "Junagadh",
            "Kheda",
            "Kutch",
            "Mahisagar",
            "Mehsana",
            "Morbi",
            "Narmada",
            "Navsari",
            "Panchmahal",
            "Patan",
            "Porbandar",
            "Rajkot",
            "Sabarkantha",
            "Surat",
            "Surendranagar",
            "Tapi",
            "Vadodara",
            "Valsad",
            "Bagalkot",
            "Ballari (Bellary)",
            "Belagavi (Belgaum)",
            "Bengaluru Rural",
            "Bengaluru Urban",
            "Bidar",
            "Chamarajanagar",
            "Chikballapur",
            "Chikkamagaluru",
            "Chitradurga",
            "Dakshina Kannada",
            "Davanagere",
            "Dharwad",
            "Gadag",
            "Hassan",
            "Haveri",
            "Kalaburagi (Gulbarga)",
            "Kodagu",
            "Kolar",
            "Koppal",
            "Mandya",
            "Mysuru (Mysore)",
            "Raichur",
            "Ramanagara",
            "Shivamogga (Shimoga)",
            "Tumakuru (Tumkur)",
            "Udupi",
            "Uttara Kannada (Karwar)",
            "Vijayapura (Bijapur)",
            "Yadgir",
            "Agra",
            "Aligarh",
            "Ambedkar Nagar",
            "Amethi (earlier known as Raebareli)",
            "Amroha",
            "Auraiya",
            "Ayodhya (earlier known as Faizabad)",
            "Azamgarh",
            "Baghpat",
            "Bahraich",
            "Ballia",
            "Balrampur",
            "Banda",
            "Barabanki",
            "Bareilly",
            "Basti",
            "Bijnor",
            "Budaun",
            "Bulandshahr",
            "Chandauli",
            "Chitrakoot",
            "Deoria",
            "Etah",
            "Etawah",
            "Farrukhabad",
            "Fatehpur",
            "Firozabad",
            "Gautam Buddh Nagar (Noida)",
            "Ghaziabad",
            "Ghazipur",
            "Gonda",
            "Gorakhpur",
            "Hamirpur",
            "Hapur",
            "Hardoi",
            "Hathras",
            "Jalaun",
            "Jaunpur",
            "Jhansi",
            "Kannauj",
            "Kanpur Dehat",
            "Kanpur Nagar",
            "Kasganj",
            "Kaushambi",
            "Kushinagar",
            "Lakhimpur Kheri",
            "Lalitpur",
            "Lucknow",
            "Maharajganj",
            "Mahoba",
            "Jammu",
            "Samba",
            "Kathua",
            "Udhampur",
            "Doda",
            "Ramban",
            "Reasi",
            "Srinagar",
            "Budgam",
            "Pulwama",
            "Anantnag",
            "Baramulla",
            "Bandipora",
            "Ganderbal",
            "Alappuzha",
            "Ernakulam",
            "Idukki",
            "Kannur",
            "Kasaragod",
            "Kollam",
            "Kottayam",
            "Kozhikode",
            "Malappuram",
            "Palakkad",
            "Pathanamthitta",
            "Thiruvananthapuram",
            "Thrissur",
            "Wayanad",
            "Amritsar",
            "Barnala",
            "Bathinda",
            "Faridkot",
            "Fatehgarh Sahib",
            "Fazilka",
            "Firozpur",
            "Gurdaspur",
            "Hoshiarpur",
            "Jalandhar",
            "Kapurthala",
            "Ludhiana",
            "Mansa",
            "Moga",
            "Muktsar",
            "Pathankot",
            "Patiala",
            "Rupnagar (Ropar)",
            "Sahibzada Ajit Singh Nagar (Mohali)",
            "Sangrur",
            "Tarn Taran",
            "Bilaspur",
            "Chamba",
            "Hamirpur",
            "Kangra",
            "Kinnaur",
            "Kullu",
            "Lahaul and Spiti",
            "Mandi",
            "Shimla",
            "Sirmaur",
            "Solan",
            "Una",
            "Ambala",
            "Bhiwani",
            "Charkhi Dadri",
            "Faridabad",
            "Fatehabad",
            "Gurugram (Gurgaon)",
            "Hisar",
            "Jhajjar",
            "Jind",
            "Kaithal",
            "Karnal",
            "Kurukshetra",
            "Mahendragarh",
            "Nuh",
            "Palwal",
            "Panchkula",
            "Panipat",
            "Rewari",
            "Rohtak",
            "Sirsa",
            "Sonipat",
            "Yamunanagar"});
            this.text_district.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_district.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_district.Location = new System.Drawing.Point(273, 315);
            this.text_district.Name = "text_district";
            this.text_district.Size = new System.Drawing.Size(161, 22);
            this.text_district.TabIndex = 31;
            this.text_district.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_district_KeyDown1);
            this.text_district.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_district_KeyPress);
            // 
            // text_city
            // 
            this.text_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_city.Location = new System.Drawing.Point(273, 288);
            this.text_city.Name = "text_city";
            this.text_city.Size = new System.Drawing.Size(161, 22);
            this.text_city.TabIndex = 30;
            this.text_city.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_city_KeyDown1);
            this.text_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_city_KeyPress);
            // 
            // text_state
            // 
            this.text_state.AutoCompleteCustomSource.AddRange(new string[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal",
            "Andaman and Nicobar Islands",
            "Chandigarh",
            "Dadra ",
            "Nagar Haveli",
            "Daman ",
            "Diu",
            "Lakshadweep",
            "Delhi ",
            "Puducherry",
            "Jammu and Kashmir",
            "Ladakh"});
            this.text_state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_state.Location = new System.Drawing.Point(273, 257);
            this.text_state.Name = "text_state";
            this.text_state.Size = new System.Drawing.Size(161, 22);
            this.text_state.TabIndex = 29;
            this.text_state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_state_KeyDown1);
            this.text_state.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_state_KeyPress);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(273, 228);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(161, 22);
            this.text_name.TabIndex = 28;
            this.text_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_name_KeyDown);
            this.text_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_name_KeyPress1);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(273, 195);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(161, 22);
            this.text_id.TabIndex = 27;
            this.text_id.TextChanged += new System.EventHandler(this.text_id_TextChanged);
            this.text_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_id_KeyDown);
            this.text_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_cusid_KeyPress);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.contact.Location = new System.Drawing.Point(172, 373);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(99, 36);
            this.contact.TabIndex = 26;
            this.contact.Text = "Contact :";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.address.Location = new System.Drawing.Point(169, 343);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(101, 36);
            this.address.TabIndex = 25;
            this.address.Text = "Address :";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // district
            // 
            this.district.AutoSize = true;
            this.district.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.Location = new System.Drawing.Point(174, 315);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(96, 36);
            this.district.TabIndex = 24;
            this.district.Text = "District :";
            this.district.Click += new System.EventHandler(this.district_Click);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.city.Location = new System.Drawing.Point(134, 283);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(137, 36);
            this.city.TabIndex = 23;
            this.city.Text = "City/Village :";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.state.Location = new System.Drawing.Point(196, 252);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(75, 36);
            this.state.TabIndex = 22;
            this.state.Text = "State :";
            // 
            // c_name
            // 
            this.c_name.AutoSize = true;
            this.c_name.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.c_name.Location = new System.Drawing.Point(188, 223);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(82, 36);
            this.c_name.TabIndex = 21;
            this.c_name.Text = "Name :";
            // 
            // c_id
            // 
            this.c_id.AutoSize = true;
            this.c_id.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_id.Location = new System.Drawing.Point(130, 190);
            this.c_id.Name = "c_id";
            this.c_id.Size = new System.Drawing.Size(140, 36);
            this.c_id.TabIndex = 20;
            this.c_id.Text = "Customer Id :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 100);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(376, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Personal Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(616, 150);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(444, 22);
            this.text_search.TabIndex = 24;
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
            // c_personal_detailsBindingSource
            // 
            this.c_personal_detailsBindingSource.DataMember = "c_personal_details";
            this.c_personal_detailsBindingSource.DataSource = this.dnjsystemDataSet;
            // 
            // c_personal_detailsTableAdapter
            // 
            this.c_personal_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.c_personal_detailsTableAdapter = this.c_personal_detailsTableAdapter;
            this.tableAdapterManager.customer_order_detailsTableAdapter = null;
            this.tableAdapterManager.customer_orderTableAdapter = null;
            this.tableAdapterManager.product_detailsTableAdapter = null;
            this.tableAdapterManager.registration_detailsTableAdapter = null;
            this.tableAdapterManager.s_order_detailsTableAdapter = null;
            this.tableAdapterManager.s_orderTableAdapter = null;
            this.tableAdapterManager.s_personal_detailsTableAdapter = null;
            this.tableAdapterManager.supplier_payment_detailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DNJ_Inventory_System.dnjsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // c_personal_details_dataGridView
            // 
            this.c_personal_details_dataGridView.AutoGenerateColumns = false;
            this.c_personal_details_dataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.c_personal_details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_personal_details_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.c_personal_details_dataGridView.DataSource = this.c_personal_detailsBindingSource;
            this.c_personal_details_dataGridView.Location = new System.Drawing.Point(485, 190);
            this.c_personal_details_dataGridView.Name = "c_personal_details_dataGridView";
            this.c_personal_details_dataGridView.RowHeadersWidth = 51;
            this.c_personal_details_dataGridView.RowTemplate.Height = 24;
            this.c_personal_details_dataGridView.Size = new System.Drawing.Size(602, 220);
            this.c_personal_details_dataGridView.TabIndex = 35;
            this.c_personal_details_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_personal_details_dataGridView_CellContentClick);
            this.c_personal_details_dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_personal_details_dataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "C_ID";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "district";
            this.dataGridViewTextBoxColumn5.HeaderText = "District";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn7.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "SEARCH :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // customer_personal_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_personal_details_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.text_contact);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.text_district);
            this.Controls.Add(this.text_city);
            this.Controls.Add(this.text_state);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.address);
            this.Controls.Add(this.district);
            this.Controls.Add(this.city);
            this.Controls.Add(this.state);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.c_id);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.MaximizeBox = false;
            this.Name = "customer_personal_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer_personal_details";
            this.Load += new System.EventHandler(this.customer_personal_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_personal_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_personal_details_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox text_contact;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_district;
        private System.Windows.Forms.TextBox text_city;
        private System.Windows.Forms.TextBox text_state;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label district;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label c_name;
        private System.Windows.Forms.Label c_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_search;
        private dnjsystemDataSet dnjsystemDataSet;
        private System.Windows.Forms.BindingSource c_personal_detailsBindingSource;
        private dnjsystemDataSetTableAdapters.c_personal_detailsTableAdapter c_personal_detailsTableAdapter;
        private dnjsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView c_personal_details_dataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}