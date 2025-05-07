using MediatR;
using Teachy.Application;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Configuration.Sources.Clear();
builder.Configuration
    .AddJsonFile("Configs/appsettings.json", false, true);
    
builder.Services
    .AddApplicationLayer()
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(x => { x.RouteTemplate = "swagger/{documentName}/swagger.json"; });
    app.UseSwaggerUI();
}

app.MapPost("/saveStudent", (SaveStudentCommand command, ISender sender, CancellationToken ct) => sender.Send(command, ct));
app.MapGet("/students", () => { return 100; });

app.Run();