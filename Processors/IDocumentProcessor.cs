namespace DocumentProcessor.Processors
{
    public interface IDocumentProcessor
    {
        string DocumentVersion { get; }
        string GetResult();
        bool Execute(IFormFile file, string documentVersion);
    }
}
