namespace DocumentFactoryDemo
{
    public class PdfDocCreator : DocumentCreator
    {
        public override IDocument MakeDocument() => new PdfDoc();
    }
}
