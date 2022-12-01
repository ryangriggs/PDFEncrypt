using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFEncrypt
{
	public partial class frmInputBox : Form
	{
		public string result;   // The result of the input box action.
		public string prompt;   // Prompt to be displayed.
		public string title;    // Title of box
		public bool password;	// Is the input a password?

		public bool cancelled;
		public frmInputBox()
		{
			InitializeComponent();
		}

		private void frmInputBox_Load(object sender, EventArgs e)
		{
			
			
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			result = txtInput.Text;
			cancelled = false;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			prompt = "";
			cancelled = true;
			this.Close();
		}

		private void frmInputBox_Shown(object sender, EventArgs e)
		{
			txtInput.Focus();
			txtInput.Text = ""; // Clear input on load.
			lblPrompt.Text = prompt;
			this.Text = title;
			txtInput.PasswordChar = (password) ? '*' : (char)0;
		}
	}
}
