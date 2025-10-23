using ErudioAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErudioAI.Controllers;

[ApiController]
public class GenerativeAiController(
    ChatService chatService,
    RecipeService recipeService,
    ImageService imageService,
    AudioService audioService) : ControllerBase
{
    [HttpGet("ask-ai")]
    public async Task<IActionResult> AskAi([FromQuery] string prompt)
    {
        if (string.IsNullOrEmpty(prompt))
            return BadRequest("Prompt cannot be empty");

        return Ok(await chatService.GetResponse(prompt));
    }

    [HttpGet("ask-ai-options")]
    public async Task<IActionResult> AskAiWithOptions([FromQuery] string prompt)
    {
        if (string.IsNullOrEmpty(prompt))
            return BadRequest("Prompt cannot be empty");

        return Ok(await chatService.GetResponseWithOptions(prompt));
    }

    [HttpGet("recipe-creator")]
    public async Task<IActionResult> GenerateRecipe(
        [FromQuery] string ingredients,
        [FromQuery] string cuisine = "any",
        [FromQuery] string dietRestrictions = "none")
    {
        if (string.IsNullOrEmpty(ingredients))
            return BadRequest("Ingredients cannot be empty");

        return Ok(await recipeService.GetRecipe(ingredients, cuisine, dietRestrictions));
    }

    [HttpGet("image-creator")]
    public async Task<IActionResult> GenerateImage(
        [FromQuery] string prompt,
        [FromQuery] string quality,
        [FromQuery] int numberOfImages,
        [FromQuery] int height,
        [FromQuery] int width)
    {
        if (string.IsNullOrEmpty(prompt))
            return BadRequest("prompt cannot be empty");

        return Ok(await imageService.GenerateImage(prompt, quality, numberOfImages, height, width));
    }

    [HttpPost("audio-transcription")]
    public async Task<IActionResult> GenerateTranscribeAudio(
        IFormFile? formFile)
    {
        if (formFile == null)
            return BadRequest("prompt cannot be empty");

        return Ok(await audioService.TranscribeAudioAsync(formFile));
    }
}