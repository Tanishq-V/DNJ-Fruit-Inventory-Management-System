namespace DNJ_Inventory_System
{
    partial class personal_details
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
            this.s_id = new System.Windows.Forms.Label();
            this.s_name = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_state = new System.Windows.Forms.TextBox();
            this.text_city = new System.Windows.Forms.TextBox();
            this.text_district = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_contact = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.s_personal_details_dataGridView = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spersonaldetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnjsystemDataSet = new DNJ_Inventory_System.dnjsystemDataSet();
            this.s_personal_detailsTableAdapter = new DNJ_Inventory_System.dnjsystemDataSetTableAdapters.s_personal_detailsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.text_search = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.s_personal_details_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonaldetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // s_id
            // 
            this.s_id.AutoSize = true;
            this.s_id.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.s_id.Location = new System.Drawing.Point(167, 192);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(128, 36);
            this.s_id.TabIndex = 0;
            this.s_id.Text = "Supplier Id :";
            this.s_id.Click += new System.EventHandler(this.s_id_Click);
            // 
            // s_name
            // 
            this.s_name.AutoSize = true;
            this.s_name.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.s_name.Location = new System.Drawing.Point(213, 222);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(82, 36);
            this.s_name.TabIndex = 1;
            this.s_name.Text = "Name :";
            this.s_name.Click += new System.EventHandler(this.s_name_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.state.Location = new System.Drawing.Point(220, 253);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(75, 36);
            this.state.TabIndex = 2;
            this.state.Text = "State :";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.city.Location = new System.Drawing.Point(158, 282);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(137, 36);
            this.city.TabIndex = 3;
            this.city.Text = "City/Village :";
            // 
            // district
            // 
            this.district.AutoSize = true;
            this.district.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.district.Location = new System.Drawing.Point(199, 312);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(96, 36);
            this.district.TabIndex = 4;
            this.district.Text = "District :";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.address.Location = new System.Drawing.Point(194, 339);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(101, 36);
            this.address.TabIndex = 5;
            this.address.Text = "Address :";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.contact.Location = new System.Drawing.Point(192, 372);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(99, 36);
            this.contact.TabIndex = 6;
            this.contact.Text = "Contact :";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(297, 197);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(142, 22);
            this.text_id.TabIndex = 7;
            this.text_id.TextChanged += new System.EventHandler(this.text_id_TextChanged);
            this.text_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_id_KeyDown);
            this.text_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_supid_KeyPress);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(297, 227);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(142, 22);
            this.text_name.TabIndex = 8;
            this.text_name.TextChanged += new System.EventHandler(this.text_supname_TextChanged);
            this.text_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_name_KeyDown);
            this.text_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_name_KeyPress1);
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
            this.text_state.Location = new System.Drawing.Point(297, 258);
            this.text_state.Name = "text_state";
            this.text_state.Size = new System.Drawing.Size(142, 22);
            this.text_state.TabIndex = 9;
            this.text_state.TextChanged += new System.EventHandler(this.text_state_TextChanged);
            this.text_state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_state_KeyDown);
            this.text_state.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_state_KeyPress);
            // 
            // text_city
            // 
            this.text_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_city.Location = new System.Drawing.Point(297, 287);
            this.text_city.Name = "text_city";
            this.text_city.Size = new System.Drawing.Size(142, 22);
            this.text_city.TabIndex = 10;
            this.text_city.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_city_KeyDown);
            this.text_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_city_KeyPress);
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
            this.text_district.Location = new System.Drawing.Point(297, 317);
            this.text_district.Name = "text_district";
            this.text_district.Size = new System.Drawing.Size(142, 22);
            this.text_district.TabIndex = 11;
            this.text_district.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_district_KeyDown);
            this.text_district.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_district_KeyPress);
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(297, 347);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(142, 22);
            this.text_address.TabIndex = 12;
            this.text_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_address_KeyDown);
            // 
            // text_contact
            // 
            this.text_contact.Location = new System.Drawing.Point(297, 377);
            this.text_contact.Name = "text_contact";
            this.text_contact.Size = new System.Drawing.Size(142, 22);
            this.text_contact.TabIndex = 13;
            this.text_contact.TextChanged += new System.EventHandler(this.text_contact_TextChanged);
            this.text_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_contact_KeyPress);
            this.text_contact.Leave += new System.EventHandler(this.text_contact_Leave);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(107, 435);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(127, 55);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(261, 435);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 55);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(431, 435);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(148, 55);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // s_personal_details_dataGridView
            // 
            this.s_personal_details_dataGridView.AutoGenerateColumns = false;
            this.s_personal_details_dataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.s_personal_details_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s_personal_details_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.s_personal_details_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.s_personal_details_dataGridView.DataSource = this.spersonaldetailsBindingSource;
            this.s_personal_details_dataGridView.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.s_personal_details_dataGridView.Location = new System.Drawing.Point(499, 203);
            this.s_personal_details_dataGridView.Name = "s_personal_details_dataGridView";
            this.s_personal_details_dataGridView.RowHeadersWidth = 51;
            this.s_personal_details_dataGridView.RowTemplate.Height = 24;
            this.s_personal_details_dataGridView.Size = new System.Drawing.Size(574, 215);
            this.s_personal_details_dataGridView.TabIndex = 17;
            this.s_personal_details_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.s_personal_details_dataGridView_CellClick);
            this.s_personal_details_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.s_personal_details_dataGridView_CellContentClick);
            this.s_personal_details_dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.s_personal_details_dataGridView_CellEnter);
            this.s_personal_details_dataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.s_personal_details_dataGridView_CellMouseMove);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "S_ID";
            this.sidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "district";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // spersonaldetailsBindingSource
            // 
            this.spersonaldetailsBindingSource.DataMember = "s_personal_details";
            this.spersonaldetailsBindingSource.DataSource = this.dnjsystemDataSet;
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
            // s_personal_detailsTableAdapter
            // 
            this.s_personal_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 100);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(380, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Supplier Personal Details";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(623, 154);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(428, 22);
            this.text_search.TabIndex = 22;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            this.text_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_search_KeyPress);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(528, 152);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 30);
            this.search.TabIndex = 23;
            this.search.Text = "SEARCH :";
            // 
            // personal_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 506);
            this.Controls.Add(this.search);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.s_personal_details_dataGridView);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
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
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.s_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "personal_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Personal Details";
            this.Load += new System.EventHandler(this.personal_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s_personal_details_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonaldetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet.s_payment_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnjsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label s_id;
        private System.Windows.Forms.Label s_name;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label district;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_state;
        private System.Windows.Forms.TextBox text_city;
        private System.Windows.Forms.TextBox text_district;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_contact;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView s_personal_details_dataGridView;
        private dnjsystemDataSet dnjsystemDataSet;
        private System.Windows.Forms.BindingSource spersonaldetailsBindingSource;
        private dnjsystemDataSetTableAdapters.s_personal_detailsTableAdapter s_personal_detailsTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label search;
    }
}