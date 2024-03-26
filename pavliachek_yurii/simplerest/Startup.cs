using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace simplerest
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
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, world!");
        }

        [HttpPost("body")]
        public IActionResult Post([FromBody] string name)
        {
            string message = $"Hello, {name}!";
            return Ok(message);
        }
        [HttpPost("headers")]
        public IActionResult Header()
        {
            string name = null;

            if (Request.Headers.TryGetValue("Name", out var headerValues))
            {
                name = headerValues.FirstOrDefault();
            }
            string newname;
            if (name != null)
            {
                newname = name;
            }
            else
            {
                newname = "Yurii";
            }
            return Ok($"Hello, {newname}");
            
        }
        [HttpPost("parameter")]
        public IActionResult PostParams([FromQuery] string name)
        {
            var messageObject = new { Message = $"Hello, {name}" };
            return new JsonResult(messageObject);
        }
    }
}
