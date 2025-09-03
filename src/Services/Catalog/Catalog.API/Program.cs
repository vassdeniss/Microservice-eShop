WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

WebApplication app = builder.Build();

app.MapCarter();

app.Run();
