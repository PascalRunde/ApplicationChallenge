using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Data.SQLite;
using DropletForms.DBCommunication;

namespace DropletForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new DropletMain());
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<DropletMain>());
        }
        
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<DropletMain>();
                    services.AddTransient<AddImageForm>();
                    services.AddSingleton<AddImageFormFactory>(() => ServiceProvider.GetRequiredService<AddImageForm>());
                    services.AddTransient<IDatabaseCommunicationService, DatabaseCommunicationService>();
                });
        }

    }
}