using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Service
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository repository)
        {
            _avaliacaoRepository = repository;
        }
        public async Task AdicionarAvaliacao(Avaliacao avaliacoes)
        {
            await _avaliacaoRepository.AdicionarAvaliacao(avaliacoes);
        }

        public List<Avaliacao> RetornarAvaliacao()
        {
            throw new NotImplementedException();
        }
    }
}
