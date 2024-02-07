namespace Software_2_MS
{
    partial class DeleteUser
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
            this.CancelBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(222, 184);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(91, 32);
            this.CancelBT.TabIndex = 73;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(108, 184);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(91, 32);
            this.DeleteBT.TabIndex = 72;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Delete User";
            // 
            // UserCB
            // 
            this.UserCB.FormattingEnabled = true;
            this.UserCB.Location = new System.Drawing.Point(159, 103);
            this.UserCB.Name = "UserCB";
            this.UserCB.Size = new System.Drawing.Size(166, 21);
            this.UserCB.TabIndex = 75;
            this.UserCB.Text = "--Select--";
            this.UserCB.SelectedIndexChanged += new System.EventHandler(this.UserCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(105, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "User";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(271, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 102;
            this.TimeLB.Text = "label2";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 235);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.DeleteBT);
            this.Name = "DeleteUser";
            this.Text = "Delete User";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UserCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TimeLB;
    }
}