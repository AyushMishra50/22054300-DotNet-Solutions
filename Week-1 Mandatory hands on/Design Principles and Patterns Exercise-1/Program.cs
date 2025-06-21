using System;
namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger l1 = Logger.GetInstance();
            l1.Log("logger1.");
            Logger l2 = Logger.GetInstance();
            l2.Log("logger2.");
            if (ReferenceEquals(l1,l2))
                Console.WriteLine("logger1 and logger2 are the same instance.");
            else
                Console.WriteLine("logger1 and logger2 are different instances.");
        }
    }
}
