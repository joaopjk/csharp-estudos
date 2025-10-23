using ErudioAI.Extensions;
using ErudioAI.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddOpenAiExtensions();
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSingleton<ChatService>();
builder.Services.AddSingleton<RecipeService>();
builder.Services.AddSingleton<ImageService>();
builder.Services.AddCors(opt => opt.AddDefaultPolicy(
    corsPolicyBuilder => corsPolicyBuilder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()
    ));

var app = builder.Build();

app.UseCors();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseAuthorization();

app.MapControllers();

app.Run();