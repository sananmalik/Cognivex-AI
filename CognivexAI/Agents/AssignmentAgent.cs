using CognivexAI.Interfaces;
using System.Threading.Tasks;

namespace CognivexAI.Agents
{
    public class AssignmentAgent
    {
        private readonly IGeminiService _aiService;

        public AssignmentAgent(
            IGeminiService aiService)
        {
            _aiService = aiService;
        }

        public async Task<string> AnalyzeAssignment(
            string title,
            string description)
        {
            var prompt = $@"
You are an academic planning AI.

Analyze this assignment and generate:
1. Task breakdown
2. Priority
3. Estimated study hours

Assignment Title:
{title}

Assignment Description:
{description}
";

            var response =
                await _aiService.GenerateResponseAsync(
                    prompt);

            return response;
        }
    }
}