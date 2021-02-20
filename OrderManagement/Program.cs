using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagement.Core;
using OrderManagement.Data.Model;
using OrderManagment.View;
using Smartive.Core.Database.Repositories;
using System;
using System.Windows.Forms;

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
            //Application.Run(new Form1());

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) => {
                    services.AddScoped<OrderManagement>();

                    services = Extensions.AddCoreLogic(services);

                    var provider = services.BuildServiceProvider();
                    var mainForm = provider.GetRequiredService<StartView>();
                    Application.Run(mainForm);
                });

            builder.Build();
        }
    }
}
