using OpenAI;
using OpenAI.Chat;

namespace ErudioAI.Services;

public class RecipeService(OpenAIClient openAiClient)
{
    private readonly string _model = Environment.GetEnvironmentVariable("CHAT_MODEL") ?? "gpt-4o";

    public async Task<string> GetRecipe(
        string ingredients,
        string cuisine,
        string dietRestrictions)
    {
        var chatClient = openAiClient.GetChatClient(_model);

        const string systemMessage = "You are a professional chef that provides creative and easy-to-follow recipes";

        var userMessage = $"I want to create a recipe using following ingredients: {ingredients}." +
                          $"The cuisine type i prefer is: {cuisine}." +
                          $"Please consider these dietary restrictions: {dietRestrictions}.";

        var messages = new List<ChatMessage>
        {
            systemMessage,
            userMessage
        };

        var options = new ChatCompletionOptions
        {
            Temperature = 0.4f,
            MaxOutputTokenCount = 200
        };

        var response = await chatClient.CompleteChatAsync(messages, options);

        return response.Value.Content[^1].Text ?? "No response for AI";
    }
}