var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from .NET");
app.MapGet("/health", () => "UP");

app.Run();

// Makes the entry point visible to WebApplicationFactory in the test project.
public partial class Program;
