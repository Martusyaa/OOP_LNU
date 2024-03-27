using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rest
{
    [ApiController]
    [Route("[controller]")]
    public class helloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var messageObject = new { Message = "Hello, World!" };

            return new JsonResult(messageObject);
        }

        [HttpPost("body")]
        public async Task<ActionResult<object>> PostFromBody()
        {
            using (StreamReader reader = new StreamReader(Request.Body))
            {
                string requestBody = await reader.ReadToEndAsync();
                dynamic bodyData = JsonConvert.DeserializeObject(requestBody);
                string nameFromBody = bodyData?.name;
                var response = new { Message = $"Hello, {nameFromBody ?? "Anonymous"}!" };
                return Ok(response);
            }
        }

        [HttpPost("header")]
        public ActionResult<object> PostFromHeader()
        {
            string nameFromHeader = null;

            if (Request.Headers.TryGetValue("Name", out var headerValues))
            {
                nameFromHeader = headerValues.FirstOrDefault();
            }

            string name = nameFromHeader ?? "Anonymous";
            var response = new { Message = $"Hello, {name}!" };
            return Ok(response);
        }

        [HttpPost("params")]
        public IActionResult PostFromParams([FromQuery] string name)
        {
            var messageObject = new { Message = $"Hello, {name ?? "Anonymous"}!" };
            return new JsonResult(messageObject);
        }
    }
}