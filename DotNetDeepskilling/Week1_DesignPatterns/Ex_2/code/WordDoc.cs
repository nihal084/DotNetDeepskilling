using System;
namespace DocumentFactoryDemo
{
    public class WordDoc : IDocument
    {
        public void Open() => Console.WriteLine("Word document is now open.");
    }
}
