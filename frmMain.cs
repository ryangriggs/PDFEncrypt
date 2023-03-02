using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;
using Microsoft.VisualBasic;	// LOL

namespace PDFEncrypt
{
	

	public partial class frmMain : Form
	{
		const int PW_LENGTH_MIN = 12;	// Minimum generated password length
		const int PW_LENGTH_MAX = 24;   // Maximum generated password length
		const string PW_CHARS = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // List of characters to be used in random passwords

		public string owner_password = "";  // The owner password, if any.
		public bool encrypt_on_start = false;	// Allows encryption via command line without user interaction


		public frmMain()
		{
			InitializeComponent();
		}

		private string GetFilenameWithSuffix(string file, string suffix = "-encrypted")
		{
			var newFileName = $"{System.IO.Path.GetFileNameWithoutExtension(file)}{suffix}.pdf";
			return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(file), newFileName);
		}

		private void btnInputBrowse_Click(object sender, EventArgs e)
		{
			DialogResult result = dlgOpen.ShowDialog();
			if (result == DialogResult.Cancel) { return; }

			txtInputFile.Text = dlgOpen.FileName;
			txtOutputFile.Text = GetFilenameWithSuffix(dlgOpen.FileName);
		}

		private void btnOutputBrowse_Click(object sender, EventArgs e)
		{
			DialogResult result = dlgSave.ShowDialog();
			if (result == DialogResult.Cancel) { return; }

			txtOutputFile.Text = dlgSave.FileName;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			// Add listener for updated settings
			Settings.notify.Add(settingsChanged);

			// Load settings from registry
			Settings.load();		
			
			// If immediate run is enabled, click Run button (see command line options)
			if (encrypt_on_start)
            {
				// Click the Encrypt button immediately.
				btnEncrypt_Click(sender, e);
            }
		}

		private void settingsChanged()
		{
			// This function is executed when settings change.
			Console.WriteLine("Settings changed notification.");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			// Close the app
			this.Close();
		}

		private void btnPasswordGenerate_Click(object sender, EventArgs e)
		{
			// Generate a random password
			var rnd = new System.Random();	// Random number generator
			int length = rnd.Next(PW_LENGTH_MIN, PW_LENGTH_MAX);	// Choose password length.
			string result = "";

			// Pick 'length' characters from the allowed characters.
			for(int i = 0; i<length; i++)
			{
				result += PW_CHARS[rnd.Next(0, PW_CHARS.Length - 1)].ToString();
			}

			// Set password
			txtPassword.Text = result;

			// Copy to clipboard
			btnCopy_Click(sender, e);
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			// Copy password to clipboard.
			txtPassword.Focus();
			txtPassword.SelectAll();
			Clipboard.SetText(txtPassword.Text);

			// Show Copied label
			lblCopied.Visible = true;
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			// Hide Copied label
			lblCopied.Visible = false;

			// Show Password Length warning if exceeding 32 chars.
			lblPasswordLength.Visible = txtPassword.Text.Length > 32;

		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			// Hide Copied label
			lblCopied.Visible = false;

		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			// Clean up text
			txtInputFile.Text = txtInputFile.Text.Trim();
			txtOutputFile.Text = txtOutputFile.Text.Trim();

			// Ensure input and output are not the same.
			if (txtInputFile.Text.ToLower() == txtOutputFile.Text.ToLower())
			{
				MessageBox.Show("Source and Destination files cannot be the same.", "Invalid source/destination", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtOutputFile.Focus();
				txtOutputFile.SelectAll();
				return;
			}

			// Ensure input file exists.
			if (!File.Exists(txtInputFile.Text))
			{
				MessageBox.Show("Source file does not exist.");
				txtInputFile.Focus();
				txtInputFile.SelectAll();
				return;
			}

			// If output file exists, prompt to overwrite.
			if (File.Exists(txtOutputFile.Text))
			{
				if(MessageBox.Show("Destination file already exists.  Overwrite this file?","Overwrite file?", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					txtOutputFile.Focus();
					txtOutputFile.SelectAll();
					return;
				}
			}

			// Verify password:
			if (txtPassword.Text == "")
			{
				MessageBox.Show("No password specified.");
				txtPassword.Focus();
				return;
			}
			
			// Confirm password:
			if (Settings.password_confirm)
			{
				var input = new frmInputBox();
				input.prompt = "Please retype the User password to confirm.";
				input.title = "Confirm User Password";
				input.password = true;
				input.ShowDialog();	// Modal, blocking call

				if (input.cancelled) { return;  }

				// If password doesn't match, stop.
				if (input.result != txtPassword.Text)
				{
					MessageBox.Show("User password does not match. Please retry.");
					return;
				}

				if (owner_password != "")
                {
					input.prompt = "An Owner password has been set. Please confirm Owner password.";
					input.title = "Confirm Owner Password";
					input.password = true;
					input.ShowDialog();
					if (input.cancelled) { return; }
					if (input.result != owner_password)
                    {
						MessageBox.Show("Owner password does not match. Please retry.");
						return;
                    }
                }
			}

			// See https://itextpdf.com/en/resources/faq/technical-support/itext-7/how-protect-already-existing-pdf-password
			try
			{

				// Set mouse cursor to wait.
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();

				// Encryption properties:
				int encryption_properties = (int) Settings.encryption_type;
				
				// If specified, disable encrypting metadata.
				if (!Settings.encrypt_metadata)
				{
					encryption_properties |= EncryptionConstants.DO_NOT_ENCRYPT_METADATA;
				}

				// Set document options
				int document_options = 0;
				if (Settings.allow_printing)	{ document_options |= EncryptionConstants.ALLOW_PRINTING; }
				if (Settings.allow_degraded_printing) { document_options |= EncryptionConstants.ALLOW_DEGRADED_PRINTING; }
				if (Settings.allow_modifying) { document_options |= EncryptionConstants.ALLOW_MODIFY_CONTENTS; }
				if (Settings.allow_modifying_annotations) { document_options |= EncryptionConstants.ALLOW_MODIFY_ANNOTATIONS; }
				if (Settings.allow_copying) { document_options |= EncryptionConstants.ALLOW_COPY; }
				if (Settings.allow_form_fill) { document_options |= EncryptionConstants.ALLOW_FILL_IN; }
				if (Settings.allow_assembly) { document_options |= EncryptionConstants.ALLOW_ASSEMBLY; }
				if (Settings.allow_screenreaders) { document_options |= EncryptionConstants.ALLOW_SCREENREADERS; }

				PdfReader reader = new PdfReader(txtInputFile.Text);	// Create a PdfReader with the input file.
				WriterProperties prop = new WriterProperties();	// Set properties of output
	
				prop.SetStandardEncryption(Encoding.ASCII.GetBytes(txtPassword.Text), owner_password == "" ? null : Encoding.ASCII.GetBytes(owner_password), document_options, encryption_properties);  // Enable encryption
				// Setting Owner Password to null generates random password.

				PdfWriter writer = new PdfWriter(txtOutputFile.Text, prop);	// Set up the output file
				PdfDocument pdf = new PdfDocument(reader, writer);	// Create the new document
				pdf.Close();	// Close the output document.
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while processing the file: " + ex.Message);
				Cursor.Current = Cursors.Default;
				return;
			}

			// If launching a program:
			if (Settings.run_after)
			{
				// Attempt to run the program, passing the newly encrypted filename.
				try
				{
					Process.Start(Settings.run_after_file, Settings.run_after_arguments + " " + txtOutputFile.Text);
				}
				catch (Exception ex)
                {
					MessageBox.Show("Unable to run command.  Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

			}

			// If opening the output file:
			if (Settings.open_after)
			{
				// Attempt to launch the default app for the file.
				Process.Start(txtOutputFile.Text);
			}

			// If launching Explorer:
			if (Settings.show_folder_after)
			{
				// Attempt to launch the folder with the file highlighted.
				Process.Start("explorer.exe", "/select," + txtOutputFile.Text);
			}

			// If closing after encryption
			if (Settings.close_after)
			{
				this.Close();
			}

			Cursor.Current = Cursors.Default;	// Return to default cursor.
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			var settings = new frmSettings();
			settings.ShowDialog();
		}

        private void lnkPasswordOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			var input = new frmInputBox();
			input.title = "Set Owner Password";
			input.prompt = "Specify Owner password.\r\n(Owner password allows the viewer to bypass all permissions and gain full control of the PDF file.)\r\nIf no Owner password is specified, a random one will be generated.\r\n Click Cancel to clear existing Owner password.";
			input.password = true;
			input.ShowDialog();
			if (input.cancelled)
			{
				owner_password = "";
			}
			else
			{
				owner_password = input.result;
			}
			lblOwnerPasswordSet.Visible = (owner_password != "");
        }

      
    }
}
