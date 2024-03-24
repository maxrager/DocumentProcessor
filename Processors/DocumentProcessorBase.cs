
namespace DocumentProcessor.Processors
{
    public abstract class DocumentProcessorBase : IDocumentProcessor
    {
        public virtual string DocumentVersion => string.Empty;
        protected string Result = string.Empty;

        public bool Execute(IFormFile file, string documentVersion)
        {
            if (DocumentVersion != documentVersion)
            {
                return false;
            }

            Processor();

            return true;
        }

        protected abstract void Processor();

        public string GetResult()
        {
            return Result;
        }
    }
}
