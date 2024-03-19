using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Interface.Repository
{
    public interface ISupervisorRepository
    {
        Task AdicionarSupervisor(Supervisor supervisores);
        Task <Supervisor> ObterPorNome(string nome);
    }
}
