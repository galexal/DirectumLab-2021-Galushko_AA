using DataService;
using DataService.Models;
using DataService.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlanPoker.Services;

namespace PlanPoker
{
    /// <summary>
    /// Настройка хоста.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="configuration">Конфигурация.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Конфигурация.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Конфигурация сервисов.
        /// </summary>
        /// <param name="services">Сервисы.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton<ExampleService>();
            services.AddTransient<RoomService>();
            services.AddTransient<DiscussionService>();
            services.AddTransient<UserService>();
            services.AddSingleton<IRepository<Room>, RoomRepository>();
            services.AddSingleton<IRepository<Card>, CardRepository>();
            services.AddSingleton<IRepository<Discussion>, DiscussionRepository>();
            services.AddSingleton<IRepository<Vote>, VoteRepository>();
            services.AddSingleton<IRepository<User>, UserRepository>();
        }

        /// <summary>
        /// Конфигурация.
        /// </summary>
        /// <param name="app">Приложение.</param>
        /// <param name="env">Окружение.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
