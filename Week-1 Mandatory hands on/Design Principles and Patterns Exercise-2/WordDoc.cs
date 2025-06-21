using System;

namespace FactoryMethodPatternExample
{
    public class WordDoc : IDoc
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document...");
        }
    }
}
