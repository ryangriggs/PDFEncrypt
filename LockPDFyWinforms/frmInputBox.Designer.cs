namespace PDFEncryptWinforms
{
    partial class frmInputBox
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
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtInput = new System.Windows.Forms.TextBox();
            lblPrompt = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(394, 12);
            btnOK.Margin = new System.Windows.Forms.Padding(2);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(65, 32);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(394, 48);
            btnCancel.Margin = new System.Windows.Forms.Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(65, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new System.Drawing.Point(11, 122);
            txtInput.Margin = new System.Windows.Forms.Padding(2);
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(366, 23);
            txtInput.TabIndex = 3;
            // 
            // lblPrompt
            // 
            lblPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblPrompt.Location = new System.Drawing.Point(13, 12);
            lblPrompt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblPrompt.Multiline = true;
            lblPrompt.Name = "lblPrompt";
            lblPrompt.ReadOnly = true;
            lblPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            lblPrompt.Size = new System.Drawing.Size(364, 105);
            lblPrompt.TabIndex = 4;
            lblPrompt.Text = "prompt";
            // 
            // frmInputBox
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(477, 155);
            Controls.Add(lblPrompt);
            Controls.Add(txtInput);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInputBox";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Title";
            Load += frmInputBox_Load;
            Shown += frmInputBox_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox lblPrompt;
    }
}