using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace SimpleRestApi
{
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("api/hello")]
        public IActionResult Get()
        {
            return Ok("Hello, world");
        }

        [HttpPost("body")]
        [Route("api/hello/body")]
        public async Task<ActionResult<object>> PostBody()
        {
            using (StreamReader reader = new StreamReader(Request.Body))
            {
                string requestBody = await reader.ReadToEndAsync();
                dynamic bodyData = JsonConvert.DeserializeObject(requestBody);
                string nameBody = bodyData?.name;
                var response = new { Message = $"Hello, {nameBody}" };
                return Ok(response);
            }
        }
        
        [HttpPost("header")]
        [Route("api/hello/header")]
        public ActionResult<object> PostHeader()
        {
            string nameFromHeader = null;
        
            if (Request.Headers.TryGetValue("Name", out var headerValues))
            {
                nameFromHeader = headerValues.FirstOrDefault();
            }
        
            string name = nameFromHeader ?? "Anonymous";
            var response = new { Message = $"Hello, {name}" };
            return Ok(response);
        }
        
        [HttpPost("params")]
        [Route("api/hello/params")]
        public IActionResult PostParams([FromQuery] string name)
        {
            var messageObject = new { Message = $"Hello, {name}" };
            return new JsonResult(messageObject);
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SimpleRestApi", Version = "v1" });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SimpleRestApi v1"));
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}

