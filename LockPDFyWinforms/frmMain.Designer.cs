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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnInputBrowse
            // 
            resources.ApplyResources(this.btnInputBrowse, "btnInputBrowse");
            this.btnInputBrowse.Name = "btnInputBrowse";
            this.btnInputBrowse.UseVisualStyleBackColor = true;
            // 
            // txtInputFile
            // 
            resources.ApplyResources(this.txtInputFile, "txtInputFile");
            this.txtInputFile.Name = "txtInputFile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnOutputBrowse);
            this.groupBox2.Controls.Add(this.txtOutputFile);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnOutputBrowse
            // 
            resources.ApplyResources(this.btnOutputBrowse, "btnOutputBrowse");
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            // 
            // txtOutputFile
            // 
            resources.ApplyResources(this.txtOutputFile, "txtOutputFile");
            this.txtOutputFile.Name = "txtOutputFile";
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
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lblOwnerPasswordSet
            // 
            resources.ApplyResources(this.lblOwnerPasswordSet, "lblOwnerPasswordSet");
            this.lblOwnerPasswordSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOwnerPasswordSet.Name = "lblOwnerPasswordSet";
            // 
            // lnkPasswordOwner
            // 
            resources.ApplyResources(this.lnkPasswordOwner, "lnkPasswordOwner");
            this.lnkPasswordOwner.Name = "lnkPasswordOwner";
            this.lnkPasswordOwner.TabStop = true;
            // 
            // lblPasswordLength
            // 
            resources.ApplyResources(this.lblPasswordLength, "lblPasswordLength");
            this.lblPasswordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPasswordLength.Name = "lblPasswordLength";
            // 
            // lblCopied
            // 
            resources.ApplyResources(this.lblCopied, "lblCopied");
            this.lblCopied.ForeColor = System.Drawing.Color.Green;
            this.lblCopied.Name = "lblCopied";
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnPasswordGenerate
            // 
            resources.ApplyResources(this.btnPasswordGenerate, "btnPasswordGenerate");
            this.btnPasswordGenerate.Name = "btnPasswordGenerate";
            this.btnPasswordGenerate.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // btnEncrypt
            // 
            resources.ApplyResources(this.btnEncrypt, "btnEncrypt");
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dlgOpen
            // 
            resources.ApplyResources(this.dlgOpen, "dlgOpen");
            // 
            // dlgSave
            // 
            resources.ApplyResources(this.dlgSave, "dlgSave");
            this.dlgSave.OverwritePrompt = false;
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
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

