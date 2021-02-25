using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagement.Core;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System;
using System.Windows.Forms;
using OrderManagement.View;
using OrderManagement.Data.Migrations;

namespace OrderManagement
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new StartView());

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) => {
                    services.AddScoped<StartView>();

                    services = Extensions.AddCoreLogic(services);

                    var provider = services.BuildServiceProvider();
                    var mainForm = provider.GetRequiredService<StartView>();
                    Application.Run(mainForm);
                });

            builder.Build();
        }
    }
}
