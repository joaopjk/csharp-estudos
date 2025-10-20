using OpenAI;
using OpenAI.Chat;

namespace ErudioAI.Services;

public class ChatService(
    OpenAIClient openAiClient)
{
    private readonly string _model = Environment.GetEnvironmentVariable("CHAT_MODEL") ?? "gpt-4o";

    public async Task<string> GetResponse(string prompt)
    {
        var chatClient = openAiClient.GetChatClient(_model);
        var response = await chatClient.CompleteChatAsync(prompt);

        return response.Value.Content[^1].Text ?? "No response for AI";
    }

    public async Task<string> GetResponseWithOptions(string prompt)
    {
        var chatClient = openAiClient.GetChatClient(_model);
        var messages = new List<ChatMessage>
        {
            new UserChatMessage(prompt)
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