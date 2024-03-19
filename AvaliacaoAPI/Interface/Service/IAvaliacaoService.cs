using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Interface.Service
{
    public interface IAvaliacaoService
    {
        Task AdicionarAvaliacao(Avaliacao listaAvaliacao);
        List<Avaliacao> RetornarAvaliacao();
    }
}
