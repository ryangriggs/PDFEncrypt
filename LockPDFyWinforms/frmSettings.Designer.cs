namespace PDFEncryptWinforms
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
            lblVersion = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dlgOpen = new System.Windows.Forms.OpenFileDialog();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            chkOpen = new System.Windows.Forms.CheckBox();
            chkShowFolder = new System.Windows.Forms.CheckBox();
            chkCloseAfterCompletion = new System.Windows.Forms.CheckBox();
            btnRunBrowse = new System.Windows.Forms.Button();
            txtRun = new System.Windows.Forms.TextBox();
            chkRun = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            chkDegradedPrinting = new System.Windows.Forms.CheckBox();
            chkAssembly = new System.Windows.Forms.CheckBox();
            chkScreenreaders = new System.Windows.Forms.CheckBox();
            chkForms = new System.Windows.Forms.CheckBox();
            chkNotations = new System.Windows.Forms.CheckBox();
            chkModifying = new System.Windows.Forms.CheckBox();
            chkCopying = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            chkPrinting = new System.Windows.Forms.CheckBox();
            chkEncryptMetadata = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            cboEncryptionType = new System.Windows.Forms.ComboBox();
            chkPasswordConfirmation = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(10, 372);
            lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(59, 15);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version: []";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 388);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Licensed under AGPL.";
            // 
            // dlgOpen
            // 
            dlgOpen.Filter = "Executable files|*.exe,*.bat,*.com|All files|*.*";
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(385, 12);
            btnOK.Margin = new System.Windows.Forms.Padding(2);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(85, 37);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(385, 53);
            btnCancel.Margin = new System.Windows.Forms.Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(85, 37);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkOpen);
            groupBox1.Controls.Add(chkShowFolder);
            groupBox1.Controls.Add(chkCloseAfterCompletion);
            groupBox1.Controls.Add(btnRunBrowse);
            groupBox1.Controls.Add(txtRun);
            groupBox1.Controls.Add(chkRun);
            groupBox1.Location = new System.Drawing.Point(13, 258);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(457, 111);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "After successful encryption:";
            // 
            // chkOpen
            // 
            chkOpen.AutoSize = true;
            chkOpen.Location = new System.Drawing.Point(247, 29);
            chkOpen.Margin = new System.Windows.Forms.Padding(2);
            chkOpen.Name = "chkOpen";
            chkOpen.Size = new System.Drawing.Size(136, 19);
            chkOpen.TabIndex = 19;
            chkOpen.Text = "Open destination file";
            chkOpen.UseVisualStyleBackColor = true;
            // 
            // chkShowFolder
            // 
            chkShowFolder.AutoSize = true;
            chkShowFolder.Location = new System.Drawing.Point(18, 28);
            chkShowFolder.Margin = new System.Windows.Forms.Padding(2);
            chkShowFolder.Name = "chkShowFolder";
            chkShowFolder.Size = new System.Drawing.Size(195, 19);
            chkShowFolder.TabIndex = 18;
            chkShowFolder.Text = "Show destination file in Explorer";
            chkShowFolder.UseVisualStyleBackColor = true;
            // 
            // chkCloseAfterCompletion
            // 
            chkCloseAfterCompletion.AutoSize = true;
            chkCloseAfterCompletion.Location = new System.Drawing.Point(18, 53);
            chkCloseAfterCompletion.Margin = new System.Windows.Forms.Padding(2);
            chkCloseAfterCompletion.Name = "chkCloseAfterCompletion";
            chkCloseAfterCompletion.Size = new System.Drawing.Size(119, 19);
            chkCloseAfterCompletion.TabIndex = 17;
            chkCloseAfterCompletion.Text = "Close PDFEncrypt";
            chkCloseAfterCompletion.UseVisualStyleBackColor = true;
            // 
            // btnRunBrowse
            // 
            btnRunBrowse.Location = new System.Drawing.Point(398, 78);
            btnRunBrowse.Margin = new System.Windows.Forms.Padding(2);
            btnRunBrowse.Name = "btnRunBrowse";
            btnRunBrowse.Size = new System.Drawing.Size(43, 22);
            btnRunBrowse.TabIndex = 16;
            btnRunBrowse.Text = "...";
            btnRunBrowse.UseVisualStyleBackColor = true;
            btnRunBrowse.Click += btnRunBrowse_Click;
            // 
            // txtRun
            // 
            txtRun.Location = new System.Drawing.Point(127, 78);
            txtRun.Margin = new System.Windows.Forms.Padding(2);
            txtRun.Name = "txtRun";
            txtRun.Size = new System.Drawing.Size(266, 23);
            txtRun.TabIndex = 15;
            // 
            // chkRun
            // 
            chkRun.AutoSize = true;
            chkRun.Location = new System.Drawing.Point(18, 78);
            chkRun.Margin = new System.Windows.Forms.Padding(2);
            chkRun.Name = "chkRun";
            chkRun.Size = new System.Drawing.Size(108, 19);
            chkRun.TabIndex = 14;
            chkRun.Text = "Run a program:";
            chkRun.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(chkDegradedPrinting);
            groupBox2.Controls.Add(chkAssembly);
            groupBox2.Controls.Add(chkScreenreaders);
            groupBox2.Controls.Add(chkForms);
            groupBox2.Controls.Add(chkNotations);
            groupBox2.Controls.Add(chkModifying);
            groupBox2.Controls.Add(chkCopying);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(chkPrinting);
            groupBox2.Controls.Add(chkEncryptMetadata);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboEncryptionType);
            groupBox2.Controls.Add(chkPasswordConfirmation);
            groupBox2.Location = new System.Drawing.Point(13, 12);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(363, 242);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encryption options:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            label4.Location = new System.Drawing.Point(27, 173);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(283, 15);
            label4.TabIndex = 26;
            label4.Text = "These permissions are ignored by some PDF viewers.";
            // 
            // chkDegradedPrinting
            // 
            chkDegradedPrinting.AutoSize = true;
            chkDegradedPrinting.Location = new System.Drawing.Point(187, 73);
            chkDegradedPrinting.Margin = new System.Windows.Forms.Padding(2);
            chkDegradedPrinting.Name = "chkDegradedPrinting";
            chkDegradedPrinting.Size = new System.Drawing.Size(151, 19);
            chkDegradedPrinting.TabIndex = 25;
            chkDegradedPrinting.Text = "Allow printing (low-res)";
            chkDegradedPrinting.UseVisualStyleBackColor = true;
            // 
            // chkAssembly
            // 
            chkAssembly.AutoSize = true;
            chkAssembly.Location = new System.Drawing.Point(31, 149);
            chkAssembly.Margin = new System.Windows.Forms.Padding(2);
            chkAssembly.Name = "chkAssembly";
            chkAssembly.Size = new System.Drawing.Size(108, 19);
            chkAssembly.TabIndex = 24;
            chkAssembly.Text = "Allow assembly";
            chkAssembly.UseVisualStyleBackColor = true;
            // 
            // chkScreenreaders
            // 
            chkScreenreaders.AutoSize = true;
            chkScreenreaders.Location = new System.Drawing.Point(187, 149);
            chkScreenreaders.Margin = new System.Windows.Forms.Padding(2);
            chkScreenreaders.Name = "chkScreenreaders";
            chkScreenreaders.Size = new System.Drawing.Size(131, 19);
            chkScreenreaders.TabIndex = 23;
            chkScreenreaders.Text = "Allow screenreaders";
            chkScreenreaders.UseVisualStyleBackColor = true;
            // 
            // chkForms
            // 
            chkForms.AutoSize = true;
            chkForms.Location = new System.Drawing.Point(187, 123);
            chkForms.Margin = new System.Windows.Forms.Padding(2);
            chkForms.Name = "chkForms";
            chkForms.Size = new System.Drawing.Size(101, 19);
            chkForms.TabIndex = 22;
            chkForms.Text = "Allow form fill";
            chkForms.UseVisualStyleBackColor = true;
            // 
            // chkNotations
            // 
            chkNotations.AutoSize = true;
            chkNotations.Location = new System.Drawing.Point(187, 98);
            chkNotations.Margin = new System.Windows.Forms.Padding(2);
            chkNotations.Name = "chkNotations";
            chkNotations.Size = new System.Drawing.Size(163, 19);
            chkNotations.TabIndex = 21;
            chkNotations.Text = "Allow modify annotations";
            chkNotations.UseVisualStyleBackColor = true;
            // 
            // chkModifying
            // 
            chkModifying.AutoSize = true;
            chkModifying.Location = new System.Drawing.Point(31, 98);
            chkModifying.Margin = new System.Windows.Forms.Padding(2);
            chkModifying.Name = "chkModifying";
            chkModifying.Size = new System.Drawing.Size(114, 19);
            chkModifying.TabIndex = 20;
            chkModifying.Text = "Allow modifying";
            chkModifying.UseVisualStyleBackColor = true;
            // 
            // chkCopying
            // 
            chkCopying.AutoSize = true;
            chkCopying.Location = new System.Drawing.Point(31, 123);
            chkCopying.Margin = new System.Windows.Forms.Padding(2);
            chkCopying.Name = "chkCopying";
            chkCopying.Size = new System.Drawing.Size(102, 19);
            chkCopying.TabIndex = 19;
            chkCopying.Text = "Allow copying";
            chkCopying.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 54);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 15);
            label2.TabIndex = 18;
            label2.Text = "Permissions";
            // 
            // chkPrinting
            // 
            chkPrinting.AutoSize = true;
            chkPrinting.Location = new System.Drawing.Point(31, 73);
            chkPrinting.Margin = new System.Windows.Forms.Padding(2);
            chkPrinting.Name = "chkPrinting";
            chkPrinting.Size = new System.Drawing.Size(142, 19);
            chkPrinting.TabIndex = 17;
            chkPrinting.Text = "Allow printing (hi-res)";
            chkPrinting.UseVisualStyleBackColor = true;
            // 
            // chkEncryptMetadata
            // 
            chkEncryptMetadata.AutoSize = true;
            chkEncryptMetadata.Location = new System.Drawing.Point(187, 28);
            chkEncryptMetadata.Margin = new System.Windows.Forms.Padding(2);
            chkEncryptMetadata.Name = "chkEncryptMetadata";
            chkEncryptMetadata.Size = new System.Drawing.Size(119, 19);
            chkEncryptMetadata.TabIndex = 16;
            chkEncryptMetadata.Text = "Encrypt metadata";
            chkEncryptMetadata.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 210);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 15);
            label3.TabIndex = 15;
            label3.Text = "Algorithm:";
            label3.Click += label3_Click;
            // 
            // cboEncryptionType
            // 
            cboEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEncryptionType.FormattingEnabled = true;
            cboEncryptionType.Location = new System.Drawing.Point(72, 208);
            cboEncryptionType.Margin = new System.Windows.Forms.Padding(2);
            cboEncryptionType.Name = "cboEncryptionType";
            cboEncryptionType.Size = new System.Drawing.Size(266, 23);
            cboEncryptionType.TabIndex = 14;
            cboEncryptionType.SelectedIndexChanged += cboEncryptionType_SelectedIndexChanged;
            // 
            // chkPasswordConfirmation
            // 
            chkPasswordConfirmation.AutoSize = true;
            chkPasswordConfirmation.Location = new System.Drawing.Point(18, 28);
            chkPasswordConfirmation.Margin = new System.Windows.Forms.Padding(2);
            chkPasswordConfirmation.Name = "chkPasswordConfirmation";
            chkPasswordConfirmation.Size = new System.Drawing.Size(123, 19);
            chkPasswordConfirmation.TabIndex = 13;
            chkPasswordConfirmation.Text = "Confirm password";
            chkPasswordConfirmation.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(482, 410);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(lblVersion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettings";
            Text = "Settings";
            Load += frmSettings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
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
    }
}