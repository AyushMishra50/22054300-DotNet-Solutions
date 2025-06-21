using System;

namespace FactoryMethodPatternExample
{
    public class PdfDoc : IDoc
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }
}
