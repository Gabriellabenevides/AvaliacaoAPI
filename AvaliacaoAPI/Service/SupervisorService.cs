using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Models;
using AvaliacaoAPI.Repository;

namespace AvaliacaoAPI.Service
{
    public class SupervisorService : ISupervisorService
    {
        private readonly ISupervisorRepository _supervisorRepository;

        public SupervisorService(ISupervisorRepository repository)
        {
            _supervisorRepository = repository;
        }
        public async Task AdicionarSupervisor(Supervisor supervisores)
        {
            await _supervisorRepository.AdicionarSupervisor(supervisores);
        }

        public async Task<Supervisor> ObterPorNome(string nome)
        {
            var nomeSup = await _supervisorRepository.ObterPorNome(nome);
            return nomeSup;
        }
    }
}
