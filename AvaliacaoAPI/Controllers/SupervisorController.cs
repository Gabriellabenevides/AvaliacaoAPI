using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupervisorController : ControllerBase
    {
        private readonly ILogger<SupervisorController> _logger;
        private readonly ISupervisorService _supervisoresService;

        public SupervisorController(ILogger<SupervisorController> logger, ISupervisorService supervisoresService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _supervisoresService = supervisoresService ?? throw new ArgumentNullException(nameof(supervisoresService));
        }
        [HttpPost(template: "Create")]
        public async Task<IActionResult> CreateSupervisor(Supervisor supervisores)
        {
            try
            {
                await _supervisoresService.AdicionarSupervisor(supervisores);
                return Ok(); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar supervisor: {ex.Message}");
            }
        }
    }
}