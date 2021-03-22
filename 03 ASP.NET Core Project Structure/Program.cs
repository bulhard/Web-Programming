using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

// using Microsoft.Extensions.Logging;

namespace _03_ASP.NET_Core_Project_Structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            //.ConfigureLogging(logBuilder =>
            //{
            //    logBuilder.ClearProviders(); // removes all providers from LoggerFactory
            //    logBuilder.AddConsole();
            //    logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
            //    logBuilder.AddEventLog();
            //})
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}