using ErudioAI.Extensions;
using ErudioAI.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.AddOpenAiExtensions();

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSingleton<ChatService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseAuthorization();

app.MapControllers();

app.Run();