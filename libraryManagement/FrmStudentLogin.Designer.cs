namespace libraryManagement
{
    partial class loginstudent
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
            this.passtb = new System.Windows.Forms.TextBox();
            this.passlb = new System.Windows.Forms.Label();
            this.idlb = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.idtb = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(307, 333);
            this.passtb.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(316, 34);
            this.passtb.TabIndex = 21;
            this.passtb.UseSystemPasswordChar = true;
            // 
            // passlb
            // 
            this.passlb.AutoSize = true;
            this.passlb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passlb.ForeColor = System.Drawing.SystemColors.Window;
            this.passlb.Location = new System.Drawing.Point(158, 338);
            this.passlb.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passlb.Name = "passlb";
            this.passlb.Size = new System.Drawing.Size(129, 29);
            this.passlb.TabIndex = 20;
            this.passlb.Text = "Password:";
            this.passlb.Click += new System.EventHandler(this.passlb_Click);
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idlb.ForeColor = System.Drawing.SystemColors.Window;
            this.idlb.Location = new System.Drawing.Point(226, 230);
            this.idlb.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(49, 29);
            this.idlb.TabIndex = 19;
            this.idlb.Text = "ID:";
            // 
            // loginbtn
            // 
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginbtn.FlatAppearance.BorderSize = 3;
            this.loginbtn.Location = new System.Drawing.Point(459, 393);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(164, 50);
            this.loginbtn.TabIndex = 18;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(307, 225);
            this.idtb.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.idtb.Mask = "00000000000";
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(316, 34);
            this.idtb.TabIndex = 17;
            this.idtb.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.loginlbl);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 100);
            this.panel1.TabIndex = 22;
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.loginlbl.Location = new System.Drawing.Point(212, -5);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(570, 105);
            this.loginlbl.TabIndex = 7;
            this.loginlbl.Text = "STUDENT LOGIN";
            // 
            // loginstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.passlb);
            this.Controls.Add(this.idlb);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.idtb);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "loginstudent";
            this.Text = "loginstudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Label passlb;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.MaskedTextBox idtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlbl;
    }
}