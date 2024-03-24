namespace DocumentProcessor.Processors
{
    public class V2DocumentProcessor : DocumentProcessorBase
    {
        public override string DocumentVersion => "Version2";
        protected override void Processor()
        {
            Result = $"{DocumentVersion} result";
        }
    }
}
