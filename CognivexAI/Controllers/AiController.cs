using CognivexAI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CognivexAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AiController : ControllerBase
    {
        private readonly IGeminiService _geminiService;

        public AiController(
            IGeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpGet]
        public async Task<IActionResult> TestAI()
        {
            var response =
                await _geminiService.GenerateResponseAsync(
                    "Explain autonomous AI agents in simple words.");

            return Ok(response);
        }
    }
}