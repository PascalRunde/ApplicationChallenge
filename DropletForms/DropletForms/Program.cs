using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DropletForms.DBCommunication;
using DropletForms.Forms;
using DropletForms.RatingCalculation;
using System.Configuration;
using System.Data.SQLite;

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

        /// <summary>
        /// Get the configuration string which is defined in DropletForms/App.config
        /// </summary>
        /// <param name="id"> This parameter is optional. If there should be additional databases in the future it would be possible to choose which to load.</param>
        /// <returns></returns>
        private static string LoadConnectionString(string id = "DBconnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<DropletMain>();
                    services.AddTransient<AddImageForm>();
                    services.AddTransient<WinnerForm>();
                    services.AddSingleton<AddImageFormFactory>(() => ServiceProvider.GetRequiredService<AddImageForm>());
                    services.AddSingleton<WinnerFormFactory>(() => ServiceProvider.GetRequiredService<WinnerForm>());
                    services.AddSingleton<IDatabaseCommunicationService, DatabaseCommunicationService>(service => new DatabaseCommunicationService(LoadConnectionString()));
                    services.AddSingleton<IRatingCalculator, RatingCalculator>();
                });
        }

    }
}