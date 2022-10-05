using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace INVEDEP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static IServiceProvider BuildServiceProvider()
        {
            IServiceCollection collection = new ServiceCollection();
            
            #region Configuracion de connexion JSON
            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json", optional: false)
            .Build();

            IConfig config = configuration.Get<Config>();
            collection.AddSingleton<IConfig>(config);
            #endregion


            #region Connexion  con bases de DAtos mysql y Dapper
            collection.AddOptions();

            collection.Configure<ConexionConfiguracion>(configuration.GetSection("ConnectionStrings"));

            collection.AddDbContext<sim_verformsContext>(opt => {
                opt.UseMySQL(configuration.GetConnectionString("SefiplanConnection"))
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }
                    , Microsoft.Extensions.Logging.LogLevel.Information);


            });

            #endregion
            return collection.BuildServiceProvider();
        }
    }


}