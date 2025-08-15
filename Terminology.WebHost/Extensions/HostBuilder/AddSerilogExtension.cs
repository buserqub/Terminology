/* Необходимые пакеты:
 *      Serilog
 *      Serilog.AspNetCore
 *      Serilog.Settings.Configuration
 *      Serilog.Sinks.Console
 *      Serilog.Sinks.File
 */

using Serilog;

namespace Terminology.WebHost.Extensions.HostBuilder
{
    internal static class AddSerilogExtension
    {
        /// <summary>
        /// Зарегистрировать Serilog
        /// </summary>
        public static IHostBuilder AddSerilog(this IHostBuilder hostBuilder)
        {
            var serilogConfiguration = new ConfigurationBuilder()
                                   .SetBasePath(Directory.GetCurrentDirectory())
                                   .AddJsonFile("serilog.json")
                                   .Build();

            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(serilogConfiguration).CreateLogger();

            hostBuilder.UseSerilog();

            return hostBuilder;
        }
    }
}
