namespace PDFEncryptWinforms
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            btnInputBrowse = new System.Windows.Forms.Button();
            txtInputFile = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            btnOutputBrowse = new System.Windows.Forms.Button();
            txtOutputFile = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            lblOwnerPasswordSet = new System.Windows.Forms.Label();
            lnkPasswordOwner = new System.Windows.Forms.LinkLabel();
            lblPasswordLength = new System.Windows.Forms.Label();
            lblCopied = new System.Windows.Forms.Label();
            btnCopy = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnPasswordGenerate = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            btnEncrypt = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dlgOpen = new System.Windows.Forms.OpenFileDialog();
            dlgSave = new System.Windows.Forms.SaveFileDialog();
            btnSettings = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnInputBrowse);
            groupBox1.Controls.Add(txtInputFile);
            groupBox1.Location = new System.Drawing.Point(10, 11);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(542, 115);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source File";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(20, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(211, 24);
            label4.TabIndex = 11;
            label4.Text = "Choose a file to encrypt:";
            // 
            // btnInputBrowse
            // 
            btnInputBrowse.Location = new System.Drawing.Point(487, 58);
            btnInputBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnInputBrowse.Name = "btnInputBrowse";
            btnInputBrowse.Size = new System.Drawing.Size(42, 32);
            btnInputBrowse.TabIndex = 10;
            btnInputBrowse.Text = "...";
            btnInputBrowse.UseVisualStyleBackColor = true;
            btnInputBrowse.Click += btnInputBrowse_Click;
            // 
            // txtInputFile
            // 
            txtInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtInputFile.Location = new System.Drawing.Point(24, 58);
            txtInputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.Size = new System.Drawing.Size(448, 28);
            txtInputFile.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnOutputBrowse);
            groupBox2.Controls.Add(txtOutputFile);
            groupBox2.Location = new System.Drawing.Point(10, 133);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(542, 115);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Destination File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(20, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(365, 24);
            label2.TabIndex = 11;
            label2.Text = "Choose a destination for the encrypted file:";
            // 
            // btnOutputBrowse
            // 
            btnOutputBrowse.Location = new System.Drawing.Point(487, 58);
            btnOutputBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnOutputBrowse.Name = "btnOutputBrowse";
            btnOutputBrowse.Size = new System.Drawing.Size(42, 32);
            btnOutputBrowse.TabIndex = 10;
            btnOutputBrowse.Text = "...";
            btnOutputBrowse.UseVisualStyleBackColor = true;
            btnOutputBrowse.Click += btnOutputBrowse_Click;
            // 
            // txtOutputFile
            // 
            txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtOutputFile.Location = new System.Drawing.Point(24, 58);
            txtOutputFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOutputFile.Name = "txtOutputFile";
            txtOutputFile.Size = new System.Drawing.Size(448, 28);
            txtOutputFile.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblOwnerPasswordSet);
            groupBox3.Controls.Add(lnkPasswordOwner);
            groupBox3.Controls.Add(lblPasswordLength);
            groupBox3.Controls.Add(lblCopied);
            groupBox3.Controls.Add(btnCopy);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnPasswordGenerate);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Location = new System.Drawing.Point(11, 253);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Size = new System.Drawing.Size(542, 143);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Password";
            // 
            // lblOwnerPasswordSet
            // 
            lblOwnerPasswordSet.AutoSize = true;
            lblOwnerPasswordSet.ForeColor = System.Drawing.Color.FromArgb(0, 192, 192);
            lblOwnerPasswordSet.Location = new System.Drawing.Point(181, 115);
            lblOwnerPasswordSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOwnerPasswordSet.Name = "lblOwnerPasswordSet";
            lblOwnerPasswordSet.Size = new System.Drawing.Size(116, 15);
            lblOwnerPasswordSet.TabIndex = 16;
            lblOwnerPasswordSet.Text = "Owner password set.";
            lblOwnerPasswordSet.Visible = false;
            // 
            // lnkPasswordOwner
            // 
            lnkPasswordOwner.AutoSize = true;
            lnkPasswordOwner.Location = new System.Drawing.Point(32, 115);
            lnkPasswordOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnkPasswordOwner.Name = "lnkPasswordOwner";
            lnkPasswordOwner.Size = new System.Drawing.Size(114, 15);
            lnkPasswordOwner.TabIndex = 15;
            lnkPasswordOwner.TabStop = true;
            lnkPasswordOwner.Text = "Set Owner Password";
            lnkPasswordOwner.LinkClicked += lnkPasswordOwner_LinkClicked;
            // 
            // lblPasswordLength
            // 
            lblPasswordLength.AutoSize = true;
            lblPasswordLength.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            lblPasswordLength.Location = new System.Drawing.Point(22, 92);
            lblPasswordLength.Name = "lblPasswordLength";
            lblPasswordLength.Size = new System.Drawing.Size(292, 15);
            lblPasswordLength.TabIndex = 14;
            lblPasswordLength.Text = "Passwords longer than 32 characters will be truncated.";
            lblPasswordLength.Visible = false;
            // 
            // lblCopied
            // 
            lblCopied.AutoSize = true;
            lblCopied.ForeColor = System.Drawing.Color.Green;
            lblCopied.Location = new System.Drawing.Point(400, 92);
            lblCopied.Name = "lblCopied";
            lblCopied.Size = new System.Drawing.Size(115, 15);
            lblCopied.TabIndex = 13;
            lblCopied.Text = "Copied to clipboard.";
            lblCopied.Visible = false;
            // 
            // btnCopy
            // 
            btnCopy.Location = new System.Drawing.Point(466, 58);
            btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(60, 32);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(20, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(393, 24);
            label3.TabIndex = 11;
            label3.Text = "Specify a password (required to open the file):";
            // 
            // btnPasswordGenerate
            // 
            btnPasswordGenerate.Location = new System.Drawing.Point(388, 58);
            btnPasswordGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPasswordGenerate.Name = "btnPasswordGenerate";
            btnPasswordGenerate.Size = new System.Drawing.Size(74, 32);
            btnPasswordGenerate.TabIndex = 10;
            btnPasswordGenerate.Text = "Generate";
            btnPasswordGenerate.UseVisualStyleBackColor = true;
            btnPasswordGenerate.Click += btnPasswordGenerate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(24, 58);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(358, 28);
            txtPassword.TabIndex = 8;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEncrypt.Location = new System.Drawing.Point(416, 418);
            btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new System.Drawing.Size(130, 46);
            btnEncrypt.TabIndex = 14;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(265, 418);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(130, 46);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dlgOpen
            // 
            dlgOpen.Filter = "PDF Files|*.pdf|All files|*.*";
            // 
            // dlgSave
            // 
            dlgSave.Filter = "PDF Files|*.pdf|All files|*.*";
            dlgSave.OverwritePrompt = false;
            // 
            // btnSettings
            // 
            btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSettings.Location = new System.Drawing.Point(13, 431);
            btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(91, 32);
            btnSettings.TabIndex = 16;
            btnSettings.Text = "Settings...";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // frmMain
            // 
            AcceptButton = btnEncrypt;
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(561, 472);
            Controls.Add(btnSettings);
            Controls.Add(btnClose);
            Controls.Add(btnEncrypt);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            Text = "LockPDFy - swiftly encrypts PDF files";
            Load += frmMain_Load;
            DragDrop += frmMain_DragDrop;
            DragOver += frmMain_DragOver;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInputBrowse;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutputBrowse;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPasswordGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.LinkLabel lnkPasswordOwner;
        private System.Windows.Forms.Label lblOwnerPasswordSet;
    }
}

