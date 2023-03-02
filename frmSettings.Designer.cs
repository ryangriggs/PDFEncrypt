namespace PDFEncrypt
{
	partial class frmSettings
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
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblVisitSite = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.chkShowFolder = new System.Windows.Forms.CheckBox();
            this.chkCloseAfterCompletion = new System.Windows.Forms.CheckBox();
            this.btnRunBrowse = new System.Windows.Forms.Button();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.chkRun = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDegradedPrinting = new System.Windows.Forms.CheckBox();
            this.chkAssembly = new System.Windows.Forms.CheckBox();
            this.chkScreenreaders = new System.Windows.Forms.CheckBox();
            this.chkForms = new System.Windows.Forms.CheckBox();
            this.chkNotations = new System.Windows.Forms.CheckBox();
            this.chkModifying = new System.Windows.Forms.CheckBox();
            this.chkCopying = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPrinting = new System.Windows.Forms.CheckBox();
            this.chkEncryptMetadata = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEncryptionType = new System.Windows.Forms.ComboBox();
            this.chkPasswordConfirmation = new System.Windows.Forms.CheckBox();
            this.linkDonate = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(9, 357);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(54, 13);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version: []";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright 2019-2023. Licensed under AGPL.";
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Executable files|*.exe,*.bat,*.com|All files|*.*";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(330, 10);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 32);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(330, 46);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblVisitSite
            // 
            this.lblVisitSite.AutoSize = true;
            this.lblVisitSite.Location = new System.Drawing.Point(292, 371);
            this.lblVisitSite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisitSite.Name = "lblVisitSite";
            this.lblVisitSite.Size = new System.Drawing.Size(111, 13);
            this.lblVisitSite.TabIndex = 14;
            this.lblVisitSite.TabStop = true;
            this.lblVisitSite.Text = "https://pdfencrypt.net";
            this.lblVisitSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVisitSite_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtArguments);
            this.groupBox1.Controls.Add(this.chkOpen);
            this.groupBox1.Controls.Add(this.chkShowFolder);
            this.groupBox1.Controls.Add(this.chkCloseAfterCompletion);
            this.groupBox1.Controls.Add(this.btnRunBrowse);
            this.groupBox1.Controls.Add(this.txtRun);
            this.groupBox1.Controls.Add(this.chkRun);
            this.groupBox1.Location = new System.Drawing.Point(11, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(392, 131);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "After successful encryption:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(109, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "(Output File path is appended as last argument)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Arguments:";
            // 
            // txtArguments
            // 
            this.txtArguments.Location = new System.Drawing.Point(109, 89);
            this.txtArguments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(229, 20);
            this.txtArguments.TabIndex = 20;
            // 
            // chkOpen
            // 
            this.chkOpen.AutoSize = true;
            this.chkOpen.Location = new System.Drawing.Point(212, 25);
            this.chkOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(122, 17);
            this.chkOpen.TabIndex = 19;
            this.chkOpen.Text = "Open destination file";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // chkShowFolder
            // 
            this.chkShowFolder.AutoSize = true;
            this.chkShowFolder.Location = new System.Drawing.Point(15, 24);
            this.chkShowFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkShowFolder.Name = "chkShowFolder";
            this.chkShowFolder.Size = new System.Drawing.Size(175, 17);
            this.chkShowFolder.TabIndex = 18;
            this.chkShowFolder.Text = "Show destination file in Explorer";
            this.chkShowFolder.UseVisualStyleBackColor = true;
            // 
            // chkCloseAfterCompletion
            // 
            this.chkCloseAfterCompletion.AutoSize = true;
            this.chkCloseAfterCompletion.Location = new System.Drawing.Point(15, 46);
            this.chkCloseAfterCompletion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCloseAfterCompletion.Name = "chkCloseAfterCompletion";
            this.chkCloseAfterCompletion.Size = new System.Drawing.Size(112, 17);
            this.chkCloseAfterCompletion.TabIndex = 17;
            this.chkCloseAfterCompletion.Text = "Close PDFEncrypt";
            this.chkCloseAfterCompletion.UseVisualStyleBackColor = true;
            // 
            // btnRunBrowse
            // 
            this.btnRunBrowse.Location = new System.Drawing.Point(341, 68);
            this.btnRunBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRunBrowse.Name = "btnRunBrowse";
            this.btnRunBrowse.Size = new System.Drawing.Size(37, 19);
            this.btnRunBrowse.TabIndex = 16;
            this.btnRunBrowse.Text = "...";
            this.btnRunBrowse.UseVisualStyleBackColor = true;
            this.btnRunBrowse.Click += new System.EventHandler(this.btnRunBrowse_Click);
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(109, 68);
            this.txtRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(229, 20);
            this.txtRun.TabIndex = 15;
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Location = new System.Drawing.Point(15, 68);
            this.chkRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(99, 17);
            this.chkRun.TabIndex = 14;
            this.chkRun.Text = "Run a program:";
            this.chkRun.UseVisualStyleBackColor = true;
            this.chkRun.CheckedChanged += new System.EventHandler(this.chkRun_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkDegradedPrinting);
            this.groupBox2.Controls.Add(this.chkAssembly);
            this.groupBox2.Controls.Add(this.chkScreenreaders);
            this.groupBox2.Controls.Add(this.chkForms);
            this.groupBox2.Controls.Add(this.chkNotations);
            this.groupBox2.Controls.Add(this.chkModifying);
            this.groupBox2.Controls.Add(this.chkCopying);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkPrinting);
            this.groupBox2.Controls.Add(this.chkEncryptMetadata);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboEncryptionType);
            this.groupBox2.Controls.Add(this.chkPasswordConfirmation);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(311, 210);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption options:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "These permissions are ignored by some PDF viewers.";
            // 
            // chkDegradedPrinting
            // 
            this.chkDegradedPrinting.AutoSize = true;
            this.chkDegradedPrinting.Location = new System.Drawing.Point(160, 63);
            this.chkDegradedPrinting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDegradedPrinting.Name = "chkDegradedPrinting";
            this.chkDegradedPrinting.Size = new System.Drawing.Size(130, 17);
            this.chkDegradedPrinting.TabIndex = 25;
            this.chkDegradedPrinting.Text = "Allow printing (low-res)";
            this.chkDegradedPrinting.UseVisualStyleBackColor = true;
            // 
            // chkAssembly
            // 
            this.chkAssembly.AutoSize = true;
            this.chkAssembly.Location = new System.Drawing.Point(27, 129);
            this.chkAssembly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAssembly.Name = "chkAssembly";
            this.chkAssembly.Size = new System.Drawing.Size(97, 17);
            this.chkAssembly.TabIndex = 24;
            this.chkAssembly.Text = "Allow assembly";
            this.chkAssembly.UseVisualStyleBackColor = true;
            // 
            // chkScreenreaders
            // 
            this.chkScreenreaders.AutoSize = true;
            this.chkScreenreaders.Location = new System.Drawing.Point(160, 129);
            this.chkScreenreaders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkScreenreaders.Name = "chkScreenreaders";
            this.chkScreenreaders.Size = new System.Drawing.Size(121, 17);
            this.chkScreenreaders.TabIndex = 23;
            this.chkScreenreaders.Text = "Allow screenreaders";
            this.chkScreenreaders.UseVisualStyleBackColor = true;
            // 
            // chkForms
            // 
            this.chkForms.AutoSize = true;
            this.chkForms.Location = new System.Drawing.Point(160, 107);
            this.chkForms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkForms.Name = "chkForms";
            this.chkForms.Size = new System.Drawing.Size(86, 17);
            this.chkForms.TabIndex = 22;
            this.chkForms.Text = "Allow form fill";
            this.chkForms.UseVisualStyleBackColor = true;
            // 
            // chkNotations
            // 
            this.chkNotations.AutoSize = true;
            this.chkNotations.Location = new System.Drawing.Point(160, 85);
            this.chkNotations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNotations.Name = "chkNotations";
            this.chkNotations.Size = new System.Drawing.Size(142, 17);
            this.chkNotations.TabIndex = 21;
            this.chkNotations.Text = "Allow modify annotations";
            this.chkNotations.UseVisualStyleBackColor = true;
            // 
            // chkModifying
            // 
            this.chkModifying.AutoSize = true;
            this.chkModifying.Location = new System.Drawing.Point(27, 85);
            this.chkModifying.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkModifying.Name = "chkModifying";
            this.chkModifying.Size = new System.Drawing.Size(98, 17);
            this.chkModifying.TabIndex = 20;
            this.chkModifying.Text = "Allow modifying";
            this.chkModifying.UseVisualStyleBackColor = true;
            // 
            // chkCopying
            // 
            this.chkCopying.AutoSize = true;
            this.chkCopying.Location = new System.Drawing.Point(27, 107);
            this.chkCopying.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCopying.Name = "chkCopying";
            this.chkCopying.Size = new System.Drawing.Size(91, 17);
            this.chkCopying.TabIndex = 19;
            this.chkCopying.Text = "Allow copying";
            this.chkCopying.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Permissions";
            // 
            // chkPrinting
            // 
            this.chkPrinting.AutoSize = true;
            this.chkPrinting.Location = new System.Drawing.Point(27, 63);
            this.chkPrinting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPrinting.Name = "chkPrinting";
            this.chkPrinting.Size = new System.Drawing.Size(122, 17);
            this.chkPrinting.TabIndex = 17;
            this.chkPrinting.Text = "Allow printing (hi-res)";
            this.chkPrinting.UseVisualStyleBackColor = true;
            // 
            // chkEncryptMetadata
            // 
            this.chkEncryptMetadata.AutoSize = true;
            this.chkEncryptMetadata.Location = new System.Drawing.Point(160, 24);
            this.chkEncryptMetadata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEncryptMetadata.Name = "chkEncryptMetadata";
            this.chkEncryptMetadata.Size = new System.Drawing.Size(109, 17);
            this.chkEncryptMetadata.TabIndex = 16;
            this.chkEncryptMetadata.Text = "Encrypt metadata";
            this.chkEncryptMetadata.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Algorithm:";
            // 
            // cboEncryptionType
            // 
            this.cboEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncryptionType.FormattingEnabled = true;
            this.cboEncryptionType.Location = new System.Drawing.Point(62, 180);
            this.cboEncryptionType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEncryptionType.Name = "cboEncryptionType";
            this.cboEncryptionType.Size = new System.Drawing.Size(229, 21);
            this.cboEncryptionType.TabIndex = 14;
            // 
            // chkPasswordConfirmation
            // 
            this.chkPasswordConfirmation.AutoSize = true;
            this.chkPasswordConfirmation.Location = new System.Drawing.Point(15, 24);
            this.chkPasswordConfirmation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPasswordConfirmation.Name = "chkPasswordConfirmation";
            this.chkPasswordConfirmation.Size = new System.Drawing.Size(109, 17);
            this.chkPasswordConfirmation.TabIndex = 13;
            this.chkPasswordConfirmation.Text = "Confirm password";
            this.chkPasswordConfirmation.UseVisualStyleBackColor = true;
            // 
            // linkDonate
            // 
            this.linkDonate.AutoSize = true;
            this.linkDonate.Location = new System.Drawing.Point(70, 392);
            this.linkDonate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Size = new System.Drawing.Size(261, 13);
            this.linkDonate.TabIndex = 17;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "Consider donating if this app is helpful to you. Thanks!";
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate_LinkClicked);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(413, 409);
            this.Controls.Add(this.linkDonate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVisitSite);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.LinkLabel lblVisitSite;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkShowFolder;
		private System.Windows.Forms.CheckBox chkCloseAfterCompletion;
		private System.Windows.Forms.Button btnRunBrowse;
		private System.Windows.Forms.TextBox txtRun;
		private System.Windows.Forms.CheckBox chkRun;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkPrinting;
		private System.Windows.Forms.CheckBox chkEncryptMetadata;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboEncryptionType;
		private System.Windows.Forms.CheckBox chkPasswordConfirmation;
		private System.Windows.Forms.CheckBox chkOpen;
		private System.Windows.Forms.CheckBox chkDegradedPrinting;
		private System.Windows.Forms.CheckBox chkAssembly;
		private System.Windows.Forms.CheckBox chkScreenreaders;
		private System.Windows.Forms.CheckBox chkForms;
		private System.Windows.Forms.CheckBox chkNotations;
		private System.Windows.Forms.CheckBox chkModifying;
		private System.Windows.Forms.CheckBox chkCopying;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkDonate;
    }
}