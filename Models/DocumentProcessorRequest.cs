namespace DocumentProcessor.Models
{
    public class DocumentProcessorRequest
    {
        public required string DocumentVersion { get; set; }

        public required IFormFile File { get; set; }
    }
}
