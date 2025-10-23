using OpenAI;
using OpenAI.Audio;

namespace ErudioAI.Services;

public class AudioService(OpenAIClient openAiClient)
{
    private readonly string _model = Environment.GetEnvironmentVariable("AUDIO_MODEL") ?? "whisper-1";

    public async Task<string> TranscribeAudioAsync(IFormFile file)
    {
        var tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid().ToString()}.mp3");

        try
        {
            var stream = new FileStream(tempFilePath, FileMode.Create);
            await file.CopyToAsync(stream);
            stream.Close();

            var options = new AudioTranscriptionOptions
            {
                ResponseFormat = AudioTranscriptionFormat.Text,
                Language = "pt",
                Temperature = 0.0f
            };
            
            var audioClient = openAiClient.GetAudioClient(_model);
            
            var response = await audioClient.TranscribeAudioAsync(tempFilePath, options);
            
            return response.Value.Text ?? "No response for AI";

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            File.Delete(tempFilePath);
        }
    }
}