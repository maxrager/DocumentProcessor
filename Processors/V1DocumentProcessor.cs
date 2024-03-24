namespace DocumentProcessor.Processors
{
    public class V1DocumentProcessor : DocumentProcessorBase
    {
        public override string DocumentVersion => "Version1";
        protected override void Processor()
        {
            Result = $"{DocumentVersion} result";
        }
    }
}
