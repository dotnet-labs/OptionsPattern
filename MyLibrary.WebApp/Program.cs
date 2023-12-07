using MyLibrary;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddLogging(c => c.AddConsole());
builder.Services.AddMyService(options =>
{
    options.Option1 = "100 push-ups";
    options.Option2 = true;
});

var app = builder.Build();

app.MapGet("/", async (HttpContext context, IMyService service) =>
{
    service.DoWork();
    await context.Response.WriteAsync("Hello World!");
});

app.Run();
