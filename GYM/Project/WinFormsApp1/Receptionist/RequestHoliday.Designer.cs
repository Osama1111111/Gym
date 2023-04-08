
namespace Receptionist
{
    partial class RequestHoliday
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
            this.label_ssn = new System.Windows.Forms.Label();
            this.label_sdate = new System.Windows.Forms.Label();
            this.label_edate = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ssn.Location = new System.Drawing.Point(148, 100);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(43, 23);
            this.label_ssn.TabIndex = 0;
            this.label_ssn.Text = "SSN";
            // 
            // label_sdate
            // 
            this.label_sdate.AutoSize = true;
            this.label_sdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_sdate.Location = new System.Drawing.Point(148, 200);
            this.label_sdate.Name = "label_sdate";
            this.label_sdate.Size = new System.Drawing.Size(93, 23);
            this.label_sdate.TabIndex = 1;
            this.label_sdate.Text = "Start Date";
            // 
            // label_edate
            // 
            this.label_edate.AutoSize = true;
            this.label_edate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_edate.Location = new System.Drawing.Point(148, 309);
            this.label_edate.Name = "label_edate";
            this.label_edate.Size = new System.Drawing.Size(83, 23);
            this.label_edate.TabIndex = 2;
            this.label_edate.Text = "End Date";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(609, 480);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(62, 20);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "Pending";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 194);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(324, 303);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 27);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // request
            // 
            this.request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(81)))), ((int)(((byte)(49)))));
            this.request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request.Location = new System.Drawing.Point(279, 455);
            this.request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(250, 45);
            this.request.TabIndex = 7;
            this.request.Text = "REQUEST";
            this.request.UseVisualStyleBackColor = false;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // RequestHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(108)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.request);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_edate);
            this.Controls.Add(this.label_sdate);
            this.Controls.Add(this.label_ssn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestHoliday";
            this.Text = "RequestHoliday";
            this.Load += new System.EventHandler(this.RequestHoliday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Label label_sdate;
        private System.Windows.Forms.Label label_edate;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button request;
    }
}