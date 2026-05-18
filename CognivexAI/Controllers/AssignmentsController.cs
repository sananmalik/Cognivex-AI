using CognivexAI.Agents;
using CognivexAI.Data;
using CognivexAI.DTOs;
using CognivexAI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CognivexAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly AssignmentAgent _agent;

        public AssignmentsController(
            ApplicationDbContext context,
            AssignmentAgent agent)
        {
            _context = context;
            _agent = agent;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssignment(
            CreateAssignmentDto dto)
        {
            var assignment = new Assignment
            {
                Title = dto.Title,
                Description = dto.Description
            };

            _context.Assignments.Add(assignment);

            await _context.SaveChangesAsync();

            var aiAnalysis =
                await _agent.AnalyzeAssignment(
                    dto.Title,
                    dto.Description);

            return Ok(new
            {
                Assignment = assignment,
                AiAnalysis = aiAnalysis
            });
        }

        [HttpGet]
        public IActionResult GetAssignments()
        {
            var assignments =
                _context.Assignments.ToList();

            return Ok(assignments);
        }
    }
}