using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PlanPoker
{
    /// <summary>
    /// Класс с методом Main.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Стартовый метод.
        /// </summary>
        /// <param name="args">Параметры запуска.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Создание хоста.
        /// </summary>
        /// <param name="args">Параметры.</param>
        /// <returns>Построенный хост.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
        }
}
