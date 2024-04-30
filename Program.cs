
var builder = WebApplication.CreateBuilder(args);
var movieApiKey = builder.Configuration["Movies:ServiceApiKey"];

var app = builder.Build();

app.MapGet("/", () => movieApiKey);

app.Run();
