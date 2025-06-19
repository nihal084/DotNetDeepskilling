namespace DocumentFactoryDemo
{
    public class WordDocCreator : DocumentCreator
    {
        public override IDocument MakeDocument() => new WordDoc();
    }
}
