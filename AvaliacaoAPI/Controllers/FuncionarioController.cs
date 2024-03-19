using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly ILogger<FuncionarioController> _logger;
        private readonly IFuncionarioService _funcionariosService;

        public FuncionarioController(ILogger<FuncionarioController> logger, IFuncionarioService funcionariosService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _funcionariosService = funcionariosService ?? throw new ArgumentNullException(nameof(funcionariosService));
        }
        [HttpPost(template: "Create")]
        public async Task<IActionResult> CreateFuncionario(Funcionario funcionarios)
        {
            try
            {
                await _funcionariosService.AdicionarFuncionario(funcionarios);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar funcionario: {ex.Message}");
            }
        }
    }
}

