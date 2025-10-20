using ErudioAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErudioAI.Controllers;

[ApiController]
public class GenerativeAiController(ChatService service) : ControllerBase
{
    [HttpGet("ask-ai")]
    public async Task<IActionResult> AskAi([FromQuery] string prompt)
    {
        if (string.IsNullOrEmpty(prompt))
            return BadRequest("Prompt cannot be empty");

        return Ok(await service.GetResponse(prompt));
    }
    
    [HttpGet("ask-ai-options")]
    public async Task<IActionResult> AskAiWithOptions([FromQuery] string prompt)
    {
        if (string.IsNullOrEmpty(prompt))
            return BadRequest("Prompt cannot be empty");

        return Ok(await service.GetResponseWithOptions(prompt));
    }
}