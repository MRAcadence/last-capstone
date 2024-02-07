namespace Software_2_MS
{
    partial class ReportConsultant
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBT = new System.Windows.Forms.Button();
            this.ConsultantCB = new System.Windows.Forms.ComboBox();
            this.RepoConsultant = new System.Windows.Forms.DataGridView();
            this.TimeLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RepoConsultant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Report By Consultant";
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(355, 440);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(91, 32);
            this.CancelBT.TabIndex = 98;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // ConsultantCB
            // 
            this.ConsultantCB.FormattingEnabled = true;
            this.ConsultantCB.Location = new System.Drawing.Point(194, 47);
            this.ConsultantCB.Name = "ConsultantCB";
            this.ConsultantCB.Size = new System.Drawing.Size(407, 21);
            this.ConsultantCB.TabIndex = 97;
            this.ConsultantCB.Text = "--Select--";
            this.ConsultantCB.SelectedIndexChanged += new System.EventHandler(this.ConsultantCB_SelectedIndexChanged);
            // 
            // RepoConsultant
            // 
            this.RepoConsultant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepoConsultant.Location = new System.Drawing.Point(12, 74);
            this.RepoConsultant.Name = "RepoConsultant";
            this.RepoConsultant.Size = new System.Drawing.Size(776, 353);
            this.RepoConsultant.TabIndex = 96;
            this.RepoConsultant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RepoConsultant_CellContentClick);
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(674, 12);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 100;
            this.TimeLB.Text = "label2";
            // 
            // ReportConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.ConsultantCB);
            this.Controls.Add(this.RepoConsultant);
            this.Name = "ReportConsultant";
            this.Text = "ReportConsultant";
            this.Load += new System.EventHandler(this.ReportConsultant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepoConsultant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.ComboBox ConsultantCB;
        private System.Windows.Forms.DataGridView RepoConsultant;
        private System.Windows.Forms.Label TimeLB;
    }
}