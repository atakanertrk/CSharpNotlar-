using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;
using System.Runtime.InteropServices;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//     Amaç asp.net core'daki dependancj injection özelliklerini console app içerisinde kullanarak daha iyi bir console uygulaması geliştirmek.

//     Bu programda uygulanacaklar/uygulananlar : Dependency Injection - Logging with Serilog - Settings (appsettings.json) 

//                        **Dependencies/NuGets**
//           Serilog.Exstensions.Hosting = .net core için logging ve hosting services desteği
//           Serilog.Settings.Configuration = appsettings.json support with serilog
//           Microsoft.Extensions.Hosting = uygulamalar için .net core hosting ve startup altyapısı
//           Serilog.Sinks.Console = Log eventlerini terminal'e yazar

//     Not: appsettings.json dosyasında properties-> "Coppy To Output Directory : Copy Always" build/debug yaptığımız zamanlarda bu dosyaya erişebilmemiz için.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace DependencyInjectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // builder is instance so we pass refrence type, not variable. So we have load the builder via BuildConfig()
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            // logger can now read the configuration from the appsettings.json
            // now that allows us to set up all our configuration for serilog in appsettings.json
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("Application Starting");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // transient mean, creates new instance everytime when application ask for it
                    services.AddTransient<IGreetingService, GreetingService>();
                })
                .UseSerilog()
                .Build();

            var svc = ActivatorUtilities.CreateInstance<GreetingService>(host.Services);
            svc.Run(); // method in GreetingService

        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            // this is the connection with our appsettings.json file...
            // what this code means is : 
            // + whereever this .exe file (project) running, get that directory (look at same directory) and look for
            // + appsettings.json file and add that as project's settings file
            // + And if appsettings.json file changes, than reload it.
            builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            // appsettings.development.json / appsettings.production.json
            // if cannot find environment than default is Production
            // optional:true means if this file is not exist no problem it is optional
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            // This code for being able to override appsettings.json
            .AddEnvironmentVariables();
        }
    }
}
