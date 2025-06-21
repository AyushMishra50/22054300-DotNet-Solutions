using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            IDoc wordD = wordFactory.CreateDocument();
            wordD.Open();

            DocumentFactory pdfFactory = new PdfFactory();
            IDoc pdfD = pdfFactory.CreateDocument();
            pdfD.Open();

            DocumentFactory excelFactory = new ExcelFactory();
            IDoc excelD = excelFactory.CreateDocument();
            excelD.Open();
        }
    }
}
