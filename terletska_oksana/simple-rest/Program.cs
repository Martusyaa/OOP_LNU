using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SimpleRestApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

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

    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World!";
        }

        [HttpPost("body")]
        public IActionResult PostByBody([FromBody] HelloData data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Name))
            {
                return Ok($"Hello, {data.Name}!");
            }
            else
            {
                return BadRequest("Name not provided in request body.");
            }
        }

        [HttpPost("headers")]
        public IActionResult PostByHeaders()
        {
            var name = Request.Headers["Name"].ToString();
            if (!string.IsNullOrEmpty(name))
            {
                return Ok($"Hello, {name}!");
            }
            else
            {
                return BadRequest("Name not provided in request headers.");
            }
        }


        [HttpPost("params")]
        public IActionResult PostByParams([FromQuery] string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return Ok($"Hello, {name}!");
            }
            else
            {
                return BadRequest("Name not provided in request parameters.");
            }
        }
    }

    public class HelloData
    {
        public string Name { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
