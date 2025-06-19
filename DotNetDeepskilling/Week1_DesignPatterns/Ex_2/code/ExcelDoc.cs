using System;
namespace DocumentFactoryDemo
{
    public class ExcelDoc : IDocument
    {
        public void Open() => Console.WriteLine("Excel document is now open.");
    }
}
