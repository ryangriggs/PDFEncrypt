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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dlgOpen
            // 
            resources.ApplyResources(this.dlgOpen, "dlgOpen");
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOpen);
            this.groupBox1.Controls.Add(this.chkShowFolder);
            this.groupBox1.Controls.Add(this.chkCloseAfterCompletion);
            this.groupBox1.Controls.Add(this.btnRunBrowse);
            this.groupBox1.Controls.Add(this.txtRun);
            this.groupBox1.Controls.Add(this.chkRun);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkOpen
            // 
            resources.ApplyResources(this.chkOpen, "chkOpen");
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // chkShowFolder
            // 
            resources.ApplyResources(this.chkShowFolder, "chkShowFolder");
            this.chkShowFolder.Name = "chkShowFolder";
            this.chkShowFolder.UseVisualStyleBackColor = true;
            // 
            // chkCloseAfterCompletion
            // 
            resources.ApplyResources(this.chkCloseAfterCompletion, "chkCloseAfterCompletion");
            this.chkCloseAfterCompletion.Name = "chkCloseAfterCompletion";
            this.chkCloseAfterCompletion.UseVisualStyleBackColor = true;
            // 
            // btnRunBrowse
            // 
            resources.ApplyResources(this.btnRunBrowse, "btnRunBrowse");
            this.btnRunBrowse.Name = "btnRunBrowse";
            this.btnRunBrowse.UseVisualStyleBackColor = true;
            // 
            // txtRun
            // 
            resources.ApplyResources(this.txtRun, "txtRun");
            this.txtRun.Name = "txtRun";
            // 
            // chkRun
            // 
            resources.ApplyResources(this.chkRun, "chkRun");
            this.chkRun.Name = "chkRun";
            this.chkRun.UseVisualStyleBackColor = true;
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Name = "label4";
            // 
            // chkDegradedPrinting
            // 
            resources.ApplyResources(this.chkDegradedPrinting, "chkDegradedPrinting");
            this.chkDegradedPrinting.Name = "chkDegradedPrinting";
            this.chkDegradedPrinting.UseVisualStyleBackColor = true;
            // 
            // chkAssembly
            // 
            resources.ApplyResources(this.chkAssembly, "chkAssembly");
            this.chkAssembly.Name = "chkAssembly";
            this.chkAssembly.UseVisualStyleBackColor = true;
            // 
            // chkScreenreaders
            // 
            resources.ApplyResources(this.chkScreenreaders, "chkScreenreaders");
            this.chkScreenreaders.Name = "chkScreenreaders";
            this.chkScreenreaders.UseVisualStyleBackColor = true;
            // 
            // chkForms
            // 
            resources.ApplyResources(this.chkForms, "chkForms");
            this.chkForms.Name = "chkForms";
            this.chkForms.UseVisualStyleBackColor = true;
            // 
            // chkNotations
            // 
            resources.ApplyResources(this.chkNotations, "chkNotations");
            this.chkNotations.Name = "chkNotations";
            this.chkNotations.UseVisualStyleBackColor = true;
            // 
            // chkModifying
            // 
            resources.ApplyResources(this.chkModifying, "chkModifying");
            this.chkModifying.Name = "chkModifying";
            this.chkModifying.UseVisualStyleBackColor = true;
            // 
            // chkCopying
            // 
            resources.ApplyResources(this.chkCopying, "chkCopying");
            this.chkCopying.Name = "chkCopying";
            this.chkCopying.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chkPrinting
            // 
            resources.ApplyResources(this.chkPrinting, "chkPrinting");
            this.chkPrinting.Name = "chkPrinting";
            this.chkPrinting.UseVisualStyleBackColor = true;
            // 
            // chkEncryptMetadata
            // 
            resources.ApplyResources(this.chkEncryptMetadata, "chkEncryptMetadata");
            this.chkEncryptMetadata.Name = "chkEncryptMetadata";
            this.chkEncryptMetadata.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cboEncryptionType
            // 
            this.cboEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncryptionType.FormattingEnabled = true;
            resources.ApplyResources(this.cboEncryptionType, "cboEncryptionType");
            this.cboEncryptionType.Name = "cboEncryptionType";
            // 
            // chkPasswordConfirmation
            // 
            resources.ApplyResources(this.chkPasswordConfirmation, "chkPasswordConfirmation");
            this.chkPasswordConfirmation.Name = "chkPasswordConfirmation";
            this.chkPasswordConfirmation.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
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