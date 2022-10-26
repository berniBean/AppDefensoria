
using Clases.Repository;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Clases.Tablas.Persona;

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


            IServiceProvider _serviceProvider = BuildServiceProvider();

            
            ApplicationConfiguration.Initialize();

            var form1 = _serviceProvider.GetRequiredService<Inicio>();
            Application.Run(form1);
        }

        static IServiceProvider BuildServiceProvider()
        {
            IServiceCollection collection = new ServiceCollection();
            
            #region Agregar las ventanas de WindowsForms
            collection.AddTransient<Citas>();
            collection.AddTransient<DatosPersona>();
            collection.AddTransient<Informes>();
            collection.AddTransient<Inicio>();
            collection.AddTransient<Peticionario>();
            collection.AddTransient<Usuario>();
            
            

            #endregion

            #region UnitOfWork
            collection.AddScoped<IUnitOfWork,UnitOfWork>();
            #endregion

            #region MApper MeditR
            collection.AddMediatR(typeof(Consulta.Handler).Assembly);
            collection.AddMediatR(typeof(Clases.Tablas.Peticionario.Consulta.Handler).Assembly);
            collection.AddAutoMapper(typeof(Clases.Tablas.Peticionario.ListConsulta.Handler).Assembly);
            #endregion

            #region Configuracion de connexion JSON
            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json", optional: false)
            .Build();

            //IConfig config = configuration.Get<Config>();
            //collection.AddSingleton<IConfig>(config);
            #endregion


            #region Connexion  con bases de DAtos mysql 
            collection.AddOptions();

           

            collection.AddDbContext<ednita_dbContext>(opt =>
            {
                opt.UseMySQL(configuration.GetConnectionString("SefiplanConnection"))
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }
                    , Microsoft.Extensions.Logging.LogLevel.Information);


            });

            #endregion
            return collection.BuildServiceProvider();
        }
    }


}