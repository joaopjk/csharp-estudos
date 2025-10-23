using ErudioAI.Extensions;
using ErudioAI.Services;
using Microsoft.OpenApi;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddOpenAiExtensions();
builder.Services.AddControllers();
builder.Services.AddOpenApi(opt =>
{
    opt.AddDocumentTransformer((document, context, _) =>
    {
        document.Info = new OpenApiInfo
        {
            Title = "Erudio AI",
            Version = "v1",
            Description = "API to generate recipes and images",
            Contact = new OpenApiContact
            {
                Name = "Pjk",
                Email = "pjk@email.com",
                Url = new Uri("https://github.com/joaopjk")
            },
            License = new OpenApiLicense
            {
                Name = "Apache 2.0",
                Url = new Uri("https://github.com/joaopjk")
            },
            TermsOfService = new Uri("https://github.com/joaopjk")
        };
        return Task.CompletedTask;
    });
});
builder.Services.AddSingleton<ChatService>();
builder.Services.AddSingleton<RecipeService>();
builder.Services.AddSingleton<ImageService>();
builder.Services.AddCors(opt => opt.AddDefaultPolicy(corsPolicyBuilder => corsPolicyBuilder
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
));

var app = builder.Build();

app.UseCors();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(opt => {
        opt.Title = "Erudio AI";
        opt.Theme = ScalarTheme.Purple;
        opt.DefaultHttpClient = new KeyValuePair<ScalarTarget, ScalarClient>(ScalarTarget.Http, ScalarClient.Http11);
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();