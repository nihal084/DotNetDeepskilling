using System;
namespace DocumentFactoryDemo
{
    public class PdfDoc : IDocument
    {
        public void Open() => Console.WriteLine("PDF document is now open.");
    }
}
