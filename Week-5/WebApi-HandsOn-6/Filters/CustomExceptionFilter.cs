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

            // Log the exception to a text file
            string logPath = Path.Combine("Logs", "exceptions.txt");
            Directory.CreateDirectory("Logs");
            File.AppendAllText(logPath, $"[{DateTime.Now}] {exception.Message}{Environment.NewLine}");

            // Return generic error response
            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
