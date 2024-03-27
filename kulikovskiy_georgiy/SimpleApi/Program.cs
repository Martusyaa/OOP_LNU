using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

var helloWorld = new { Message = "Hello World" };

app.MapGet("/getHello", () => helloWorld);

app.MapPost(
    "/postHelloBody",
    (JsonElement context) =>
    {
        try
        {
            var nameFromBody = context.GetProperty("Name").ToString();

            if (string.IsNullOrEmpty(nameFromBody))
            {
                return Results.Ok(new { Message = "Hello world" });
            }
            else
            {
                return Results.Ok(new { Message = $"Hello {nameFromBody}" });
            }
        }
        catch
        {
            return Results.Ok(new { Message = "Hello world" });
        }
    }
);

app.MapPost(
    "/postHelloHeader",
    (HttpContext context) =>
    {
        var nameFromHeaders = context.Request.Headers["Name"].ToString();

        if (string.IsNullOrEmpty(nameFromHeaders))
        {
            return Results.Ok(new { Message = "Hello world" });
        }
        else
        {
            return Results.Ok(new { Message = $"Hello {nameFromHeaders}" });
        }
    }
);

app.MapPost(
    "/postHelloParams",
    (HttpContext context) =>
    {
        var nameFromQuery = context.Request.Query["Name"];

        if (string.IsNullOrEmpty(nameFromQuery))
        {
            return Results.Ok(new { Message = "Hello world" });
        }
        else
        {
            return Results.Ok(new { Message = $"Hello {nameFromQuery}" });
        }
    }
);

app.Run();
