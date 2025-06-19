using System;
using DocumentFactoryDemo;

namespace DocumentFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentCreator wordFactory = new WordDocCreator();
            DocumentCreator pdfFactory = new PdfDocCreator();
            DocumentCreator excelFactory = new ExcelDocCreator();

            IDocument word = wordFactory.MakeDocument();
            IDocument pdf = pdfFactory.MakeDocument();
            IDocument excel = excelFactory.MakeDocument();

            word.Open();
            pdf.Open();
            excel.Open();
        }
    }
}
