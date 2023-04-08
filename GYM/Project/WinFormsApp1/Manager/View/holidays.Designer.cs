namespace WinFormsApp1
{
    partial class holidays
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
            this.view_requests_dgv = new System.Windows.Forms.DataGridView();
            this.holidays_approve_button = new System.Windows.Forms.Button();
            this.holidays_reject_button = new System.Windows.Forms.Button();
            this.respond_panel = new System.Windows.Forms.Panel();
            this.endDateTb = new System.Windows.Forms.TextBox();
            this.startDateTb = new System.Windows.Forms.TextBox();
            this.ssnTb = new System.Windows.Forms.TextBox();
            this.employee_SSN_lbl = new System.Windows.Forms.Label();
            this.device_birth_date_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_requests_dgv)).BeginInit();
            this.respond_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_requests_dgv
            // 
            this.view_requests_dgv.AllowUserToAddRows = false;
            this.view_requests_dgv.AllowUserToDeleteRows = false;
            this.view_requests_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.view_requests_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_requests_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.view_requests_dgv.Location = new System.Drawing.Point(12, 13);
            this.view_requests_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_requests_dgv.MultiSelect = false;
            this.view_requests_dgv.Name = "view_requests_dgv";
            this.view_requests_dgv.ReadOnly = true;
            this.view_requests_dgv.RowHeadersWidth = 51;
            this.view_requests_dgv.RowTemplate.Height = 25;
            this.view_requests_dgv.ShowCellErrors = false;
            this.view_requests_dgv.ShowEditingIcon = false;
            this.view_requests_dgv.Size = new System.Drawing.Size(890, 277);
            this.view_requests_dgv.TabIndex = 0;
            this.view_requests_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_requests_dgv_CellContentClick);
            this.view_requests_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.view_requests_dgv_RowHeaderMouseClick);
            // 
            // holidays_approve_button
            // 
            this.holidays_approve_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.holidays_approve_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holidays_approve_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.holidays_approve_button.ForeColor = System.Drawing.Color.White;
            this.holidays_approve_button.Location = new System.Drawing.Point(529, 65);
            this.holidays_approve_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.holidays_approve_button.Name = "holidays_approve_button";
            this.holidays_approve_button.Size = new System.Drawing.Size(250, 45);
            this.holidays_approve_button.TabIndex = 32;
            this.holidays_approve_button.Text = "Approve";
            this.holidays_approve_button.UseVisualStyleBackColor = false;
            this.holidays_approve_button.Click += new System.EventHandler(this.holidays_approve_button_Click);
            // 
            // holidays_reject_button
            // 
            this.holidays_reject_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(106)))), ((int)(((byte)(135)))));
            this.holidays_reject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holidays_reject_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.holidays_reject_button.ForeColor = System.Drawing.Color.White;
            this.holidays_reject_button.Location = new System.Drawing.Point(529, 142);
            this.holidays_reject_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.holidays_reject_button.Name = "holidays_reject_button";
            this.holidays_reject_button.Size = new System.Drawing.Size(250, 45);
            this.holidays_reject_button.TabIndex = 34;
            this.holidays_reject_button.Text = "Reject";
            this.holidays_reject_button.UseVisualStyleBackColor = false;
            this.holidays_reject_button.Click += new System.EventHandler(this.holidays_reject_button_Click);
            // 
            // respond_panel
            // 
            this.respond_panel.Controls.Add(this.employee_SSN_lbl);
            this.respond_panel.Controls.Add(this.label1);
            this.respond_panel.Controls.Add(this.device_birth_date_lbl);
            this.respond_panel.Controls.Add(this.holidays_reject_button);
            this.respond_panel.Controls.Add(this.endDateTb);
            this.respond_panel.Controls.Add(this.holidays_approve_button);
            this.respond_panel.Controls.Add(this.startDateTb);
            this.respond_panel.Controls.Add(this.ssnTb);
            this.respond_panel.Location = new System.Drawing.Point(12, 298);
            this.respond_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.respond_panel.Name = "respond_panel";
            this.respond_panel.Size = new System.Drawing.Size(890, 286);
            this.respond_panel.TabIndex = 39;
            // 
            // endDateTb
            // 
            this.endDateTb.Location = new System.Drawing.Point(168, 167);
            this.endDateTb.Name = "endDateTb";
            this.endDateTb.ReadOnly = true;
            this.endDateTb.Size = new System.Drawing.Size(233, 27);
            this.endDateTb.TabIndex = 39;
            // 
            // startDateTb
            // 
            this.startDateTb.Location = new System.Drawing.Point(168, 116);
            this.startDateTb.Name = "startDateTb";
            this.startDateTb.ReadOnly = true;
            this.startDateTb.Size = new System.Drawing.Size(233, 27);
            this.startDateTb.TabIndex = 39;
            // 
            // ssnTb
            // 
            this.ssnTb.Location = new System.Drawing.Point(168, 65);
            this.ssnTb.Name = "ssnTb";
            this.ssnTb.ReadOnly = true;
            this.ssnTb.Size = new System.Drawing.Size(233, 27);
            this.ssnTb.TabIndex = 39;
            // 
            // employee_SSN_lbl
            // 
            this.employee_SSN_lbl.AutoSize = true;
            this.employee_SSN_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employee_SSN_lbl.ForeColor = System.Drawing.Color.White;
            this.employee_SSN_lbl.Location = new System.Drawing.Point(84, 65);
            this.employee_SSN_lbl.Name = "employee_SSN_lbl";
            this.employee_SSN_lbl.Size = new System.Drawing.Size(43, 23);
            this.employee_SSN_lbl.TabIndex = 40;
            this.employee_SSN_lbl.Text = "SSN";
            // 
            // device_birth_date_lbl
            // 
            this.device_birth_date_lbl.AutoSize = true;
            this.device_birth_date_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.device_birth_date_lbl.ForeColor = System.Drawing.Color.White;
            this.device_birth_date_lbl.Location = new System.Drawing.Point(50, 116);
            this.device_birth_date_lbl.Name = "device_birth_date_lbl";
            this.device_birth_date_lbl.Size = new System.Drawing.Size(93, 23);
            this.device_birth_date_lbl.TabIndex = 41;
            this.device_birth_date_lbl.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "End Date";
            // 
            // holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.respond_panel);
            this.Controls.Add(this.view_requests_dgv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "holidays";
            this.Text = "Holidays";
            this.Load += new System.EventHandler(this.holidays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_requests_dgv)).EndInit();
            this.respond_panel.ResumeLayout(false);
            this.respond_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView view_requests_dgv;
        private Button holidays_approve_button;
        private Button holidays_reject_button;
        private Panel respond_panel;
        private TextBox endDateTb;
        private TextBox startDateTb;
        private TextBox ssnTb;
        private Label employee_SSN_lbl;
        private Label label1;
        protected internal Label device_birth_date_lbl;
    }
}