namespace WinFormsApp1
{
    partial class Manage_Salaries
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
            this.managing_salaries_combob = new System.Windows.Forms.ComboBox();
            this.choose_button = new System.Windows.Forms.Button();
            this.salary_SSN_db = new System.Windows.Forms.TextBox();
            this.salary_date_db = new System.Windows.Forms.DateTimePicker();
            this.salary_SSN_lbl = new System.Windows.Forms.Label();
            this.salary_date_lbl = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_update_salary_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salary_gross_lbl = new System.Windows.Forms.Label();
            this.salary_gross_db = new System.Windows.Forms.TextBox();
            this.salary_taxes_lbl = new System.Windows.Forms.Label();
            this.salary_taxes_db = new System.Windows.Forms.TextBox();
            this.salary_penalty_db = new System.Windows.Forms.TextBox();
            this.salary_bonus_lbl = new System.Windows.Forms.Label();
            this.salary_penalty_lbl = new System.Windows.Forms.Label();
            this.salary_bonus_db = new System.Windows.Forms.TextBox();
            this.all_salaries_dgv = new System.Windows.Forms.DataGridView();
            this.panel_date = new System.Windows.Forms.Panel();
            this.panel_ssn = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.add_update_salary_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_salaries_dgv)).BeginInit();
            this.panel_date.SuspendLayout();
            this.panel_ssn.SuspendLayout();
            this.SuspendLayout();
            // 
            // managing_salaries_combob
            // 
            this.managing_salaries_combob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managing_salaries_combob.FormattingEnabled = true;
            this.managing_salaries_combob.Items.AddRange(new object[] {
            "Add Salary",
            "Update Salary",
            "Search for an Employee Salary In Certain Month",
            "Search for All Employees Salaries In Certain Month",
            "Search for an Employee All Salaries"});
            this.managing_salaries_combob.Location = new System.Drawing.Point(216, 77);
            this.managing_salaries_combob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managing_salaries_combob.Name = "managing_salaries_combob";
            this.managing_salaries_combob.Size = new System.Drawing.Size(438, 28);
            this.managing_salaries_combob.TabIndex = 52;
            // 
            // choose_button
            // 
            this.choose_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.choose_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_button.ForeColor = System.Drawing.Color.White;
            this.choose_button.Location = new System.Drawing.Point(675, 76);
            this.choose_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(135, 31);
            this.choose_button.TabIndex = 53;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = false;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // salary_SSN_db
            // 
            this.salary_SSN_db.Location = new System.Drawing.Point(190, 0);
            this.salary_SSN_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary_SSN_db.Name = "salary_SSN_db";
            this.salary_SSN_db.Size = new System.Drawing.Size(228, 27);
            this.salary_SSN_db.TabIndex = 12;
            this.salary_SSN_db.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_SSN_db_KeyPress);
            // 
            // salary_date_db
            // 
            this.salary_date_db.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salary_date_db.Location = new System.Drawing.Point(189, 1);
            this.salary_date_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary_date_db.Name = "salary_date_db";
            this.salary_date_db.Size = new System.Drawing.Size(228, 27);
            this.salary_date_db.TabIndex = 14;
            this.salary_date_db.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // salary_SSN_lbl
            // 
            this.salary_SSN_lbl.AutoSize = true;
            this.salary_SSN_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary_SSN_lbl.ForeColor = System.Drawing.Color.White;
            this.salary_SSN_lbl.Location = new System.Drawing.Point(27, 4);
            this.salary_SSN_lbl.Name = "salary_SSN_lbl";
            this.salary_SSN_lbl.Size = new System.Drawing.Size(126, 23);
            this.salary_SSN_lbl.TabIndex = 15;
            this.salary_SSN_lbl.Text = "Employee SSN";
            // 
            // salary_date_lbl
            // 
            this.salary_date_lbl.AutoSize = true;
            this.salary_date_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary_date_lbl.ForeColor = System.Drawing.Color.White;
            this.salary_date_lbl.Location = new System.Drawing.Point(26, 9);
            this.salary_date_lbl.Name = "salary_date_lbl";
            this.salary_date_lbl.Size = new System.Drawing.Size(48, 23);
            this.salary_date_lbl.TabIndex = 19;
            this.salary_date_lbl.Text = "Date";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(314, 500);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(250, 45);
            this.search_button.TabIndex = 57;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click_1);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(314, 500);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(250, 45);
            this.update_button.TabIndex = 56;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(313, 500);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(250, 45);
            this.add_button.TabIndex = 55;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_update_salary_panel
            // 
            this.add_update_salary_panel.Controls.Add(this.label4);
            this.add_update_salary_panel.Controls.Add(this.label3);
            this.add_update_salary_panel.Controls.Add(this.label2);
            this.add_update_salary_panel.Controls.Add(this.label1);
            this.add_update_salary_panel.Controls.Add(this.salary_gross_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_gross_db);
            this.add_update_salary_panel.Controls.Add(this.salary_taxes_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_taxes_db);
            this.add_update_salary_panel.Controls.Add(this.salary_penalty_db);
            this.add_update_salary_panel.Controls.Add(this.salary_bonus_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_penalty_lbl);
            this.add_update_salary_panel.Controls.Add(this.salary_bonus_db);
            this.add_update_salary_panel.Location = new System.Drawing.Point(216, 200);
            this.add_update_salary_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_update_salary_panel.Name = "add_update_salary_panel";
            this.add_update_salary_panel.Size = new System.Drawing.Size(438, 168);
            this.add_update_salary_panel.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "LE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(407, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "LE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(407, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "LE";
            // 
            // salary_gross_lbl
            // 
            this.salary_gross_lbl.AutoSize = true;
            this.salary_gross_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary_gross_lbl.ForeColor = System.Drawing.Color.White;
            this.salary_gross_lbl.Location = new System.Drawing.Point(14, 9);
            this.salary_gross_lbl.Name = "salary_gross_lbl";
            this.salary_gross_lbl.Size = new System.Drawing.Size(108, 23);
            this.salary_gross_lbl.TabIndex = 41;
            this.salary_gross_lbl.Text = "Gross Salary";
            // 
            // salary_gross_db
            // 
            this.salary_gross_db.Location = new System.Drawing.Point(176, 5);
            this.salary_gross_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary_gross_db.Name = "salary_gross_db";
            this.salary_gross_db.Size = new System.Drawing.Size(228, 27);
            this.salary_gross_db.TabIndex = 42;
            this.salary_gross_db.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_gross_db_KeyPress);
            // 
            // salary_taxes_lbl
            // 
            this.salary_taxes_lbl.AutoSize = true;
            this.salary_taxes_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary_taxes_lbl.ForeColor = System.Drawing.Color.White;
            this.salary_taxes_lbl.Location = new System.Drawing.Point(14, 48);
            this.salary_taxes_lbl.Name = "salary_taxes_lbl";
            this.salary_taxes_lbl.Size = new System.Drawing.Size(146, 23);
            this.salary_taxes_lbl.TabIndex = 39;
            this.salary_taxes_lbl.Text = "Taxes Percentage";
            // 
            // salary_taxes_db
            // 
            this.salary_taxes_db.Location = new System.Drawing.Point(176, 44);
            this.salary_taxes_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary_taxes_db.Name = "salary_taxes_db";
            this.salary_taxes_db.Size = new System.Drawing.Size(228, 27);
            this.salary_taxes_db.TabIndex = 40;
            this.salary_taxes_db.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_taxes_db_KeyPress);
            // 
            // salary_penalty_db
            // 
            this.salary_penalty_db.Location = new System.Drawing.Point(176, 121);
            this.salary_penalty_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary_penalty_db.Name = "salary_penalty_db";
            this.salary_penalty_db.Size = new System.Drawing.Size(228, 27);
            this.salary_penalty_db.TabIndex = 20;
            this.salary_penalty_db.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_penalty_db_KeyPress);
            // 
            // salary_bonus_lbl
            // 
            this.salary_bonus_lbl.AutoSize = true;
            this.salary_bonus_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary_bonus_lbl.ForeColor = System.Drawing.Color.White;
            this.salary_bonus_lbl.Location = new System.Drawing.Point(14, 87);
            this.salary_bonus_lbl.Name = "salary_bonus_lbl";
            this.salary_bonus_lbl.Size = new System.Drawing.Size(58, 23);
            this.salary_bonus_lbl.TabIndex = 17;
            this.salary_bonus_lbl.Text = "Bonus";
            // 
            // salary_penalty_lbl
            // 
            this.salary_penalty_lbl.AutoSize = true;
            this.salary_penalty_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary_penalty_lbl.ForeColor = System.Drawing.Color.White;
            this.salary_penalty_lbl.Location = new System.Drawing.Point(14, 125);
            this.salary_penalty_lbl.Name = "salary_penalty_lbl";
            this.salary_penalty_lbl.Size = new System.Drawing.Size(68, 23);
            this.salary_penalty_lbl.TabIndex = 21;
            this.salary_penalty_lbl.Text = "Penalty";
            // 
            // salary_bonus_db
            // 
            this.salary_bonus_db.Location = new System.Drawing.Point(176, 83);
            this.salary_bonus_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary_bonus_db.Name = "salary_bonus_db";
            this.salary_bonus_db.Size = new System.Drawing.Size(228, 27);
            this.salary_bonus_db.TabIndex = 22;
            this.salary_bonus_db.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_bonus_db_KeyPress);
            // 
            // all_salaries_dgv
            // 
            this.all_salaries_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.all_salaries_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_salaries_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.all_salaries_dgv.Location = new System.Drawing.Point(5, 200);
            this.all_salaries_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.all_salaries_dgv.Name = "all_salaries_dgv";
            this.all_salaries_dgv.RowHeadersWidth = 51;
            this.all_salaries_dgv.RowTemplate.Height = 25;
            this.all_salaries_dgv.Size = new System.Drawing.Size(906, 255);
            this.all_salaries_dgv.TabIndex = 58;
            // 
            // panel_date
            // 
            this.panel_date.Controls.Add(this.salary_date_db);
            this.panel_date.Controls.Add(this.salary_date_lbl);
            this.panel_date.Location = new System.Drawing.Point(203, 164);
            this.panel_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_date.Name = "panel_date";
            this.panel_date.Size = new System.Drawing.Size(451, 33);
            this.panel_date.TabIndex = 21;
            // 
            // panel_ssn
            // 
            this.panel_ssn.Controls.Add(this.salary_SSN_db);
            this.panel_ssn.Controls.Add(this.salary_SSN_lbl);
            this.panel_ssn.Location = new System.Drawing.Point(203, 127);
            this.panel_ssn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_ssn.Name = "panel_ssn";
            this.panel_ssn.Size = new System.Drawing.Size(451, 35);
            this.panel_ssn.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 46);
            this.label5.TabIndex = 59;
            this.label5.Text = "SALARIES";
            // 
            // Manage_Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_date);
            this.Controls.Add(this.panel_ssn);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.add_update_salary_panel);
            this.Controls.Add(this.all_salaries_dgv);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.managing_salaries_combob);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Manage_Salaries";
            this.Text = "Manage_Salaries";
            this.Load += new System.EventHandler(this.Manage_Salaries_Load);
            this.add_update_salary_panel.ResumeLayout(false);
            this.add_update_salary_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_salaries_dgv)).EndInit();
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.panel_ssn.ResumeLayout(false);
            this.panel_ssn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox managing_salaries_combob;
        private Button choose_button;
        private TextBox salary_SSN_db;
        private DateTimePicker salary_date_db;
        private Label salary_SSN_lbl;
        private Label salary_date_lbl;
        private Button search_button;
        private Button update_button;
        private Button add_button;
        private Panel add_update_salary_panel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label salary_gross_lbl;
        private TextBox salary_gross_db;
        private Label salary_taxes_lbl;
        private TextBox salary_taxes_db;
        private TextBox salary_penalty_db;
        private Label salary_bonus_lbl;
        private Label salary_penalty_lbl;
        private TextBox salary_bonus_db;
        private DataGridView all_salaries_dgv;
        private Panel panel_date;
        private Panel panel_ssn;
        private Label label5;
    }
}