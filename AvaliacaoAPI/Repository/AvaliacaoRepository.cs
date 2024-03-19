using AvaliacaoAPI.Data;
using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Repository
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private readonly AvaliacaoContext _context;
        public AvaliacaoRepository(AvaliacaoContext context)
        {
            _context = context;
        }
        public async Task AdicionarAvaliacao(Avaliacao avaliacoes)
        {
            await _context.Avaliacao.AddAsync(avaliacoes);
            await  _context.SaveChangesAsync();
        }

        public List<Avaliacao> RetornarAvaliacao()
        {
            throw new NotImplementedException();
        }
    }
}
