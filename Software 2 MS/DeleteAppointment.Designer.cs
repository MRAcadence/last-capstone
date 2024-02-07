namespace Software_2_MS
{
    partial class DeleteAppointment
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
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.CustCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EndTP = new System.Windows.Forms.DateTimePicker();
            this.StartTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
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
            this.AppCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(233, 319);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(166, 21);
            this.TypeCB.TabIndex = 56;
            // 
            // CustCB
            // 
            this.CustCB.FormattingEnabled = true;
            this.CustCB.Location = new System.Drawing.Point(233, 93);
            this.CustCB.Name = "CustCB";
            this.CustCB.Size = new System.Drawing.Size(166, 21);
            this.CustCB.TabIndex = 55;
            this.CustCB.SelectedIndexChanged += new System.EventHandler(this.CustCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(97, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Customer";
            // 
            // EndTP
            // 
            this.EndTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTP.Location = new System.Drawing.Point(233, 394);
            this.EndTP.Name = "EndTP";
            this.EndTP.Size = new System.Drawing.Size(217, 20);
            this.EndTP.TabIndex = 53;
            // 
            // StartTP
            // 
            this.StartTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTP.Location = new System.Drawing.Point(233, 357);
            this.StartTP.Name = "StartTP";
            this.StartTP.Size = new System.Drawing.Size(217, 20);
            this.StartTP.TabIndex = 52;
            this.StartTP.Value = new System.DateTime(2023, 10, 4, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(97, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "End";
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(291, 464);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(91, 32);
            this.CancelBT.TabIndex = 50;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(177, 464);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(91, 32);
            this.DeleteBT.TabIndex = 49;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(233, 283);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(166, 20);
            this.PhoneTB.TabIndex = 48;
            // 
            // LocationTB
            // 
            this.LocationTB.Location = new System.Drawing.Point(233, 244);
            this.LocationTB.Name = "LocationTB";
            this.LocationTB.Size = new System.Drawing.Size(166, 20);
            this.LocationTB.TabIndex = 47;
            // 
            // AppNameTB
            // 
            this.AppNameTB.Location = new System.Drawing.Point(233, 203);
            this.AppNameTB.Name = "AppNameTB";
            this.AppNameTB.Size = new System.Drawing.Size(166, 20);
            this.AppNameTB.TabIndex = 46;
            // 
            // AppDescTB
            // 
            this.AppDescTB.Location = new System.Drawing.Point(233, 164);
            this.AppDescTB.Name = "AppDescTB";
            this.AppDescTB.Size = new System.Drawing.Size(166, 20);
            this.AppDescTB.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(97, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(97, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(97, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(97, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(97, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Appointment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(97, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Appointment Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Delete An Appointment";
            // 
            // AppCB
            // 
            this.AppCB.FormattingEnabled = true;
            this.AppCB.Location = new System.Drawing.Point(233, 127);
            this.AppCB.Name = "AppCB";
            this.AppCB.Size = new System.Drawing.Size(337, 21);
            this.AppCB.TabIndex = 58;
            this.AppCB.SelectedIndexChanged += new System.EventHandler(this.AppCB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(97, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Appointment";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(443, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 102;
            this.TimeLB.Text = "label2";
            // 
            // DeleteAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 519);
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
            this.Controls.Add(this.DeleteBT);
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
            this.Name = "DeleteAppointment";
            this.Text = "Delete Appointment";
            this.Load += new System.EventHandler(this.DeleteAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox CustCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker EndTP;
        private System.Windows.Forms.DateTimePicker StartTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button DeleteBT;
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
        private System.Windows.Forms.ComboBox AppCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimeLB;
    }
}