namespace WinFormsApp1
{
    partial class managing_managers
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
            this.managing_employee_functionality_combob = new System.Windows.Forms.ComboBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_update_panel = new System.Windows.Forms.Panel();
            this.manager_password_tb = new System.Windows.Forms.TextBox();
            this.employee_SSN_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_combob = new System.Windows.Forms.ComboBox();
            this.manager_email_tb = new System.Windows.Forms.TextBox();
            this.receptionist_email_lbl = new System.Windows.Forms.Label();
            this.employee_birth_date_db = new System.Windows.Forms.DateTimePicker();
            this.employee_SSN_lbl = new System.Windows.Forms.Label();
            this.receptionist_password_lbl = new System.Windows.Forms.Label();
            this.employee_address_lbl = new System.Windows.Forms.Label();
            this.employee_address_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_lbl = new System.Windows.Forms.Label();
            this.employee_phone_nmber_lbl = new System.Windows.Forms.Label();
            this.device_birth_date_lbl = new System.Windows.Forms.Label();
            this.employee_phone_number_tb = new System.Windows.Forms.TextBox();
            this.employee_name_tb = new System.Windows.Forms.TextBox();
            this.employee_name_lbl = new System.Windows.Forms.Label();
            this.choose_button = new System.Windows.Forms.Button();
            this.name_combob = new System.Windows.Forms.ComboBox();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_update_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // managing_employee_functionality_combob
            // 
            this.managing_employee_functionality_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managing_employee_functionality_combob.FormattingEnabled = true;
            this.managing_employee_functionality_combob.Items.AddRange(new object[] {
            "Add",
            "Update",
            "Remove",
            "Search"});
            this.managing_employee_functionality_combob.Location = new System.Drawing.Point(213, 79);
            this.managing_employee_functionality_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managing_employee_functionality_combob.Name = "managing_employee_functionality_combob";
            this.managing_employee_functionality_combob.Size = new System.Drawing.Size(437, 28);
            this.managing_employee_functionality_combob.TabIndex = 48;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(355, 507);
            this.remove_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(250, 45);
            this.remove_button.TabIndex = 46;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click_1);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(355, 507);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(250, 45);
            this.search_button.TabIndex = 45;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(355, 507);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(250, 45);
            this.update_button.TabIndex = 44;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // add_update_panel
            // 
            this.add_update_panel.Controls.Add(this.manager_password_tb);
            this.add_update_panel.Controls.Add(this.employee_SSN_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_combob);
            this.add_update_panel.Controls.Add(this.manager_email_tb);
            this.add_update_panel.Controls.Add(this.receptionist_email_lbl);
            this.add_update_panel.Controls.Add(this.employee_birth_date_db);
            this.add_update_panel.Controls.Add(this.employee_SSN_lbl);
            this.add_update_panel.Controls.Add(this.receptionist_password_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_nmber_lbl);
            this.add_update_panel.Controls.Add(this.device_birth_date_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_number_tb);
            this.add_update_panel.Location = new System.Drawing.Point(213, 172);
            this.add_update_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_update_panel.Name = "add_update_panel";
            this.add_update_panel.Size = new System.Drawing.Size(437, 291);
            this.add_update_panel.TabIndex = 47;
            // 
            // manager_password_tb
            // 
            this.manager_password_tb.Location = new System.Drawing.Point(142, 81);
            this.manager_password_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_password_tb.Name = "manager_password_tb";
            this.manager_password_tb.Size = new System.Drawing.Size(272, 27);
            this.manager_password_tb.TabIndex = 26;
            // 
            // employee_SSN_tb
            // 
            this.employee_SSN_tb.Location = new System.Drawing.Point(142, 4);
            this.employee_SSN_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_SSN_tb.Name = "employee_SSN_tb";
            this.employee_SSN_tb.Size = new System.Drawing.Size(272, 27);
            this.employee_SSN_tb.TabIndex = 12;
            this.employee_SSN_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_SSN_tb_KeyPress);
            // 
            // employee_gender_combob
            // 
            this.employee_gender_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_gender_combob.FormattingEnabled = true;
            this.employee_gender_combob.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.employee_gender_combob.Location = new System.Drawing.Point(142, 159);
            this.employee_gender_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_gender_combob.Name = "employee_gender_combob";
            this.employee_gender_combob.Size = new System.Drawing.Size(272, 28);
            this.employee_gender_combob.TabIndex = 11;
            // 
            // manager_email_tb
            // 
            this.manager_email_tb.Location = new System.Drawing.Point(142, 43);
            this.manager_email_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manager_email_tb.Name = "manager_email_tb";
            this.manager_email_tb.Size = new System.Drawing.Size(272, 27);
            this.manager_email_tb.TabIndex = 25;
            // 
            // receptionist_email_lbl
            // 
            this.receptionist_email_lbl.AutoSize = true;
            this.receptionist_email_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receptionist_email_lbl.ForeColor = System.Drawing.Color.White;
            this.receptionist_email_lbl.Location = new System.Drawing.Point(6, 43);
            this.receptionist_email_lbl.Name = "receptionist_email_lbl";
            this.receptionist_email_lbl.Size = new System.Drawing.Size(54, 23);
            this.receptionist_email_lbl.TabIndex = 27;
            this.receptionist_email_lbl.Text = "Email";
            // 
            // employee_birth_date_db
            // 
            this.employee_birth_date_db.Location = new System.Drawing.Point(142, 236);
            this.employee_birth_date_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_birth_date_db.Name = "employee_birth_date_db";
            this.employee_birth_date_db.Size = new System.Drawing.Size(272, 27);
            this.employee_birth_date_db.TabIndex = 14;
            this.employee_birth_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // employee_SSN_lbl
            // 
            this.employee_SSN_lbl.AutoSize = true;
            this.employee_SSN_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee_SSN_lbl.ForeColor = System.Drawing.Color.White;
            this.employee_SSN_lbl.Location = new System.Drawing.Point(6, 4);
            this.employee_SSN_lbl.Name = "employee_SSN_lbl";
            this.employee_SSN_lbl.Size = new System.Drawing.Size(43, 23);
            this.employee_SSN_lbl.TabIndex = 15;
            this.employee_SSN_lbl.Text = "SSN";
            // 
            // receptionist_password_lbl
            // 
            this.receptionist_password_lbl.AutoSize = true;
            this.receptionist_password_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receptionist_password_lbl.ForeColor = System.Drawing.Color.White;
            this.receptionist_password_lbl.Location = new System.Drawing.Point(6, 81);
            this.receptionist_password_lbl.Name = "receptionist_password_lbl";
            this.receptionist_password_lbl.Size = new System.Drawing.Size(85, 23);
            this.receptionist_password_lbl.TabIndex = 28;
            this.receptionist_password_lbl.Text = "Password";
            // 
            // employee_address_lbl
            // 
            this.employee_address_lbl.AutoSize = true;
            this.employee_address_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee_address_lbl.ForeColor = System.Drawing.Color.White;
            this.employee_address_lbl.Location = new System.Drawing.Point(6, 120);
            this.employee_address_lbl.Name = "employee_address_lbl";
            this.employee_address_lbl.Size = new System.Drawing.Size(74, 23);
            this.employee_address_lbl.TabIndex = 17;
            this.employee_address_lbl.Text = "Address";
            // 
            // employee_address_tb
            // 
            this.employee_address_tb.Location = new System.Drawing.Point(142, 120);
            this.employee_address_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_address_tb.Name = "employee_address_tb";
            this.employee_address_tb.Size = new System.Drawing.Size(272, 27);
            this.employee_address_tb.TabIndex = 22;
            // 
            // employee_gender_lbl
            // 
            this.employee_gender_lbl.AutoSize = true;
            this.employee_gender_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee_gender_lbl.ForeColor = System.Drawing.Color.White;
            this.employee_gender_lbl.Location = new System.Drawing.Point(6, 159);
            this.employee_gender_lbl.Name = "employee_gender_lbl";
            this.employee_gender_lbl.Size = new System.Drawing.Size(68, 23);
            this.employee_gender_lbl.TabIndex = 18;
            this.employee_gender_lbl.Text = "Gender";
            // 
            // employee_phone_nmber_lbl
            // 
            this.employee_phone_nmber_lbl.AutoSize = true;
            this.employee_phone_nmber_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee_phone_nmber_lbl.ForeColor = System.Drawing.Color.White;
            this.employee_phone_nmber_lbl.Location = new System.Drawing.Point(6, 197);
            this.employee_phone_nmber_lbl.Name = "employee_phone_nmber_lbl";
            this.employee_phone_nmber_lbl.Size = new System.Drawing.Size(130, 23);
            this.employee_phone_nmber_lbl.TabIndex = 21;
            this.employee_phone_nmber_lbl.Text = "Phone Number";
            // 
            // device_birth_date_lbl
            // 
            this.device_birth_date_lbl.AutoSize = true;
            this.device_birth_date_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_birth_date_lbl.ForeColor = System.Drawing.Color.White;
            this.device_birth_date_lbl.Location = new System.Drawing.Point(6, 240);
            this.device_birth_date_lbl.Name = "device_birth_date_lbl";
            this.device_birth_date_lbl.Size = new System.Drawing.Size(93, 23);
            this.device_birth_date_lbl.TabIndex = 19;
            this.device_birth_date_lbl.Text = "Birht Date";
            // 
            // employee_phone_number_tb
            // 
            this.employee_phone_number_tb.Location = new System.Drawing.Point(142, 197);
            this.employee_phone_number_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_phone_number_tb.Name = "employee_phone_number_tb";
            this.employee_phone_number_tb.Size = new System.Drawing.Size(272, 27);
            this.employee_phone_number_tb.TabIndex = 20;
            this.employee_phone_number_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_phone_number_tb_KeyPress);
            // 
            // employee_name_tb
            // 
            this.employee_name_tb.Location = new System.Drawing.Point(355, 133);
            this.employee_name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_name_tb.Name = "employee_name_tb";
            this.employee_name_tb.Size = new System.Drawing.Size(272, 27);
            this.employee_name_tb.TabIndex = 39;
            this.employee_name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_name_tb_KeyPress);
            // 
            // employee_name_lbl
            // 
            this.employee_name_lbl.AutoSize = true;
            this.employee_name_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee_name_lbl.ForeColor = System.Drawing.Color.White;
            this.employee_name_lbl.Location = new System.Drawing.Point(219, 137);
            this.employee_name_lbl.Name = "employee_name_lbl";
            this.employee_name_lbl.Size = new System.Drawing.Size(57, 23);
            this.employee_name_lbl.TabIndex = 40;
            this.employee_name_lbl.Text = "Name";
            // 
            // choose_button
            // 
            this.choose_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.choose_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_button.ForeColor = System.Drawing.Color.White;
            this.choose_button.Location = new System.Drawing.Point(668, 79);
            this.choose_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(148, 31);
            this.choose_button.TabIndex = 49;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = false;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // name_combob
            // 
            this.name_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combob.FormattingEnabled = true;
            this.name_combob.Location = new System.Drawing.Point(399, 133);
            this.name_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_combob.Name = "name_combob";
            this.name_combob.Size = new System.Drawing.Size(228, 28);
            this.name_combob.TabIndex = 61;
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Enabled = false;
            this.resultsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.resultsDataGrid.Location = new System.Drawing.Point(12, 176);
            this.resultsDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidth = 51;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(890, 309);
            this.resultsDataGrid.TabIndex = 63;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(355, 507);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(250, 45);
            this.add_button.TabIndex = 64;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 46);
            this.label1.TabIndex = 65;
            this.label1.Text = "MANAGERS";
            // 
            // managing_managers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.managing_employee_functionality_combob);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_update_panel);
            this.Controls.Add(this.employee_name_tb);
            this.Controls.Add(this.employee_name_lbl);
            this.Controls.Add(this.name_combob);
            this.Controls.Add(this.resultsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "managing_managers";
            this.Text = "managing_managers";
            this.Load += new System.EventHandler(this.managing_managers_Load);
            this.add_update_panel.ResumeLayout(false);
            this.add_update_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox managing_employee_functionality_combob;
        private Button remove_button;
        private Button search_button;
        private Button update_button;
        private Panel add_update_panel;
        private TextBox employee_SSN_tb;
        private ComboBox employee_gender_combob;
        private DateTimePicker employee_birth_date_db;
        private Label employee_SSN_lbl;
        private Label employee_address_lbl;
        private TextBox employee_address_tb;
        private Label employee_gender_lbl;
        private Label employee_phone_nmber_lbl;
        private Label device_birth_date_lbl;
        private TextBox employee_phone_number_tb;
        private TextBox manager_password_tb;
        private TextBox manager_email_tb;
        private Label receptionist_email_lbl;
        private Label receptionist_password_lbl;
        private TextBox employee_name_tb;
        private Label employee_name_lbl;
        private Button choose_button;
        private ComboBox name_combob;
        private DataGridView resultsDataGrid;
        private Button add_button;
        private Label label1;
    }
}