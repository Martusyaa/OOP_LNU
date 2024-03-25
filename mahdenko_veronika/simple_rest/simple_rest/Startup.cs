using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Rest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) //Цей метод викликається при запуску додатка і використовується для налаштування різних сервісів, які будуть доступні в додатку.
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//Цей метод викликається при запуску додатка і використовується для налаштування конвеєра обробки запитів.
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
