namespace Software_2_MS
{
    partial class Main
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
            this.WeekRB = new System.Windows.Forms.RadioButton();
            this.MonthRB = new System.Windows.Forms.RadioButton();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.AppCalDV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserDelBT = new System.Windows.Forms.Button();
            this.UserModBT = new System.Windows.Forms.Button();
            this.UserAddBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustDelBT = new System.Windows.Forms.Button();
            this.CustModBT = new System.Windows.Forms.Button();
            this.CustAddBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AppDelBT = new System.Windows.Forms.Button();
            this.AppModBT = new System.Windows.Forms.Button();
            this.AppAddBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ConsultantRepoBT = new System.Windows.Forms.Button();
            this.CustRepoBT = new System.Windows.Forms.Button();
            this.MonthRepoBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterCustBT = new System.Windows.Forms.Button();
            this.FilterConBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppCalDV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekRB
            // 
            this.WeekRB.AutoSize = true;
            this.WeekRB.Location = new System.Drawing.Point(363, 580);
            this.WeekRB.Name = "WeekRB";
            this.WeekRB.Size = new System.Drawing.Size(80, 17);
            this.WeekRB.TabIndex = 0;
            this.WeekRB.TabStop = true;
            this.WeekRB.Text = "View Week";
            this.WeekRB.UseVisualStyleBackColor = true;
            // 
            // MonthRB
            // 
            this.MonthRB.AutoSize = true;
            this.MonthRB.Location = new System.Drawing.Point(471, 580);
            this.MonthRB.Name = "MonthRB";
            this.MonthRB.Size = new System.Drawing.Size(81, 17);
            this.MonthRB.TabIndex = 1;
            this.MonthRB.TabStop = true;
            this.MonthRB.Text = "View Month";
            this.MonthRB.UseVisualStyleBackColor = true;
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(599, 572);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(91, 32);
            this.UpdateBT.TabIndex = 13;
            this.UpdateBT.Text = "Update";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // AppCalDV
            // 
            this.AppCalDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppCalDV.Location = new System.Drawing.Point(211, 93);
            this.AppCalDV.Name = "AppCalDV";
            this.AppCalDV.Size = new System.Drawing.Size(600, 423);
            this.AppCalDV.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UserDelBT);
            this.panel1.Controls.Add(this.UserModBT);
            this.panel1.Controls.Add(this.UserAddBT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 204);
            this.panel1.TabIndex = 15;
            // 
            // UserDelBT
            // 
            this.UserDelBT.Location = new System.Drawing.Point(19, 126);
            this.UserDelBT.Name = "UserDelBT";
            this.UserDelBT.Size = new System.Drawing.Size(158, 32);
            this.UserDelBT.TabIndex = 25;
            this.UserDelBT.Text = "Delete User";
            this.UserDelBT.UseVisualStyleBackColor = true;
            this.UserDelBT.Click += new System.EventHandler(this.UserDelBT_Click);
            // 
            // UserModBT
            // 
            this.UserModBT.Location = new System.Drawing.Point(19, 88);
            this.UserModBT.Name = "UserModBT";
            this.UserModBT.Size = new System.Drawing.Size(158, 32);
            this.UserModBT.TabIndex = 24;
            this.UserModBT.Text = "Modify User";
            this.UserModBT.UseVisualStyleBackColor = true;
            this.UserModBT.Click += new System.EventHandler(this.UserModBT_Click);
            // 
            // UserAddBT
            // 
            this.UserAddBT.Location = new System.Drawing.Point(19, 50);
            this.UserAddBT.Name = "UserAddBT";
            this.UserAddBT.Size = new System.Drawing.Size(158, 32);
            this.UserAddBT.TabIndex = 23;
            this.UserAddBT.Text = "Add User";
            this.UserAddBT.UseVisualStyleBackColor = true;
            this.UserAddBT.Click += new System.EventHandler(this.UserAddBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "User Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CustDelBT);
            this.panel2.Controls.Add(this.CustModBT);
            this.panel2.Controls.Add(this.CustAddBT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 204);
            this.panel2.TabIndex = 16;
            // 
            // CustDelBT
            // 
            this.CustDelBT.Location = new System.Drawing.Point(19, 136);
            this.CustDelBT.Name = "CustDelBT";
            this.CustDelBT.Size = new System.Drawing.Size(158, 32);
            this.CustDelBT.TabIndex = 22;
            this.CustDelBT.Text = "Delete Customer";
            this.CustDelBT.UseVisualStyleBackColor = true;
            this.CustDelBT.Click += new System.EventHandler(this.CustDelBT_Click);
            // 
            // CustModBT
            // 
            this.CustModBT.Location = new System.Drawing.Point(19, 98);
            this.CustModBT.Name = "CustModBT";
            this.CustModBT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustModBT.Size = new System.Drawing.Size(158, 32);
            this.CustModBT.TabIndex = 21;
            this.CustModBT.Text = "Modify Customer";
            this.CustModBT.UseVisualStyleBackColor = true;
            this.CustModBT.Click += new System.EventHandler(this.CustModBT_Click);
            // 
            // CustAddBT
            // 
            this.CustAddBT.Location = new System.Drawing.Point(19, 60);
            this.CustAddBT.Name = "CustAddBT";
            this.CustAddBT.Size = new System.Drawing.Size(158, 32);
            this.CustAddBT.TabIndex = 19;
            this.CustAddBT.Text = "Add Customer";
            this.CustAddBT.UseVisualStyleBackColor = true;
            this.CustAddBT.Click += new System.EventHandler(this.CustAddBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Customer Mgmt";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AppDelBT);
            this.panel3.Controls.Add(this.AppModBT);
            this.panel3.Controls.Add(this.AppAddBT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(817, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 204);
            this.panel3.TabIndex = 17;
            // 
            // AppDelBT
            // 
            this.AppDelBT.Location = new System.Drawing.Point(12, 126);
            this.AppDelBT.Name = "AppDelBT";
            this.AppDelBT.Size = new System.Drawing.Size(158, 32);
            this.AppDelBT.TabIndex = 23;
            this.AppDelBT.Text = "Delete Appointment";
            this.AppDelBT.UseVisualStyleBackColor = true;
            this.AppDelBT.Click += new System.EventHandler(this.AppDelBT_Click);
            // 
            // AppModBT
            // 
            this.AppModBT.Location = new System.Drawing.Point(12, 88);
            this.AppModBT.Name = "AppModBT";
            this.AppModBT.Size = new System.Drawing.Size(158, 32);
            this.AppModBT.TabIndex = 22;
            this.AppModBT.Text = "Modify Appointment";
            this.AppModBT.UseVisualStyleBackColor = true;
            this.AppModBT.Click += new System.EventHandler(this.AppModBT_Click);
            // 
            // AppAddBT
            // 
            this.AppAddBT.Location = new System.Drawing.Point(12, 50);
            this.AppAddBT.Name = "AppAddBT";
            this.AppAddBT.Size = new System.Drawing.Size(158, 32);
            this.AppAddBT.TabIndex = 21;
            this.AppAddBT.Text = "Add Appointment";
            this.AppAddBT.UseVisualStyleBackColor = true;
            this.AppAddBT.Click += new System.EventHandler(this.AppAddBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Appointment Mgmt";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ConsultantRepoBT);
            this.panel4.Controls.Add(this.CustRepoBT);
            this.panel4.Controls.Add(this.MonthRepoBT);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(817, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 204);
            this.panel4.TabIndex = 18;
            // 
            // ConsultantRepoBT
            // 
            this.ConsultantRepoBT.Location = new System.Drawing.Point(12, 136);
            this.ConsultantRepoBT.Name = "ConsultantRepoBT";
            this.ConsultantRepoBT.Size = new System.Drawing.Size(158, 32);
            this.ConsultantRepoBT.TabIndex = 26;
            this.ConsultantRepoBT.Text = "Consultant Report";
            this.ConsultantRepoBT.UseVisualStyleBackColor = true;
            this.ConsultantRepoBT.Click += new System.EventHandler(this.ConsultantRepoBT_Click);
            // 
            // CustRepoBT
            // 
            this.CustRepoBT.Location = new System.Drawing.Point(12, 98);
            this.CustRepoBT.Name = "CustRepoBT";
            this.CustRepoBT.Size = new System.Drawing.Size(158, 32);
            this.CustRepoBT.TabIndex = 25;
            this.CustRepoBT.Text = "Customer Report";
            this.CustRepoBT.UseVisualStyleBackColor = true;
            this.CustRepoBT.Click += new System.EventHandler(this.CustRepoBT_Click);
            // 
            // MonthRepoBT
            // 
            this.MonthRepoBT.Location = new System.Drawing.Point(12, 60);
            this.MonthRepoBT.Name = "MonthRepoBT";
            this.MonthRepoBT.Size = new System.Drawing.Size(158, 32);
            this.MonthRepoBT.TabIndex = 24;
            this.MonthRepoBT.Text = "Month Report";
            this.MonthRepoBT.UseVisualStyleBackColor = true;
            this.MonthRepoBT.Click += new System.EventHandler(this.MonthRepoBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Reports";
            // 
            // FilterCustBT
            // 
            this.FilterCustBT.Location = new System.Drawing.Point(324, 522);
            this.FilterCustBT.Name = "FilterCustBT";
            this.FilterCustBT.Size = new System.Drawing.Size(158, 32);
            this.FilterCustBT.TabIndex = 23;
            this.FilterCustBT.Text = "Search By Customer";
            this.FilterCustBT.UseVisualStyleBackColor = true;
            this.FilterCustBT.Click += new System.EventHandler(this.FilterCustBT_Click);
            // 
            // FilterConBT
            // 
            this.FilterConBT.Location = new System.Drawing.Point(532, 522);
            this.FilterConBT.Name = "FilterConBT";
            this.FilterConBT.Size = new System.Drawing.Size(158, 32);
            this.FilterConBT.TabIndex = 24;
            this.FilterConBT.Text = "Search By Consultant";
            this.FilterConBT.UseVisualStyleBackColor = true;
            this.FilterConBT.Click += new System.EventHandler(this.FilterConBT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 55);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dashboard";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(893, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 103;
            this.TimeLB.Text = "label2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 609);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FilterConBT);
            this.Controls.Add(this.FilterCustBT);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AppCalDV);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.MonthRB);
            this.Controls.Add(this.WeekRB);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppCalDV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton WeekRB;
        private System.Windows.Forms.RadioButton MonthRB;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.DataGridView AppCalDV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserDelBT;
        private System.Windows.Forms.Button UserModBT;
        private System.Windows.Forms.Button UserAddBT;
        private System.Windows.Forms.Button CustDelBT;
        private System.Windows.Forms.Button CustModBT;
        private System.Windows.Forms.Button CustAddBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AppDelBT;
        private System.Windows.Forms.Button AppModBT;
        private System.Windows.Forms.Button AppAddBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConsultantRepoBT;
        private System.Windows.Forms.Button CustRepoBT;
        private System.Windows.Forms.Button MonthRepoBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FilterCustBT;
        private System.Windows.Forms.Button FilterConBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimeLB;
    }
}