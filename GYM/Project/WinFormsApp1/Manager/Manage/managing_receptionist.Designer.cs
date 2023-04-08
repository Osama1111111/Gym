namespace WinFormsApp1
{
    partial class managing_receptionist
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
            this.managerSSN_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receptionist_password_tb = new System.Windows.Forms.TextBox();
            this.employee_SSN_tb = new System.Windows.Forms.TextBox();
            this.receptionist_email_tb = new System.Windows.Forms.TextBox();
            this.receptionist_email_lbl = new System.Windows.Forms.Label();
            this.employee_gender_cb = new System.Windows.Forms.ComboBox();
            this.receptionist_password_lbl = new System.Windows.Forms.Label();
            this.receptionist_skills_tb = new System.Windows.Forms.TextBox();
            this.employee_birth_date_db = new System.Windows.Forms.DateTimePicker();
            this.receptionist_skills_lbl = new System.Windows.Forms.Label();
            this.employee_SSN_lbl = new System.Windows.Forms.Label();
            this.employee_address_lbl = new System.Windows.Forms.Label();
            this.employee_address_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_lbl = new System.Windows.Forms.Label();
            this.employee_phone_nmber_lbl = new System.Windows.Forms.Label();
            this.device_birth_date_lbl = new System.Windows.Forms.Label();
            this.employee_phone_number_tb = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.employee_name_tb = new System.Windows.Forms.TextBox();
            this.employee_name_lbl = new System.Windows.Forms.Label();
            this.choose_button = new System.Windows.Forms.Button();
            this.name_combob = new System.Windows.Forms.ComboBox();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
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
            this.managing_employee_functionality_combob.Location = new System.Drawing.Point(374, 41);
            this.managing_employee_functionality_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managing_employee_functionality_combob.Name = "managing_employee_functionality_combob";
            this.managing_employee_functionality_combob.Size = new System.Drawing.Size(267, 28);
            this.managing_employee_functionality_combob.TabIndex = 48;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(374, 528);
            this.remove_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(250, 45);
            this.remove_button.TabIndex = 46;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(374, 528);
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
            this.update_button.Location = new System.Drawing.Point(374, 528);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(250, 45);
            this.update_button.TabIndex = 44;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_update_panel
            // 
            this.add_update_panel.Controls.Add(this.managerSSN_tb);
            this.add_update_panel.Controls.Add(this.label1);
            this.add_update_panel.Controls.Add(this.receptionist_password_tb);
            this.add_update_panel.Controls.Add(this.employee_SSN_tb);
            this.add_update_panel.Controls.Add(this.receptionist_email_tb);
            this.add_update_panel.Controls.Add(this.receptionist_email_lbl);
            this.add_update_panel.Controls.Add(this.employee_gender_cb);
            this.add_update_panel.Controls.Add(this.receptionist_password_lbl);
            this.add_update_panel.Controls.Add(this.receptionist_skills_tb);
            this.add_update_panel.Controls.Add(this.employee_birth_date_db);
            this.add_update_panel.Controls.Add(this.receptionist_skills_lbl);
            this.add_update_panel.Controls.Add(this.employee_SSN_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_nmber_lbl);
            this.add_update_panel.Controls.Add(this.device_birth_date_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_number_tb);
            this.add_update_panel.Location = new System.Drawing.Point(227, 115);
            this.add_update_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_update_panel.Name = "add_update_panel";
            this.add_update_panel.Size = new System.Drawing.Size(437, 405);
            this.add_update_panel.TabIndex = 47;
            // 
            // managerSSN_tb
            // 
            this.managerSSN_tb.Location = new System.Drawing.Point(147, 48);
            this.managerSSN_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managerSSN_tb.Name = "managerSSN_tb";
            this.managerSSN_tb.Size = new System.Drawing.Size(267, 27);
            this.managerSSN_tb.TabIndex = 31;
            this.managerSSN_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerSSN_tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manager SSN";
            // 
            // receptionist_password_tb
            // 
            this.receptionist_password_tb.Location = new System.Drawing.Point(147, 121);
            this.receptionist_password_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receptionist_password_tb.Name = "receptionist_password_tb";
            this.receptionist_password_tb.Size = new System.Drawing.Size(267, 27);
            this.receptionist_password_tb.TabIndex = 26;
            // 
            // employee_SSN_tb
            // 
            this.employee_SSN_tb.Location = new System.Drawing.Point(147, 13);
            this.employee_SSN_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_SSN_tb.Name = "employee_SSN_tb";
            this.employee_SSN_tb.Size = new System.Drawing.Size(267, 27);
            this.employee_SSN_tb.TabIndex = 12;
            this.employee_SSN_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_SSN_tb_KeyPress);
            // 
            // receptionist_email_tb
            // 
            this.receptionist_email_tb.Location = new System.Drawing.Point(147, 83);
            this.receptionist_email_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receptionist_email_tb.Name = "receptionist_email_tb";
            this.receptionist_email_tb.Size = new System.Drawing.Size(267, 27);
            this.receptionist_email_tb.TabIndex = 25;
            // 
            // receptionist_email_lbl
            // 
            this.receptionist_email_lbl.AutoSize = true;
            this.receptionist_email_lbl.Location = new System.Drawing.Point(21, 87);
            this.receptionist_email_lbl.Name = "receptionist_email_lbl";
            this.receptionist_email_lbl.Size = new System.Drawing.Size(46, 20);
            this.receptionist_email_lbl.TabIndex = 27;
            this.receptionist_email_lbl.Text = "Email";
            // 
            // employee_gender_cb
            // 
            this.employee_gender_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_gender_cb.FormattingEnabled = true;
            this.employee_gender_cb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.employee_gender_cb.Location = new System.Drawing.Point(147, 199);
            this.employee_gender_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_gender_cb.Name = "employee_gender_cb";
            this.employee_gender_cb.Size = new System.Drawing.Size(267, 28);
            this.employee_gender_cb.TabIndex = 11;
            // 
            // receptionist_password_lbl
            // 
            this.receptionist_password_lbl.AutoSize = true;
            this.receptionist_password_lbl.Location = new System.Drawing.Point(21, 125);
            this.receptionist_password_lbl.Name = "receptionist_password_lbl";
            this.receptionist_password_lbl.Size = new System.Drawing.Size(70, 20);
            this.receptionist_password_lbl.TabIndex = 28;
            this.receptionist_password_lbl.Text = "Password";
            // 
            // receptionist_skills_tb
            // 
            this.receptionist_skills_tb.Location = new System.Drawing.Point(147, 315);
            this.receptionist_skills_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receptionist_skills_tb.Multiline = true;
            this.receptionist_skills_tb.Name = "receptionist_skills_tb";
            this.receptionist_skills_tb.Size = new System.Drawing.Size(267, 68);
            this.receptionist_skills_tb.TabIndex = 30;
            // 
            // employee_birth_date_db
            // 
            this.employee_birth_date_db.CustomFormat = "";
            this.employee_birth_date_db.Location = new System.Drawing.Point(147, 276);
            this.employee_birth_date_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_birth_date_db.Name = "employee_birth_date_db";
            this.employee_birth_date_db.Size = new System.Drawing.Size(267, 27);
            this.employee_birth_date_db.TabIndex = 14;
            this.employee_birth_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // receptionist_skills_lbl
            // 
            this.receptionist_skills_lbl.AutoSize = true;
            this.receptionist_skills_lbl.Location = new System.Drawing.Point(24, 319);
            this.receptionist_skills_lbl.Name = "receptionist_skills_lbl";
            this.receptionist_skills_lbl.Size = new System.Drawing.Size(42, 20);
            this.receptionist_skills_lbl.TabIndex = 29;
            this.receptionist_skills_lbl.Text = "Skills";
            // 
            // employee_SSN_lbl
            // 
            this.employee_SSN_lbl.AutoSize = true;
            this.employee_SSN_lbl.Location = new System.Drawing.Point(24, 17);
            this.employee_SSN_lbl.Name = "employee_SSN_lbl";
            this.employee_SSN_lbl.Size = new System.Drawing.Size(36, 20);
            this.employee_SSN_lbl.TabIndex = 15;
            this.employee_SSN_lbl.Text = "SSN";
            // 
            // employee_address_lbl
            // 
            this.employee_address_lbl.AutoSize = true;
            this.employee_address_lbl.Location = new System.Drawing.Point(24, 164);
            this.employee_address_lbl.Name = "employee_address_lbl";
            this.employee_address_lbl.Size = new System.Drawing.Size(62, 20);
            this.employee_address_lbl.TabIndex = 17;
            this.employee_address_lbl.Text = "Address";
            // 
            // employee_address_tb
            // 
            this.employee_address_tb.Location = new System.Drawing.Point(147, 160);
            this.employee_address_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_address_tb.Name = "employee_address_tb";
            this.employee_address_tb.Size = new System.Drawing.Size(267, 27);
            this.employee_address_tb.TabIndex = 22;
            // 
            // employee_gender_lbl
            // 
            this.employee_gender_lbl.AutoSize = true;
            this.employee_gender_lbl.Location = new System.Drawing.Point(24, 203);
            this.employee_gender_lbl.Name = "employee_gender_lbl";
            this.employee_gender_lbl.Size = new System.Drawing.Size(57, 20);
            this.employee_gender_lbl.TabIndex = 18;
            this.employee_gender_lbl.Text = "Gender";
            // 
            // employee_phone_nmber_lbl
            // 
            this.employee_phone_nmber_lbl.AutoSize = true;
            this.employee_phone_nmber_lbl.Location = new System.Drawing.Point(24, 241);
            this.employee_phone_nmber_lbl.Name = "employee_phone_nmber_lbl";
            this.employee_phone_nmber_lbl.Size = new System.Drawing.Size(108, 20);
            this.employee_phone_nmber_lbl.TabIndex = 21;
            this.employee_phone_nmber_lbl.Text = "Phone Number";
            // 
            // device_birth_date_lbl
            // 
            this.device_birth_date_lbl.AutoSize = true;
            this.device_birth_date_lbl.Location = new System.Drawing.Point(24, 284);
            this.device_birth_date_lbl.Name = "device_birth_date_lbl";
            this.device_birth_date_lbl.Size = new System.Drawing.Size(76, 20);
            this.device_birth_date_lbl.TabIndex = 19;
            this.device_birth_date_lbl.Text = "Birht Date";
            // 
            // employee_phone_number_tb
            // 
            this.employee_phone_number_tb.Location = new System.Drawing.Point(147, 237);
            this.employee_phone_number_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_phone_number_tb.Name = "employee_phone_number_tb";
            this.employee_phone_number_tb.Size = new System.Drawing.Size(267, 27);
            this.employee_phone_number_tb.TabIndex = 20;
            this.employee_phone_number_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_phone_number_tb_KeyPress);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(374, 528);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(250, 45);
            this.add_button.TabIndex = 43;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // employee_name_tb
            // 
            this.employee_name_tb.Location = new System.Drawing.Point(374, 80);
            this.employee_name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_name_tb.Name = "employee_name_tb";
            this.employee_name_tb.Size = new System.Drawing.Size(267, 27);
            this.employee_name_tb.TabIndex = 39;
            this.employee_name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_name_tb_KeyPress);
            // 
            // employee_name_lbl
            // 
            this.employee_name_lbl.AutoSize = true;
            this.employee_name_lbl.Location = new System.Drawing.Point(250, 84);
            this.employee_name_lbl.Name = "employee_name_lbl";
            this.employee_name_lbl.Size = new System.Drawing.Size(49, 20);
            this.employee_name_lbl.TabIndex = 40;
            this.employee_name_lbl.Text = "Name";
            // 
            // choose_button
            // 
            this.choose_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.choose_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_button.ForeColor = System.Drawing.Color.White;
            this.choose_button.Location = new System.Drawing.Point(676, 41);
            this.choose_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(134, 31);
            this.choose_button.TabIndex = 59;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = false;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // name_combob
            // 
            this.name_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combob.FormattingEnabled = true;
            this.name_combob.Location = new System.Drawing.Point(374, 80);
            this.name_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_combob.Name = "name_combob";
            this.name_combob.Size = new System.Drawing.Size(267, 28);
            this.name_combob.TabIndex = 60;
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Enabled = false;
            this.resultsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.resultsDataGrid.Location = new System.Drawing.Point(27, 116);
            this.resultsDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsDataGrid.MultiSelect = false;
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.ReadOnly = true;
            this.resultsDataGrid.RowHeadersWidth = 51;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(858, 404);
            this.resultsDataGrid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 38);
            this.label2.TabIndex = 61;
            this.label2.Text = "RECEPTIONISTS";
            // 
            // managing_receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.managing_employee_functionality_combob);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_update_panel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.employee_name_tb);
            this.Controls.Add(this.employee_name_lbl);
            this.Controls.Add(this.name_combob);
            this.Controls.Add(this.resultsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "managing_receptionist";
            this.Text = "managing_receptionist";
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
        private ComboBox employee_gender_cb;
        private DateTimePicker employee_birth_date_db;
        private Label employee_SSN_lbl;
        private Label employee_address_lbl;
        private TextBox employee_address_tb;
        private Label employee_gender_lbl;
        private Label employee_phone_nmber_lbl;
        private Label device_birth_date_lbl;
        private TextBox employee_phone_number_tb;
        private TextBox receptionist_password_tb;
        private TextBox receptionist_email_tb;
        private TextBox receptionist_skills_tb;
        private Label receptionist_email_lbl;
        private Label receptionist_skills_lbl;
        private Label receptionist_password_lbl;
        private Button add_button;
        private TextBox employee_name_tb;
        private Label employee_name_lbl;
        private Button choose_button;
        private ComboBox name_combob;
        private TextBox managerSSN_tb;
        private Label label1;
        private DataGridView resultsDataGrid;
        private Label label2;
    }
}