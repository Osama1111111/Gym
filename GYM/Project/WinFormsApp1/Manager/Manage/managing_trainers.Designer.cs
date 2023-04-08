namespace WinFormsApp1
{
    partial class managing_trainers
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
            this.employee_SSN_tb = new System.Windows.Forms.TextBox();
            this.employee_gender_combob = new System.Windows.Forms.ComboBox();
            this.trainer_certificates_tb = new System.Windows.Forms.TextBox();
            this.trainer_certificates_lbl = new System.Windows.Forms.Label();
            this.employee_birth_date_db = new System.Windows.Forms.DateTimePicker();
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
            this.managing_employee_functionality_combob.Location = new System.Drawing.Point(219, 46);
            this.managing_employee_functionality_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managing_employee_functionality_combob.Name = "managing_employee_functionality_combob";
            this.managing_employee_functionality_combob.Size = new System.Drawing.Size(436, 28);
            this.managing_employee_functionality_combob.TabIndex = 57;
            // 
            // remove_button
            // 
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(354, 518);
            this.remove_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(250, 45);
            this.remove_button.TabIndex = 55;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // search_button
            // 
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(354, 518);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(250, 45);
            this.search_button.TabIndex = 54;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // update_button
            // 
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(354, 518);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(250, 45);
            this.update_button.TabIndex = 53;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_update_panel
            // 
            this.add_update_panel.Controls.Add(this.managerSSN_tb);
            this.add_update_panel.Controls.Add(this.label1);
            this.add_update_panel.Controls.Add(this.employee_SSN_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_combob);
            this.add_update_panel.Controls.Add(this.trainer_certificates_tb);
            this.add_update_panel.Controls.Add(this.trainer_certificates_lbl);
            this.add_update_panel.Controls.Add(this.employee_birth_date_db);
            this.add_update_panel.Controls.Add(this.employee_SSN_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_lbl);
            this.add_update_panel.Controls.Add(this.employee_address_tb);
            this.add_update_panel.Controls.Add(this.employee_gender_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_nmber_lbl);
            this.add_update_panel.Controls.Add(this.device_birth_date_lbl);
            this.add_update_panel.Controls.Add(this.employee_phone_number_tb);
            this.add_update_panel.Location = new System.Drawing.Point(218, 129);
            this.add_update_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_update_panel.Name = "add_update_panel";
            this.add_update_panel.Size = new System.Drawing.Size(437, 381);
            this.add_update_panel.TabIndex = 56;
            // 
            // managerSSN_tb
            // 
            this.managerSSN_tb.Location = new System.Drawing.Point(135, 43);
            this.managerSSN_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managerSSN_tb.Name = "managerSSN_tb";
            this.managerSSN_tb.Size = new System.Drawing.Size(279, 27);
            this.managerSSN_tb.TabIndex = 33;
            this.managerSSN_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerSSN_tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Manager SSN";
            // 
            // employee_SSN_tb
            // 
            this.employee_SSN_tb.Location = new System.Drawing.Point(135, 4);
            this.employee_SSN_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_SSN_tb.Name = "employee_SSN_tb";
            this.employee_SSN_tb.Size = new System.Drawing.Size(279, 27);
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
            this.employee_gender_combob.Location = new System.Drawing.Point(135, 120);
            this.employee_gender_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_gender_combob.Name = "employee_gender_combob";
            this.employee_gender_combob.Size = new System.Drawing.Size(279, 28);
            this.employee_gender_combob.TabIndex = 11;
            // 
            // trainer_certificates_tb
            // 
            this.trainer_certificates_tb.Location = new System.Drawing.Point(135, 236);
            this.trainer_certificates_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainer_certificates_tb.Multiline = true;
            this.trainer_certificates_tb.Name = "trainer_certificates_tb";
            this.trainer_certificates_tb.Size = new System.Drawing.Size(279, 61);
            this.trainer_certificates_tb.TabIndex = 23;
            // 
            // trainer_certificates_lbl
            // 
            this.trainer_certificates_lbl.AutoSize = true;
            this.trainer_certificates_lbl.Location = new System.Drawing.Point(24, 256);
            this.trainer_certificates_lbl.Name = "trainer_certificates_lbl";
            this.trainer_certificates_lbl.Size = new System.Drawing.Size(83, 20);
            this.trainer_certificates_lbl.TabIndex = 24;
            this.trainer_certificates_lbl.Text = "Certificates";
            // 
            // employee_birth_date_db
            // 
            this.employee_birth_date_db.Location = new System.Drawing.Point(135, 197);
            this.employee_birth_date_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_birth_date_db.Name = "employee_birth_date_db";
            this.employee_birth_date_db.Size = new System.Drawing.Size(279, 27);
            this.employee_birth_date_db.TabIndex = 14;
            this.employee_birth_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // employee_SSN_lbl
            // 
            this.employee_SSN_lbl.AutoSize = true;
            this.employee_SSN_lbl.Location = new System.Drawing.Point(24, 8);
            this.employee_SSN_lbl.Name = "employee_SSN_lbl";
            this.employee_SSN_lbl.Size = new System.Drawing.Size(36, 20);
            this.employee_SSN_lbl.TabIndex = 15;
            this.employee_SSN_lbl.Text = "SSN";
            // 
            // employee_address_lbl
            // 
            this.employee_address_lbl.AutoSize = true;
            this.employee_address_lbl.Location = new System.Drawing.Point(24, 85);
            this.employee_address_lbl.Name = "employee_address_lbl";
            this.employee_address_lbl.Size = new System.Drawing.Size(62, 20);
            this.employee_address_lbl.TabIndex = 17;
            this.employee_address_lbl.Text = "Address";
            // 
            // employee_address_tb
            // 
            this.employee_address_tb.Location = new System.Drawing.Point(135, 81);
            this.employee_address_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_address_tb.Name = "employee_address_tb";
            this.employee_address_tb.Size = new System.Drawing.Size(279, 27);
            this.employee_address_tb.TabIndex = 22;
            // 
            // employee_gender_lbl
            // 
            this.employee_gender_lbl.AutoSize = true;
            this.employee_gender_lbl.Location = new System.Drawing.Point(24, 124);
            this.employee_gender_lbl.Name = "employee_gender_lbl";
            this.employee_gender_lbl.Size = new System.Drawing.Size(57, 20);
            this.employee_gender_lbl.TabIndex = 18;
            this.employee_gender_lbl.Text = "Gender";
            // 
            // employee_phone_nmber_lbl
            // 
            this.employee_phone_nmber_lbl.AutoSize = true;
            this.employee_phone_nmber_lbl.Location = new System.Drawing.Point(24, 163);
            this.employee_phone_nmber_lbl.Name = "employee_phone_nmber_lbl";
            this.employee_phone_nmber_lbl.Size = new System.Drawing.Size(108, 20);
            this.employee_phone_nmber_lbl.TabIndex = 21;
            this.employee_phone_nmber_lbl.Text = "Phone Number";
            // 
            // device_birth_date_lbl
            // 
            this.device_birth_date_lbl.AutoSize = true;
            this.device_birth_date_lbl.Location = new System.Drawing.Point(24, 205);
            this.device_birth_date_lbl.Name = "device_birth_date_lbl";
            this.device_birth_date_lbl.Size = new System.Drawing.Size(76, 20);
            this.device_birth_date_lbl.TabIndex = 19;
            this.device_birth_date_lbl.Text = "Birht Date";
            // 
            // employee_phone_number_tb
            // 
            this.employee_phone_number_tb.Location = new System.Drawing.Point(135, 159);
            this.employee_phone_number_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_phone_number_tb.Name = "employee_phone_number_tb";
            this.employee_phone_number_tb.Size = new System.Drawing.Size(279, 27);
            this.employee_phone_number_tb.TabIndex = 20;
            this.employee_phone_number_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_phone_number_tb_KeyPress);
            // 
            // add_button
            // 
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(354, 518);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(250, 45);
            this.add_button.TabIndex = 52;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // employee_name_tb
            // 
            this.employee_name_tb.Location = new System.Drawing.Point(354, 91);
            this.employee_name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_name_tb.Name = "employee_name_tb";
            this.employee_name_tb.Size = new System.Drawing.Size(279, 27);
            this.employee_name_tb.TabIndex = 49;
            this.employee_name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employee_name_tb_KeyPress);
            // 
            // employee_name_lbl
            // 
            this.employee_name_lbl.AutoSize = true;
            this.employee_name_lbl.Location = new System.Drawing.Point(242, 95);
            this.employee_name_lbl.Name = "employee_name_lbl";
            this.employee_name_lbl.Size = new System.Drawing.Size(49, 20);
            this.employee_name_lbl.TabIndex = 50;
            this.employee_name_lbl.Text = "Name";
            // 
            // choose_button
            // 
            this.choose_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_button.ForeColor = System.Drawing.Color.White;
            this.choose_button.Location = new System.Drawing.Point(702, 43);
            this.choose_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(130, 31);
            this.choose_button.TabIndex = 58;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // name_combob
            // 
            this.name_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combob.FormattingEnabled = true;
            this.name_combob.Location = new System.Drawing.Point(404, 91);
            this.name_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_combob.Name = "name_combob";
            this.name_combob.Size = new System.Drawing.Size(229, 28);
            this.name_combob.TabIndex = 61;
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Enabled = false;
            this.resultsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.resultsDataGrid.Location = new System.Drawing.Point(30, 129);
            this.resultsDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidth = 51;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(858, 381);
            this.resultsDataGrid.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 46);
            this.label2.TabIndex = 63;
            this.label2.Text = "TRAINERS";
            // 
            // managing_trainers
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
            this.Name = "managing_trainers";
            this.Text = "managing_traniers";
            this.Load += new System.EventHandler(this.managing_traniers_Load);
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
        private Button add_button;
        private TextBox employee_name_tb;
        private Label employee_name_lbl;
        private TextBox trainer_certificates_tb;
        private Label trainer_certificates_lbl;
        private Button choose_button;
        private ComboBox name_combob;
        private DataGridView resultsDataGrid;
        private TextBox managerSSN_tb;
        private Label label1;
        private Label label2;
    }
}