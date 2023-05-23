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
            dlgOpen = new System.Windows.Forms.OpenFileDialog();
            dlgSave = new System.Windows.Forms.SaveFileDialog();
            btnSettings = new System.Windows.Forms.Button();
            tabControl = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            buttonInputBrowse = new System.Windows.Forms.Button();
            textBoxInputFilePathDecrypt = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            buttonOutputBrowse = new System.Windows.Forms.Button();
            textBoxOutputFilePathDecrypt = new System.Windows.Forms.TextBox();
            buttonDecrypt = new System.Windows.Forms.Button();
            groupBox6 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            textBoxPasswordDecrypt = new System.Windows.Forms.TextBox();
            labelPasswordWrong = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnInputBrowse);
            groupBox1.Controls.Add(txtInputFile);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // btnInputBrowse
            // 
            resources.ApplyResources(btnInputBrowse, "btnInputBrowse");
            btnInputBrowse.Name = "btnInputBrowse";
            btnInputBrowse.UseVisualStyleBackColor = true;
            btnInputBrowse.Click += btnInputBrowse_Click;
            // 
            // txtInputFile
            // 
            resources.ApplyResources(txtInputFile, "txtInputFile");
            txtInputFile.Name = "txtInputFile";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnOutputBrowse);
            groupBox2.Controls.Add(txtOutputFile);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // btnOutputBrowse
            // 
            resources.ApplyResources(btnOutputBrowse, "btnOutputBrowse");
            btnOutputBrowse.Name = "btnOutputBrowse";
            btnOutputBrowse.UseVisualStyleBackColor = true;
            btnOutputBrowse.Click += btnOutputBrowse_Click;
            // 
            // txtOutputFile
            // 
            resources.ApplyResources(txtOutputFile, "txtOutputFile");
            txtOutputFile.Name = "txtOutputFile";
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
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // lblOwnerPasswordSet
            // 
            resources.ApplyResources(lblOwnerPasswordSet, "lblOwnerPasswordSet");
            lblOwnerPasswordSet.ForeColor = System.Drawing.Color.FromArgb(0, 192, 192);
            lblOwnerPasswordSet.Name = "lblOwnerPasswordSet";
            // 
            // lnkPasswordOwner
            // 
            resources.ApplyResources(lnkPasswordOwner, "lnkPasswordOwner");
            lnkPasswordOwner.Name = "lnkPasswordOwner";
            lnkPasswordOwner.TabStop = true;
            lnkPasswordOwner.LinkClicked += lnkPasswordOwner_LinkClicked;
            // 
            // lblPasswordLength
            // 
            resources.ApplyResources(lblPasswordLength, "lblPasswordLength");
            lblPasswordLength.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            lblPasswordLength.Name = "lblPasswordLength";
            // 
            // lblCopied
            // 
            resources.ApplyResources(lblCopied, "lblCopied");
            lblCopied.ForeColor = System.Drawing.Color.Green;
            lblCopied.Name = "lblCopied";
            // 
            // btnCopy
            // 
            resources.ApplyResources(btnCopy, "btnCopy");
            btnCopy.Name = "btnCopy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // btnPasswordGenerate
            // 
            resources.ApplyResources(btnPasswordGenerate, "btnPasswordGenerate");
            btnPasswordGenerate.Name = "btnPasswordGenerate";
            btnPasswordGenerate.UseVisualStyleBackColor = true;
            btnPasswordGenerate.Click += btnPasswordGenerate_Click;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnEncrypt
            // 
            resources.ApplyResources(btnEncrypt, "btnEncrypt");
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // dlgOpen
            // 
            resources.ApplyResources(dlgOpen, "dlgOpen");
            // 
            // dlgSave
            // 
            resources.ApplyResources(dlgSave, "dlgSave");
            dlgSave.OverwritePrompt = false;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            resources.ApplyResources(tabControl, "tabControl");
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnSettings);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(btnEncrypt);
            tabPage1.Controls.Add(groupBox3);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelPasswordWrong);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(buttonDecrypt);
            tabPage2.Controls.Add(groupBox6);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(buttonInputBrowse);
            groupBox4.Controls.Add(textBoxInputFilePathDecrypt);
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // buttonInputBrowse
            // 
            resources.ApplyResources(buttonInputBrowse, "buttonInputBrowse");
            buttonInputBrowse.Name = "buttonInputBrowse";
            buttonInputBrowse.UseVisualStyleBackColor = true;
            buttonInputBrowse.Click += buttonInputBrowse_Click;
            // 
            // textBoxInputFilePathDecrypt
            // 
            resources.ApplyResources(textBoxInputFilePathDecrypt, "textBoxInputFilePathDecrypt");
            textBoxInputFilePathDecrypt.Name = "textBoxInputFilePathDecrypt";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(buttonOutputBrowse);
            groupBox5.Controls.Add(textBoxOutputFilePathDecrypt);
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // buttonOutputBrowse
            // 
            resources.ApplyResources(buttonOutputBrowse, "buttonOutputBrowse");
            buttonOutputBrowse.Name = "buttonOutputBrowse";
            buttonOutputBrowse.UseVisualStyleBackColor = true;
            buttonOutputBrowse.Click += buttonOutputBrowse_Click;
            // 
            // textBoxOutputFilePathDecrypt
            // 
            resources.ApplyResources(textBoxOutputFilePathDecrypt, "textBoxOutputFilePathDecrypt");
            textBoxOutputFilePathDecrypt.Name = "textBoxOutputFilePathDecrypt";
            // 
            // buttonDecrypt
            // 
            resources.ApplyResources(buttonDecrypt, "buttonDecrypt");
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(textBoxPasswordDecrypt);
            resources.ApplyResources(groupBox6, "groupBox6");
            groupBox6.Name = "groupBox6";
            groupBox6.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // textBoxPasswordDecrypt
            // 
            resources.ApplyResources(textBoxPasswordDecrypt, "textBoxPasswordDecrypt");
            textBoxPasswordDecrypt.Name = "textBoxPasswordDecrypt";
            // 
            // labelPasswordWrong
            // 
            resources.ApplyResources(labelPasswordWrong, "labelPasswordWrong");
            labelPasswordWrong.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            labelPasswordWrong.Name = "labelPasswordWrong";
            // 
            // frmMain
            // 
            AcceptButton = btnEncrypt;
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            Load += frmMain_Load;
            DragDrop += frmMain_DragDrop;
            DragOver += frmMain_DragOver;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.LinkLabel lnkPasswordOwner;
        private System.Windows.Forms.Label lblOwnerPasswordSet;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInputBrowse;
        private System.Windows.Forms.TextBox textBoxInputFilePathDecrypt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOutputBrowse;
        private System.Windows.Forms.TextBox textBoxOutputFilePathDecrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPasswordDecrypt;
        private System.Windows.Forms.Label labelPasswordWrong;
    }
}

