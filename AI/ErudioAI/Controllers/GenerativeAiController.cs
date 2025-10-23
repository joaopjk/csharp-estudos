using ErudioAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErudioAI.Controllers;

[ApiController]
public class GenerativeAiController(
    ChatService chatService,
    RecipeService recipeService) : ControllerBase
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
}