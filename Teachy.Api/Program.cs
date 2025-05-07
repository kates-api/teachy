var builder = WebApplication.CreateSlimBuilder(args);

builder.Configuration.Sources.Clear();
builder.Configuration
    .AddJsonFile("Configs/appsettings.json", false, true);
    
builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(x => { x.RouteTemplate = "swagger/{documentName}/swagger.json"; });
    app.UseSwaggerUI();
}

app.MapGet("/testStudents", () => { return 100; });

app.Run();