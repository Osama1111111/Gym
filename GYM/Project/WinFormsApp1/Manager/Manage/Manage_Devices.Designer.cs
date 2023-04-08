namespace WinFormsApp1
{
    partial class Manage_Devices
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
            this.device_manufacturer_name_combob = new System.Windows.Forms.ComboBox();
            this.device_muscles_group_combob = new System.Windows.Forms.ComboBox();
            this.device_id_tb = new System.Windows.Forms.TextBox();
            this.device_name_tb = new System.Windows.Forms.TextBox();
            this.device_date_of_purchase_db = new System.Windows.Forms.DateTimePicker();
            this.device_id_lbl = new System.Windows.Forms.Label();
            this.device_name_lbl = new System.Windows.Forms.Label();
            this.device_name_of_nanufacturer_lbl = new System.Windows.Forms.Label();
            this.device_muscles_group_lbl = new System.Windows.Forms.Label();
            this.device_data_of_purchase_lbl = new System.Windows.Forms.Label();
            this.remove_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_update_panel = new System.Windows.Forms.Panel();
            this.devices_supervised_checklist = new System.Windows.Forms.CheckedListBox();
            this.device_supervised_by_lbl = new System.Windows.Forms.Label();
            this.managing_devices_combob = new System.Windows.Forms.ComboBox();
            this.choose_button = new System.Windows.Forms.Button();
            this.name_combob = new System.Windows.Forms.ComboBox();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_update_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // device_manufacturer_name_combob
            // 
            this.device_manufacturer_name_combob.FormattingEnabled = true;
            this.device_manufacturer_name_combob.Items.AddRange(new object[] {
            "TechnoGym",
            "Cybex",
            "Yanre",
            "Precor",
            "Life Fitness",
            "Iron Company"});
            this.device_manufacturer_name_combob.Location = new System.Drawing.Point(198, 43);
            this.device_manufacturer_name_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.device_manufacturer_name_combob.Name = "device_manufacturer_name_combob";
            this.device_manufacturer_name_combob.Size = new System.Drawing.Size(228, 28);
            this.device_manufacturer_name_combob.TabIndex = 0;
            // 
            // device_muscles_group_combob
            // 
            this.device_muscles_group_combob.FormattingEnabled = true;
            this.device_muscles_group_combob.Items.AddRange(new object[] {
            "Arms",
            "Chest",
            "Back",
            "Abdominals",
            "Shoulders",
            "Legs"});
            this.device_muscles_group_combob.Location = new System.Drawing.Point(198, 81);
            this.device_muscles_group_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.device_muscles_group_combob.Name = "device_muscles_group_combob";
            this.device_muscles_group_combob.Size = new System.Drawing.Size(228, 28);
            this.device_muscles_group_combob.TabIndex = 1;
            // 
            // device_id_tb
            // 
            this.device_id_tb.Location = new System.Drawing.Point(198, 4);
            this.device_id_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.device_id_tb.Name = "device_id_tb";
            this.device_id_tb.Size = new System.Drawing.Size(228, 27);
            this.device_id_tb.TabIndex = 2;
            this.device_id_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.device_name_tb_KeyPress);
            // 
            // device_name_tb
            // 
            this.device_name_tb.AllowDrop = true;
            this.device_name_tb.Location = new System.Drawing.Point(416, 116);
            this.device_name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.device_name_tb.Name = "device_name_tb";
            this.device_name_tb.Size = new System.Drawing.Size(228, 27);
            this.device_name_tb.TabIndex = 3;
            this.device_name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.device_name_tb_KeyPress);
            // 
            // device_date_of_purchase_db
            // 
            this.device_date_of_purchase_db.Location = new System.Drawing.Point(198, 120);
            this.device_date_of_purchase_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.device_date_of_purchase_db.Name = "device_date_of_purchase_db";
            this.device_date_of_purchase_db.Size = new System.Drawing.Size(228, 27);
            this.device_date_of_purchase_db.TabIndex = 4;
            this.device_date_of_purchase_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // device_id_lbl
            // 
            this.device_id_lbl.AutoSize = true;
            this.device_id_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_id_lbl.ForeColor = System.Drawing.Color.White;
            this.device_id_lbl.Location = new System.Drawing.Point(3, 8);
            this.device_id_lbl.Name = "device_id_lbl";
            this.device_id_lbl.Size = new System.Drawing.Size(86, 23);
            this.device_id_lbl.TabIndex = 5;
            this.device_id_lbl.Text = "Device ID";
            // 
            // device_name_lbl
            // 
            this.device_name_lbl.AutoSize = true;
            this.device_name_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_name_lbl.ForeColor = System.Drawing.Color.White;
            this.device_name_lbl.Location = new System.Drawing.Point(218, 120);
            this.device_name_lbl.Name = "device_name_lbl";
            this.device_name_lbl.Size = new System.Drawing.Size(112, 23);
            this.device_name_lbl.TabIndex = 6;
            this.device_name_lbl.Text = "Device name";
            // 
            // device_name_of_nanufacturer_lbl
            // 
            this.device_name_of_nanufacturer_lbl.AutoSize = true;
            this.device_name_of_nanufacturer_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_name_of_nanufacturer_lbl.ForeColor = System.Drawing.Color.White;
            this.device_name_of_nanufacturer_lbl.Location = new System.Drawing.Point(3, 47);
            this.device_name_of_nanufacturer_lbl.Name = "device_name_of_nanufacturer_lbl";
            this.device_name_of_nanufacturer_lbl.Size = new System.Drawing.Size(193, 23);
            this.device_name_of_nanufacturer_lbl.TabIndex = 7;
            this.device_name_of_nanufacturer_lbl.Text = "Name of manufacturer";
            // 
            // device_muscles_group_lbl
            // 
            this.device_muscles_group_lbl.AutoSize = true;
            this.device_muscles_group_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_muscles_group_lbl.ForeColor = System.Drawing.Color.White;
            this.device_muscles_group_lbl.Location = new System.Drawing.Point(6, 85);
            this.device_muscles_group_lbl.Name = "device_muscles_group_lbl";
            this.device_muscles_group_lbl.Size = new System.Drawing.Size(131, 23);
            this.device_muscles_group_lbl.TabIndex = 8;
            this.device_muscles_group_lbl.Text = "Muscles group ";
            // 
            // device_data_of_purchase_lbl
            // 
            this.device_data_of_purchase_lbl.AutoSize = true;
            this.device_data_of_purchase_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_data_of_purchase_lbl.ForeColor = System.Drawing.Color.White;
            this.device_data_of_purchase_lbl.Location = new System.Drawing.Point(6, 128);
            this.device_data_of_purchase_lbl.Name = "device_data_of_purchase_lbl";
            this.device_data_of_purchase_lbl.Size = new System.Drawing.Size(146, 23);
            this.device_data_of_purchase_lbl.TabIndex = 9;
            this.device_data_of_purchase_lbl.Text = "Date of purchase";
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(317, 510);
            this.remove_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(250, 45);
            this.remove_button.TabIndex = 40;
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
            this.search_button.Location = new System.Drawing.Point(317, 510);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(250, 45);
            this.search_button.TabIndex = 39;
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
            this.update_button.Location = new System.Drawing.Point(317, 510);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(250, 45);
            this.update_button.TabIndex = 38;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(317, 510);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(250, 45);
            this.add_button.TabIndex = 37;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_update_panel
            // 
            this.add_update_panel.Controls.Add(this.devices_supervised_checklist);
            this.add_update_panel.Controls.Add(this.device_supervised_by_lbl);
            this.add_update_panel.Controls.Add(this.device_data_of_purchase_lbl);
            this.add_update_panel.Controls.Add(this.device_muscles_group_lbl);
            this.add_update_panel.Controls.Add(this.device_name_of_nanufacturer_lbl);
            this.add_update_panel.Controls.Add(this.device_id_lbl);
            this.add_update_panel.Controls.Add(this.device_date_of_purchase_db);
            this.add_update_panel.Controls.Add(this.device_id_tb);
            this.add_update_panel.Controls.Add(this.device_muscles_group_combob);
            this.add_update_panel.Controls.Add(this.device_manufacturer_name_combob);
            this.add_update_panel.Location = new System.Drawing.Point(218, 155);
            this.add_update_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_update_panel.Name = "add_update_panel";
            this.add_update_panel.Size = new System.Drawing.Size(438, 252);
            this.add_update_panel.TabIndex = 41;
            // 
            // devices_supervised_checklist
            // 
            this.devices_supervised_checklist.FormattingEnabled = true;
            this.devices_supervised_checklist.Items.AddRange(new object[] {
            "pla pla",
            "podk",
            "[dsockp"});
            this.devices_supervised_checklist.Location = new System.Drawing.Point(198, 159);
            this.devices_supervised_checklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.devices_supervised_checklist.Name = "devices_supervised_checklist";
            this.devices_supervised_checklist.ScrollAlwaysVisible = true;
            this.devices_supervised_checklist.Size = new System.Drawing.Size(228, 48);
            this.devices_supervised_checklist.TabIndex = 65;
            // 
            // device_supervised_by_lbl
            // 
            this.device_supervised_by_lbl.AutoSize = true;
            this.device_supervised_by_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_supervised_by_lbl.ForeColor = System.Drawing.Color.White;
            this.device_supervised_by_lbl.Location = new System.Drawing.Point(3, 159);
            this.device_supervised_by_lbl.Name = "device_supervised_by_lbl";
            this.device_supervised_by_lbl.Size = new System.Drawing.Size(124, 23);
            this.device_supervised_by_lbl.TabIndex = 64;
            this.device_supervised_by_lbl.Text = "Supervised by";
            // 
            // managing_devices_combob
            // 
            this.managing_devices_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managing_devices_combob.FormattingEnabled = true;
            this.managing_devices_combob.Items.AddRange(new object[] {
            "Add Device",
            "Update Device",
            "Remove Device",
            "Search for Device"});
            this.managing_devices_combob.Location = new System.Drawing.Point(224, 61);
            this.managing_devices_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managing_devices_combob.Name = "managing_devices_combob";
            this.managing_devices_combob.Size = new System.Drawing.Size(433, 28);
            this.managing_devices_combob.TabIndex = 42;
            // 
            // choose_button
            // 
            this.choose_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.choose_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_button.ForeColor = System.Drawing.Color.White;
            this.choose_button.Location = new System.Drawing.Point(698, 61);
            this.choose_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(138, 31);
            this.choose_button.TabIndex = 50;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = false;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // name_combob
            // 
            this.name_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combob.FormattingEnabled = true;
            this.name_combob.Location = new System.Drawing.Point(416, 116);
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
            this.resultsDataGrid.Location = new System.Drawing.Point(29, 155);
            this.resultsDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidth = 51;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(858, 309);
            this.resultsDataGrid.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "DEVICES";
            // 
            // Manage_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.add_update_panel);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.managing_devices_combob);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.device_name_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.device_name_lbl);
            this.Controls.Add(this.name_combob);
            this.Controls.Add(this.resultsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Manage_Devices";
            this.Text = "Manage_Devices";
            this.Load += new System.EventHandler(this.Manage_Devices_Load);
            this.add_update_panel.ResumeLayout(false);
            this.add_update_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox device_manufacturer_name_combob;
        private ComboBox device_muscles_group_combob;
        private TextBox device_id_tb;
        private TextBox device_name_tb;
        private DateTimePicker device_date_of_purchase_db;
        private Label device_id_lbl;
        private Label device_name_lbl;
        private Label device_name_of_nanufacturer_lbl;
        private Label device_muscles_group_lbl;
        private Label device_data_of_purchase_lbl;
        private Button remove_button;
        private Button search_button;
        private Button update_button;
        private Button add_button;
        private Panel add_update_panel;
        private ComboBox managing_devices_combob;
        private Button choose_button;
        private ComboBox name_combob;
        private DataGridView resultsDataGrid;
        private CheckedListBox devices_supervised_checklist;
        private Label device_supervised_by_lbl;
        private Label label1;
    }
}