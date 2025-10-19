using OpenAI;

namespace ErudioAI.Extensions;

public static class OpenAiExtensions
{
    public static WebApplicationBuilder AddOpenAiExtensions(this WebApplicationBuilder builder)
    {
        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY")!;
        var openAiClient = new OpenAIClient(apiKey);
        
        builder.Services.AddSingleton(openAiClient);

        return builder;
    }
}