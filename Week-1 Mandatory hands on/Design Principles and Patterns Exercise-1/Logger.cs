using System;
namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger? i;
        private static readonly object _lock = new object();
        private Logger()
        {
            Console.WriteLine("Logger Initialized.");
        }
        public static Logger GetInstance()
        {
            if (i== null)
            {
                lock (_lock)
                {
                    if (i == null)
                    {
                        i = new Logger();
                    }
                }
            }
            return i;
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
