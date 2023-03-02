using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;  // Registry access
using iText.Kernel.Pdf;

namespace PDFEncrypt
{
	class Settings
	{
		public enum EncryptionType
		{
			AES_256 = EncryptionConstants.ENCRYPTION_AES_256,
			AES_128 = EncryptionConstants.ENCRYPTION_AES_128,
			RC4_128 = EncryptionConstants.STANDARD_ENCRYPTION_128,
			RC4_40 = EncryptionConstants.STANDARD_ENCRYPTION_40
		}

		public static bool run_after;  // Run program after encrypting?
		public static string run_after_file;   // File to run after encrypting
		public static string run_after_arguments;	// Arguments to pass to the run_after file.
		public static bool password_confirm;   // Confirm password?
		public static bool close_after; // Close after encrypting?
		public static bool show_folder_after;   // Show folder in Explorer after encrypting?
		public static bool open_after;          // Open the destination file in its default program?

		// Encryption options:
		public static EncryptionType encryption_type;   // Type of encryption to use
		public static bool encrypt_metadata;    // Should metadata be encrypted?
		public static bool allow_printing;    // Should end user be allowed to print PDF?
		public static bool allow_degraded_printing;    // Should end user be allowed to print PDF degraded?
		public static bool allow_modifying;    // Should end user be allowed to modify the PDF?
		public static bool allow_modifying_annotations;    // Should end user be allowed to modify annotations?
		public static bool allow_copying;    // Should end user be allowed to copy from PDF?
		public static bool allow_form_fill;    // Should end user be allowed to fill in form fields?
		public static bool allow_assembly;    // Should end user be allowed to assemble the document?
		public static bool allow_screenreaders;    // Should screenreaders be allowed to access the document?

		// Events to execute upon setting changes
		public delegate void SettingChangedNotification();
		public static List<SettingChangedNotification> notify = new List<SettingChangedNotification>();	// Add delegate functions to this list to be notified.

		// Constants:
		const string REG_KEY = "HKEY_CURRENT_USER\\Software\\PDFEncrypt\\";	// Main registry key

		public static void load()
		{
			// Read settings from registry.
			object x;

			// Run program after encryption?
			x = Registry.GetValue(REG_KEY, "run_after", 0);
			if (x == null) { x = 0; }
			run_after = (int)x == 1;	// Convert to boolean.
			
			// Program to run:
			x = Registry.GetValue(REG_KEY, "run_after_file", null);
			if (x == null) { x = ""; }
			run_after_file = (string)x;

			// Run After arguments
			x = Registry.GetValue(REG_KEY, "run_after_arguments", null);
			if (x == null) { x = ""; }
			run_after_arguments = (string)x;

			// Require password confirmation
			x = Registry.GetValue(REG_KEY, "password_confirm", 0);
			if (x == null) { x = 0; }
			password_confirm = (int)x == 1;

			// Close after encrypting
			x = Registry.GetValue(REG_KEY, "close_after", 0);
			if (x == null) { x = 0; }
			close_after = (int)x == 1;

			

			// Show folder after encrypting
			x = Registry.GetValue(REG_KEY, "show_folder_after", 0);
			if (x == null) { x = 0; }
			show_folder_after = (int)x == 1;

			// Open file after encrypting
			x = Registry.GetValue(REG_KEY, "open_after", 0);
			if (x == null) { x = 0; }
			open_after = (int)x == 1;


			// Encryption options:
			// Encryption type:
			x = Registry.GetValue(REG_KEY, "encryption_type", 0);
			if (x == null) { x = (int)EncryptionType.AES_256; }
			if (!Enum.IsDefined(typeof(EncryptionType), (int)x))    // If not a valid option, use default:
			{
				encryption_type = EncryptionType.AES_256;   // Default to AES_256
			}
			else
			{
				encryption_type = (EncryptionType)x;
			}

			// Encrypt metadata
			x = Registry.GetValue(REG_KEY, "encrypt_metadata", 0);
			if (x == null) { x = 0; }
			encrypt_metadata = (int)x == 1;
			
			// Allow printing
			x = Registry.GetValue(REG_KEY, "allow_printing", 0);
			if (x == null) { x = 0; }
			allow_printing = (int)x == 1;

			// Allow degraded printing
			x = Registry.GetValue(REG_KEY, "allow_degraded_printing", 0);
			if (x == null) { x = 0; }
			allow_degraded_printing = (int)x == 1;

			// Allow modifying
			x = Registry.GetValue(REG_KEY, "allow_modifying", 0);
			if (x == null) { x = 0; }
			allow_modifying = (int)x == 1;

			// Allow modifying notations
			x = Registry.GetValue(REG_KEY, "allow_modifying_annotations", 0);
			if (x == null) { x = 0; }
			allow_modifying_annotations = (int)x == 1;

			// Allow copying
			x = Registry.GetValue(REG_KEY, "allow_copying", 0);
			if (x == null) { x = 0; }
			allow_copying = (int)x == 1;

			// Allow form fill
			x = Registry.GetValue(REG_KEY, "allow_form_fill", 0);
			if (x == null) { x = 0; }
			allow_form_fill = (int)x == 1;

			// Allow assembly
			x = Registry.GetValue(REG_KEY, "allow_assembly", 0);
			if (x == null) { x = 0; }
			allow_assembly = (int)x == 1;

			// Allow screenreaders
			x = Registry.GetValue(REG_KEY, "allow_screenreaders", 0);
			if (x == null) { x = 0; }
			allow_screenreaders = (int)x == 1;

			// Notify all listeners of updates.
			callNotify();
		}

		public static void callNotify()
		// Notify all listeners of updates.
		{
			// Notify each listener of the updates.
			foreach (SettingChangedNotification s in notify)
			{
				s();	// Call the function.
			}
		}


		public static void save()
		// Write all settings to registry
		{
			Registry.SetValue(REG_KEY, "run_after", (object)run_after, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "run_after_file", (object)run_after_file, RegistryValueKind.String);
			Registry.SetValue(REG_KEY, "run_after_arguments", (object)run_after_arguments, RegistryValueKind.String);

			Registry.SetValue(REG_KEY, "password_confirm", (object)password_confirm, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "close_after", (object)close_after, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "show_folder_after", (object)show_folder_after, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "open_after", (object)open_after, RegistryValueKind.DWord);

			// Encryption options:
			Registry.SetValue(REG_KEY, "encryption_type", (object)encryption_type, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "encrypt_metadata", (object)encrypt_metadata, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_printing", (object)allow_printing, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_degraded_printing", (object)allow_degraded_printing, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_modifying", (object)allow_modifying, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_modifying_annotations", (object)allow_modifying_annotations, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_copying", (object)allow_copying, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_form_fill", (object)allow_form_fill, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_assembly", (object)allow_assembly, RegistryValueKind.DWord);
			Registry.SetValue(REG_KEY, "allow_screenreaders", (object)allow_screenreaders, RegistryValueKind.DWord);

			// Notify all listeners
			callNotify();
		}
	}
}
