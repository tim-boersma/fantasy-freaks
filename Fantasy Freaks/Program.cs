using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks {

    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<FFWindow>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Configuration { get; set; }

        static IHostBuilder CreateHostBuilder()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory().Replace("\\bin\\Debug", ""))
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    var test = Configuration.GetConnectionString("DefaultConnection");
                    services.AddDbContext<ContributerDataContext>(options => options.UseSqlServer(test));
                    services.AddTransient<IContributerService, ContributerService>();
                    services.AddTransient<FFWindow>();
                    services.AddTransient<FormHomeScreen>();
                });
        }
    }
}
