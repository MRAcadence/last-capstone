namespace Software_2_MS
{
    partial class ReportCustomer
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
            this.CustomerCB = new System.Windows.Forms.ComboBox();
            this.RepoCustDV = new System.Windows.Forms.DataGridView();
            this.TimeLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RepoCustDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Report By Customer";
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(355, 437);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(91, 32);
            this.CancelBT.TabIndex = 94;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // CustomerCB
            // 
            this.CustomerCB.FormattingEnabled = true;
            this.CustomerCB.Location = new System.Drawing.Point(194, 44);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(407, 21);
            this.CustomerCB.TabIndex = 93;
            this.CustomerCB.Text = "--Select--";
            this.CustomerCB.SelectedIndexChanged += new System.EventHandler(this.CustomerCB_SelectedIndexChanged);
            // 
            // RepoCustDV
            // 
            this.RepoCustDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepoCustDV.Location = new System.Drawing.Point(12, 71);
            this.RepoCustDV.Name = "RepoCustDV";
            this.RepoCustDV.Size = new System.Drawing.Size(776, 353);
            this.RepoCustDV.TabIndex = 92;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(692, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 101;
            this.TimeLB.Text = "label2";
            // 
            // ReportCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 481);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.CustomerCB);
            this.Controls.Add(this.RepoCustDV);
            this.Name = "ReportCustomer";
            this.Text = "ReportCustomer";
            this.Load += new System.EventHandler(this.ReportCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepoCustDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.DataGridView RepoCustDV;
        private System.Windows.Forms.Label TimeLB;
    }
}