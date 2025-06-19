namespace DocumentFactoryDemo
{
    public class ExcelDocCreator : DocumentCreator
    {
        public override IDocument MakeDocument() => new ExcelDoc();
    }
}
