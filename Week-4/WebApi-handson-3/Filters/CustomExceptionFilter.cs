using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace MyFirstWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            string logPath = Path.Combine("Logs", "exceptions.txt");
            Directory.CreateDirectory("Logs");
            File.AppendAllText(logPath, $"[{DateTime.Now}] {exception.Message}{System.Environment.NewLine}");

            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
