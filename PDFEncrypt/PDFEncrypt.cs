using iText.Kernel.Pdf;
using System.Text;

namespace Codeuctivity
{
    public class PDFEncrypt
    {
        public void EncryptPdf(string inputFilePath, string password, string outputFilePath, string ownderPassword, int encryption_properties, int document_options)
        {
            // Create a PdfReader with the input file.
            PdfReader reader = new PdfReader(inputFilePath);
            // Set properties of output
            WriterProperties prop = new WriterProperties();

            // Enable encryption
            // Setting Owner Password to null generates random password.
            prop.SetStandardEncryption(Encoding.ASCII.GetBytes(password), string.IsNullOrEmpty(ownderPassword) ? null : Encoding.ASCII.GetBytes(ownderPassword), document_options, encryption_properties);

            // Set up the output file
            PdfWriter writer = new PdfWriter(outputFilePath, prop);
            // Create the new document
            PdfDocument pdf = new PdfDocument(reader, writer);
            // Close the output document.
            pdf.Close();
        }
    }
}