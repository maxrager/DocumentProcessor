using DocumentProcessor.Processors;

namespace DocumentProcessor.Services
{
    public class DocumentProcessorService(IEnumerable<IDocumentProcessor> documentProcessors)
    {
        private readonly IEnumerable<IDocumentProcessor> _documentProcessors = documentProcessors;

        public string Execute(IFormFile file, string documentVersion)
        {
            foreach (IDocumentProcessor processor in _documentProcessors)
            {
                if (processor.Execute(file, documentVersion))
                { 
                    return processor.GetResult();
                }
            }

            return "Invalid document version";
        }
    }
}