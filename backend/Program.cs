var builder = WebApplication.CreateBuilder(args);

var startup = new backend.Startup();
startup.ConfigureServices(builder.Services);

var app = builder.Build();
startup.Configure(app, app.Environment);

app.Run();