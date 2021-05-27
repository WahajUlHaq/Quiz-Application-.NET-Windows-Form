namespace Quiz_Application
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.INSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.INSPassword = new System.Windows.Forms.TextBox();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 108);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(428, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Online Quiz Application";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.LoginBTN);
            this.panel2.Location = new System.Drawing.Point(0, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 72);
            this.panel2.TabIndex = 1;
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.SystemColors.Control;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginBTN.Location = new System.Drawing.Point(988, 19);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(157, 36);
            this.LoginBTN.TabIndex = 10;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(425, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register Instructor Account";
            // 
            // INSName
            // 
            this.INSName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.INSName.BackColor = System.Drawing.SystemColors.Menu;
            this.INSName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.INSName.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.INSName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.INSName.Location = new System.Drawing.Point(432, 269);
            this.INSName.Multiline = true;
            this.INSName.Name = "INSName";
            this.INSName.Size = new System.Drawing.Size(324, 41);
            this.INSName.TabIndex = 3;
            this.INSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(516, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Your Name";
            // 
            // INSPassword
            // 
            this.INSPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.INSPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.INSPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.INSPassword.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.INSPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.INSPassword.Location = new System.Drawing.Point(432, 379);
            this.INSPassword.Multiline = true;
            this.INSPassword.Name = "INSPassword";
            this.INSPassword.Size = new System.Drawing.Size(324, 41);
            this.INSPassword.TabIndex = 5;
            this.INSPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegisterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegisterBTN.Location = new System.Drawing.Point(514, 451);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(157, 36);
            this.RegisterBTN.TabIndex = 7;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(495, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set Account Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.INSPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INSName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.Text = "Quiz Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox INSPassword;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoginBTN;
    }
}

