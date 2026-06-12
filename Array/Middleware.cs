

public class simpleMiddleware
{
    private readonly RequestDelegate _next;

    public simpleMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContent content)
    {
        Console.Write("Before Request");

        await _next(context);

        Console.Write("After Request");
    }

  
}


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<SimpleMiddleware>();

app.MapGet("/", () => "Hello World");

app.Run();


internal class RequestDelegate
{
}