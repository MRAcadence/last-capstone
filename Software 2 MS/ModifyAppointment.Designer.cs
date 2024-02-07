namespace Software_2_MS
{
    partial class ModifyAppointment
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
            this.AppCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.CustCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EndTP = new System.Windows.Forms.DateTimePicker();
            this.StartTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelBT = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.LocationTB = new System.Windows.Forms.TextBox();
            this.AppNameTB = new System.Windows.Forms.TextBox();
            this.AppDescTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppCB
            // 
            this.AppCB.FormattingEnabled = true;
            this.AppCB.Location = new System.Drawing.Point(233, 130);
            this.AppCB.Name = "AppCB";
            this.AppCB.Size = new System.Drawing.Size(166, 21);
            this.AppCB.TabIndex = 79;
            this.AppCB.SelectedIndexChanged += new System.EventHandler(this.AppCB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(97, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Appointment";
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "therapy",
            "consultation",
            "psychiatry"});
            this.TypeCB.Location = new System.Drawing.Point(233, 322);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(166, 21);
            this.TypeCB.TabIndex = 77;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // CustCB
            // 
            this.CustCB.FormattingEnabled = true;
            this.CustCB.Location = new System.Drawing.Point(233, 96);
            this.CustCB.Name = "CustCB";
            this.CustCB.Size = new System.Drawing.Size(166, 21);
            this.CustCB.TabIndex = 76;
            this.CustCB.SelectedIndexChanged += new System.EventHandler(this.CustCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(97, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Customer";
            // 
            // EndTP
            // 
            this.EndTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTP.Location = new System.Drawing.Point(233, 397);
            this.EndTP.Name = "EndTP";
            this.EndTP.Size = new System.Drawing.Size(217, 20);
            this.EndTP.TabIndex = 74;
            // 
            // StartTP
            // 
            this.StartTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTP.Location = new System.Drawing.Point(233, 360);
            this.StartTP.Name = "StartTP";
            this.StartTP.Size = new System.Drawing.Size(217, 20);
            this.StartTP.TabIndex = 73;
            this.StartTP.Value = new System.DateTime(2023, 10, 4, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(97, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "End";
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(291, 467);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(91, 32);
            this.CancelBT.TabIndex = 71;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(177, 467);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(91, 32);
            this.UpdateBT.TabIndex = 70;
            this.UpdateBT.Text = "Update";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(233, 286);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(166, 20);
            this.PhoneTB.TabIndex = 69;
            // 
            // LocationTB
            // 
            this.LocationTB.Location = new System.Drawing.Point(233, 247);
            this.LocationTB.Name = "LocationTB";
            this.LocationTB.Size = new System.Drawing.Size(166, 20);
            this.LocationTB.TabIndex = 68;
            // 
            // AppNameTB
            // 
            this.AppNameTB.Location = new System.Drawing.Point(233, 206);
            this.AppNameTB.Name = "AppNameTB";
            this.AppNameTB.Size = new System.Drawing.Size(166, 20);
            this.AppNameTB.TabIndex = 67;
            // 
            // AppDescTB
            // 
            this.AppDescTB.Location = new System.Drawing.Point(233, 167);
            this.AppDescTB.Name = "AppDescTB";
            this.AppDescTB.Size = new System.Drawing.Size(166, 20);
            this.AppDescTB.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(97, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(97, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(97, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(97, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(97, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Appointment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(97, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Appointment Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Modify An Appointment";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(445, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 103;
            this.TimeLB.Text = "label2";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 531);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.AppCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.CustCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EndTP);
            this.Controls.Add(this.StartTP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.LocationTB);
            this.Controls.Add(this.AppNameTB);
            this.Controls.Add(this.AppDescTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyAppointment";
            this.Text = "Modify Appointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AppCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox CustCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker EndTP;
        private System.Windows.Forms.DateTimePicker StartTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox LocationTB;
        private System.Windows.Forms.TextBox AppNameTB;
        private System.Windows.Forms.TextBox AppDescTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLB;
    }
}