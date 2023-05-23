using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using System.Text;

namespace Codeuctivity
{
    public class PDFEncrypt
    {
        public void EncryptPdf(string inputFilePath, string password, string outputFilePath, string ownerPassword, int encryption_properties, int document_options)
        {
            // Create a PdfReader with the input file.
            var reader = new PdfReader(inputFilePath);
            // Set properties of output
            var prop = new WriterProperties();

            // Enable encryption
            // Setting Owner Password to null generates random password.
            byte[] userPassword = null;

            if (!string.IsNullOrEmpty(password))
            {
                userPassword = Encoding.ASCII.GetBytes(password);
            }

            prop.SetStandardEncryption(userPassword, string.IsNullOrEmpty(ownerPassword) ? null : Encoding.ASCII.GetBytes(ownerPassword), document_options, encryption_properties);

            // Set up the output file
            var writer = new PdfWriter(outputFilePath, prop);
            // Create the new document
            var pdf = new PdfDocument(reader, writer);
            // Close the output document.
            pdf.Close();
        }

        public bool TryDecryptPdf(string inputFilePath, string userPassword, string outputFilePath)
        {
            try
            {
                using var document = new PdfDocument(new PdfReader(inputFilePath, new ReaderProperties().SetPassword(Encoding.UTF8.GetBytes(userPassword))).SetUnethicalReading(true), new PdfWriter(outputFilePath));
            }
            catch (BadPasswordException)
            {
                return false;
            }
            return true;
        }
    }
}