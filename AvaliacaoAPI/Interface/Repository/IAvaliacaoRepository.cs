using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Interface.Repository
{
    public interface IAvaliacaoRepository
    {
        Task AdicionarAvaliacao(Avaliacao avaliacoes);
        List<Avaliacao> RetornarAvaliacao();
    }
}
