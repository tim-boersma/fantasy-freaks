using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Services;
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

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

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
                    services.AddDbContext<FantasyDataContext>(options => options.UseSqlServer(test));
                    services.AddTransient<IDefenseService, DefenseService>();
                    services.AddTransient<IPreviousPlayerService, PreviousPlayerService>();
                    services.AddTransient<IPlayerPerformanceService, PlayerPerformanceService>();
                    services.AddSingleton<ITeamService, TeamService>();
                    services.AddSingleton<ICurrentPlayerService, CurrentPlayerService>();
                    services.AddTransient<FFWindow>();
                    services.AddTransient<FormHomeScreen>();
                });
        }
    }
}
