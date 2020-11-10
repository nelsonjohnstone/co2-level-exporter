using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace co2_level_exporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Co2Sensor.StartObserving();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
