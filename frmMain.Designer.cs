namespace PDFEncrypt
{
	partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInputBrowse = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOwnerPasswordSet = new System.Windows.Forms.Label();
            this.lnkPasswordOwner = new System.Windows.Forms.LinkLabel();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.lblCopied = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPasswordGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnInputBrowse);
            this.groupBox1.Controls.Add(this.txtInputFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(620, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose a file to encrypt:";
            // 
            // btnInputBrowse
            // 
            this.btnInputBrowse.Location = new System.Drawing.Point(557, 62);
            this.btnInputBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInputBrowse.Name = "btnInputBrowse";
            this.btnInputBrowse.Size = new System.Drawing.Size(48, 34);
            this.btnInputBrowse.TabIndex = 10;
            this.btnInputBrowse.Text = "...";
            this.btnInputBrowse.UseVisualStyleBackColor = true;
            this.btnInputBrowse.Click += new System.EventHandler(this.btnInputBrowse_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFile.Location = new System.Drawing.Point(28, 62);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(512, 34);
            this.txtInputFile.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnOutputBrowse);
            this.groupBox2.Controls.Add(this.txtOutputFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(620, 123);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose a destination for the encrypted file:";
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Location = new System.Drawing.Point(557, 62);
            this.btnOutputBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(48, 34);
            this.btnOutputBrowse.TabIndex = 10;
            this.btnOutputBrowse.Text = "...";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputFile.Location = new System.Drawing.Point(28, 62);
            this.txtOutputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(512, 34);
            this.txtOutputFile.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOwnerPasswordSet);
            this.groupBox3.Controls.Add(this.lnkPasswordOwner);
            this.groupBox3.Controls.Add(this.lblPasswordLength);
            this.groupBox3.Controls.Add(this.lblCopied);
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnPasswordGenerate);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Location = new System.Drawing.Point(13, 270);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(619, 153);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password";
            // 
            // lblOwnerPasswordSet
            // 
            this.lblOwnerPasswordSet.AutoSize = true;
            this.lblOwnerPasswordSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOwnerPasswordSet.Location = new System.Drawing.Point(207, 123);
            this.lblOwnerPasswordSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerPasswordSet.Name = "lblOwnerPasswordSet";
            this.lblOwnerPasswordSet.Size = new System.Drawing.Size(131, 16);
            this.lblOwnerPasswordSet.TabIndex = 16;
            this.lblOwnerPasswordSet.Text = "Owner password set.";
            this.lblOwnerPasswordSet.Visible = false;
            // 
            // lnkPasswordOwner
            // 
            this.lnkPasswordOwner.AutoSize = true;
            this.lnkPasswordOwner.Location = new System.Drawing.Point(37, 123);
            this.lnkPasswordOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkPasswordOwner.Name = "lnkPasswordOwner";
            this.lnkPasswordOwner.Size = new System.Drawing.Size(131, 16);
            this.lnkPasswordOwner.TabIndex = 15;
            this.lnkPasswordOwner.TabStop = true;
            this.lnkPasswordOwner.Text = "Set Owner Password";
            this.lnkPasswordOwner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPasswordOwner_LinkClicked);
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPasswordLength.Location = new System.Drawing.Point(25, 98);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(413, 16);
            this.lblPasswordLength.TabIndex = 14;
            this.lblPasswordLength.Text = "Passwords longer than 32 characters will be truncated per PDF spec.";
            this.lblPasswordLength.Visible = false;
            // 
            // lblCopied
            // 
            this.lblCopied.AutoSize = true;
            this.lblCopied.ForeColor = System.Drawing.Color.Green;
            this.lblCopied.Location = new System.Drawing.Point(457, 98);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(128, 16);
            this.lblCopied.TabIndex = 13;
            this.lblCopied.Text = "Copied to clipboard.";
            this.lblCopied.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(533, 62);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 34);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Specify a password (required to open the file):";
            // 
            // btnPasswordGenerate
            // 
            this.btnPasswordGenerate.Location = new System.Drawing.Point(444, 62);
            this.btnPasswordGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPasswordGenerate.Name = "btnPasswordGenerate";
            this.btnPasswordGenerate.Size = new System.Drawing.Size(84, 34);
            this.btnPasswordGenerate.TabIndex = 10;
            this.btnPasswordGenerate.Text = "Generate";
            this.btnPasswordGenerate.UseVisualStyleBackColor = true;
            this.btnPasswordGenerate.Click += new System.EventHandler(this.btnPasswordGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(28, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(409, 34);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(475, 446);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(149, 49);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(303, 446);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 49);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "PDF Files|*.pdf|All files|*.*";
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "PDF Files|*.pdf|All files|*.*";
            this.dlgSave.OverwritePrompt = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(15, 460);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(104, 34);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "Settings...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(641, 503);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "PDFEncrypt - free, open-source PDF encryption utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnInputBrowse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOutputBrowse;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnPasswordGenerate;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.SaveFileDialog dlgSave;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label lblCopied;
		private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.LinkLabel lnkPasswordOwner;
        public System.Windows.Forms.TextBox txtInputFile;
        public System.Windows.Forms.TextBox txtOutputFile;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Button btnEncrypt;
        public System.Windows.Forms.Label lblOwnerPasswordSet;
    }
}

