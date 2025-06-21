using System;

namespace FactoryMethodPatternExample
{
    public class ExcelDoc : IDoc
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }
}
