using Codeuctivity;

namespace PDFEncryptLibTests
{
    public class PDFEncryptIntegrationtests
    {
        private const string OutputFilePath = "encrypted.pdf";

        [Fact]
        public async void PdfaValidatorShouldDetectEncryption()
        {
            if (File.Exists(OutputFilePath))
            {
                File.Delete(OutputFilePath);
            }

            var pdfEncrypt = new PDFEncrypt();
            pdfEncrypt.EncryptPdf("../../../TestInput/Input.pdf", "Pasword123", OutputFilePath, null, 0, 0);

            Assert.True(File.Exists(OutputFilePath));

            using var pdfaValidator = new PdfAValidator();
            var result = await pdfaValidator.ValidateWithDetailedReportAsync(OutputFilePath);

            var taskResult = result.Jobs.Job.TaskResult;
            Assert.True(taskResult.IsExecuted);
            Assert.False(taskResult.IsSuccess);
            Assert.Equal("PARSE", taskResult.Type);
            Assert.Contains("appears to be encrypted", taskResult.ExceptionMessage);
        }
    }
}