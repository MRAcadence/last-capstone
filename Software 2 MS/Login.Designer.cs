namespace Software_2_MS
{
    partial class Login
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
            this.PsswrdTB = new System.Windows.Forms.TextBox();
            this.UsrNameTB = new System.Windows.Forms.TextBox();
            this.PassLB = new System.Windows.Forms.Label();
            this.UserNameLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBT = new System.Windows.Forms.Button();
            this.LoginBT = new System.Windows.Forms.Button();
            this.PasswordCKBX = new System.Windows.Forms.CheckBox();
            this.TimeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PsswrdTB
            // 
            this.PsswrdTB.Location = new System.Drawing.Point(148, 131);
            this.PsswrdTB.Name = "PsswrdTB";
            this.PsswrdTB.Size = new System.Drawing.Size(166, 20);
            this.PsswrdTB.TabIndex = 70;
            // 
            // UsrNameTB
            // 
            this.UsrNameTB.Location = new System.Drawing.Point(148, 91);
            this.UsrNameTB.Name = "UsrNameTB";
            this.UsrNameTB.Size = new System.Drawing.Size(166, 20);
            this.UsrNameTB.TabIndex = 69;
            // 
            // PassLB
            // 
            this.PassLB.AutoSize = true;
            this.PassLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PassLB.Location = new System.Drawing.Point(58, 134);
            this.PassLB.Name = "PassLB";
            this.PassLB.Size = new System.Drawing.Size(53, 13);
            this.PassLB.TabIndex = 68;
            this.PassLB.Text = "Password";
            // 
            // UserNameLB
            // 
            this.UserNameLB.AutoSize = true;
            this.UserNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UserNameLB.Location = new System.Drawing.Point(58, 94);
            this.UserNameLB.Name = "UserNameLB";
            this.UserNameLB.Size = new System.Drawing.Size(57, 13);
            this.UserNameLB.TabIndex = 67;
            this.UserNameLB.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Login";
            // 
            // ExitBT
            // 
            this.ExitBT.Location = new System.Drawing.Point(231, 219);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(91, 32);
            this.ExitBT.TabIndex = 79;
            this.ExitBT.Text = "Exit";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // LoginBT
            // 
            this.LoginBT.Location = new System.Drawing.Point(117, 219);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(91, 32);
            this.LoginBT.TabIndex = 78;
            this.LoginBT.Text = "Login";
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // PasswordCKBX
            // 
            this.PasswordCKBX.AutoSize = true;
            this.PasswordCKBX.Location = new System.Drawing.Point(181, 171);
            this.PasswordCKBX.Name = "PasswordCKBX";
            this.PasswordCKBX.Size = new System.Drawing.Size(102, 17);
            this.PasswordCKBX.TabIndex = 81;
            this.PasswordCKBX.Text = "Show Password";
            this.PasswordCKBX.UseVisualStyleBackColor = true;
            this.PasswordCKBX.CheckedChanged += new System.EventHandler(this.PasswordCKBX_CheckedChanged);
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(313, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(35, 13);
            this.TimeLB.TabIndex = 102;
            this.TimeLB.Text = "label2";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 284);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.PasswordCKBX);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PsswrdTB);
            this.Controls.Add(this.UsrNameTB);
            this.Controls.Add(this.PassLB);
            this.Controls.Add(this.UserNameLB);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PsswrdTB;
        private System.Windows.Forms.TextBox UsrNameTB;
        private System.Windows.Forms.Label PassLB;
        private System.Windows.Forms.Label UserNameLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.CheckBox PasswordCKBX;
        private System.Windows.Forms.Label TimeLB;
    }
}