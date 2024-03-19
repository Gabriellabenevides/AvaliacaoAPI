using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Models;
using AvaliacaoAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly ILogger<AvaliacaoController> _logger;
        private readonly IAvaliacaoService _avaliacoesService;
        private readonly IFuncionarioService _funcionariosService;
        private readonly ISupervisorService _supervisoresService;

        public AvaliacaoController(ILogger<AvaliacaoController> logger, IAvaliacaoService avaliacoesService, IFuncionarioService funcionariosService, ISupervisorService supervisoresService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _avaliacoesService = avaliacoesService ?? throw new ArgumentNullException(nameof(avaliacoesService));
            _funcionariosService = funcionariosService;
            _supervisoresService = supervisoresService;
        }
        [HttpPost(template: "Create")]
        public async Task<IActionResult> CreateAvaliacao(Avaliacao avaliacoes)
        {
            try
            {
                Funcionario funcionario = await _funcionariosService.ObterPorNome(avaliacoes.NomeAvaliado);
                Supervisor supervisor = await _supervisoresService.ObterPorNome(avaliacoes.NomeAvaliador);

                if (funcionario != null && supervisor != null)
                {
                    avaliacoes.Funcionario = funcionario;
                    avaliacoes.Supervisor = supervisor;
                    await _avaliacoesService.AdicionarAvaliacao(avaliacoes);
                    return Ok();
                }
                else
                {
                    return BadRequest("Não encontrado.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar avaliação: {ex.Message}");
            }
        }
    }
}