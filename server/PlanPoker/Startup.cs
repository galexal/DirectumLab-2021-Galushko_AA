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
    /// ��������� �����.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// �����������.
        /// </summary>
        /// <param name="configuration">������������.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// ������������.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// ������������ ��������.
        /// </summary>
        /// <param name="services">�������.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<UserService>();
            services.AddTransient<RoomService>();
            services.AddTransient<CardService>();
            services.AddTransient<DiscussionService>();
            services.AddSingleton<IRepository<User>, UserRepository>();
            services.AddSingleton<IRepository<Room>, RoomRepository>();
            services.AddSingleton<IRepository<Card>, CardRepository>();
            services.AddSingleton<IRepository<Discussion>, DiscussionRepository>();
        }

        /// <summary>
        /// ������������.
        /// </summary>
        /// <param name="app">����������.</param>
        /// <param name="env">���������.</param>
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
