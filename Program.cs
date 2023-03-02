using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandLine;
namespace PDFEncrypt
{
	static class Program
	{
		// Command line options (CommandLineParser plugin) https://github.com/commandlineparser/commandline
		public class Options
		{
			[Option("owner_pass", Required = false, HelpText = "Specify the Owner password")]
			public string OwnerPass { get; set; }

			[Option("user_pass", Required = false, HelpText = "Specify the User password")]
			public string UserPass { get; set; }

			[Option('i', "input", Required = false, HelpText = "Specify input PDF file to encrypt")]
			public string InputFile { get; set; }

			[Option('o', "output", Required = false, HelpText = "Specify the output encrypted PDF file to create.")]
			public string OutputFile { get; set; }

			[Option("run", HelpText = "Run the encryption immediately upon startup (don't require user to click Encrypt button)")]
			public bool Immediate { get; set; }

		}


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// Parse command line:
			CommandLine.Parser.Default.ParseArguments<Options>(args)
				.WithParsed(HandleParsed)
				.WithNotParsed(HandleParseError); 
		}

		static void HandleParsed(Options opts)
        // This function is called if the CommandLine.Parser succeeds in parsing all command line options.
        {
			Application.SetCompatibleTextRenderingDefault(false);

			// Create the UI form instance
			var form = new frmMain();
											
			// If input filename was specified, set it in the main form
			if (opts.InputFile != null)
            {
				form.txtInputFile.Text = opts.InputFile;
            }

			// If output filename was specified, set it in the main form
			if (opts.OutputFile != null)
            {
				form.txtOutputFile.Text = opts.OutputFile;
            }

			// If user password was specified, set it in the main form
			if (opts.UserPass != null)
            {
				form.txtPassword.Text = opts.UserPass;
            }

			// If owner password was specified, set it in the main form and show message.
			if (opts.OwnerPass != null)
            {
				form.owner_password = opts.OwnerPass;
				form.lblOwnerPasswordSet.Visible = true;
            }

			// If executing immediately, set the Run flag.
			form.encrypt_on_start = (opts.Immediate);

			Application.EnableVisualStyles();
			Application.Run(form);
		}

		static void HandleParseError(IEnumerable<Error> errors)
		// This function is called if the CommandLine.Parser fails to parse some command line options
		// It should output error messages to CLI and/or desktop.
		{
			Console.WriteLine("Invalid command line options: " + errors.ToString());
			MessageBox.Show("Invalid command line options: " + errors.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
