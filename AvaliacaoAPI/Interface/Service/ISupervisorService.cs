using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Interface.Service
{
    public interface ISupervisorService
    {
        Task AdicionarSupervisor(Supervisor listaSupervisor);
        Task <Supervisor> ObterPorNome(string nome);
    }
}
