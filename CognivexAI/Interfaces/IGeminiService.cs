using System.Threading.Tasks;

namespace CognivexAI.Interfaces
{
    public interface IGeminiService
    {
        Task<string> GenerateResponseAsync(string prompt);
    }
}