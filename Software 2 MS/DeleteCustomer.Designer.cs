namespace Software_2_MS
{
    partial class DeleteCustomer
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
            this.CustCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NoRB = new System.Windows.Forms.RadioButton();
            this.YesRB = new System.Windows.Forms.RadioButton();
            this.CancelBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.CountryTB = new System.Windows.Forms.TextBox();
            this.ZipTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustCB
            // 
            this.CustCB.FormattingEnabled = true;
            this.CustCB.Location = new System.Drawing.Point(319, 85);
            this.CustCB.Name = "CustCB";
            this.CustCB.Size = new System.Drawing.Size(166, 21);
            this.CustCB.TabIndex = 57;
            this.CustCB.SelectedIndexChanged += new System.EventHandler(this.CustCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(229, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Customer";
            // 
            // NoRB
            // 
            this.NoRB.AutoSize = true;
            this.NoRB.Location = new System.Drawing.Point(405, 352);
            this.NoRB.Name = "NoRB";
            this.NoRB.Size = new System.Drawing.Size(39, 17);
            this.NoRB.TabIndex = 73;
            this.NoRB.TabStop = true;
            this.NoRB.Text = "No";
            this.NoRB.UseVisualStyleBackColor = true;
            // 
            // YesRB
            // 
            this.YesRB.AutoSize = true;
            this.YesRB.Location = new System.Drawing.Point(319, 352);
            this.YesRB.Name = "YesRB";
            this.YesRB.Size = new System.Drawing.Size(43, 17);
            this.YesRB.TabIndex = 72;
            this.YesRB.TabStop = true;
            this.YesRB.Text = "Yes";
            this.YesRB.UseVisualStyleBackColor = true;
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(385, 392);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(91, 32);
            this.CancelBT.TabIndex = 71;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(271, 392);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(91, 32);
            this.DeleteBT.TabIndex = 70;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // CountryTB
            // 
            this.CountryTB.Location = new System.Drawing.Point(319, 307);
            this.CountryTB.Name = "CountryTB";
            this.CountryTB.Size = new System.Drawing.Size(166, 20);
            this.CountryTB.TabIndex = 69;
            // 
            // ZipTB
            // 
            this.ZipTB.Location = new System.Drawing.Point(319, 269);
            this.ZipTB.Name = "ZipTB";
            this.ZipTB.Size = new System.Drawing.Size(166, 20);
            this.ZipTB.TabIndex = 68;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(319, 228);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(166, 20);
            this.AddressTB.TabIndex = 67;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(319, 161);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(166, 20);
            this.PhoneTB.TabIndex = 66;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(319, 121);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(166, 20);
            this.NameTB.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(229, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(229, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(229, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(229, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(229, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(229, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Fill Out All Customer Information";
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(319, 195);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(166, 20);
            this.CityTB.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(229, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "City";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(614, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 102;
            this.TimeLB.Text = "label2";
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NoRB);
            this.Controls.Add(this.YesRB);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.CountryTB);
            this.Controls.Add(this.ZipTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustCB);
            this.Controls.Add(this.label9);
            this.Name = "DeleteCustomer";
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton NoRB;
        private System.Windows.Forms.RadioButton YesRB;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.TextBox CountryTB;
        private System.Windows.Forms.TextBox ZipTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TimeLB;
    }
}