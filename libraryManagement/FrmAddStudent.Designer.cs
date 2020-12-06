namespace libraryManagement
{
    partial class FrmAddStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDosyaName = new System.Windows.Forms.LinkLabel();
            this.btnPicture = new FontAwesome.Sharp.IconButton();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDosyaName);
            this.groupBox1.Controls.Add(this.btnPicture);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(442, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Informations";
            // 
            // lblDosyaName
            // 
            this.lblDosyaName.AutoSize = true;
            this.lblDosyaName.LinkColor = System.Drawing.Color.Aqua;
            this.lblDosyaName.Location = new System.Drawing.Point(178, 461);
            this.lblDosyaName.Name = "lblDosyaName";
            this.lblDosyaName.Size = new System.Drawing.Size(107, 23);
            this.lblDosyaName.TabIndex = 15;
            this.lblDosyaName.TabStop = true;
            this.lblDosyaName.Text = "  Dosya.jpg";
            // 
            // btnPicture
            // 
            this.btnPicture.ForeColor = System.Drawing.Color.Black;
            this.btnPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPicture.IconColor = System.Drawing.Color.Black;
            this.btnPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPicture.Location = new System.Drawing.Point(10, 454);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(123, 37);
            this.btnPicture.TabIndex = 14;
            this.btnPicture.Text = "Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(182, 394);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(234, 31);
            this.cmbDepartment.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Department :";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(182, 341);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(234, 29);
            this.mskTC.TabIndex = 11;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "TC :";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(182, 289);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(234, 29);
            this.mskPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 292);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone :";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbGender.Location = new System.Drawing.Point(182, 227);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(234, 31);
            this.cmbGender.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 230);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 23);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(182, 169);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(234, 29);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 172);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(80, 23);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "E-mail :";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(182, 112);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(234, 29);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 115);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(101, 23);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 159);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(543, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Student";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1012, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(1012, 273);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(148, 165);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 11;
            this.pictureBoxPic.TabStop = false;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1325, 896);
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddStudent";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblDosyaName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton btnPicture;
        private System.Windows.Forms.PictureBox pictureBoxPic;
    }
}