using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Interface.Service
{
    public interface IFuncionarioService
    {
        Task AdicionarFuncionario(Funcionario listaFuncionario);
        Task <Funcionario> ObterPorNome(string nome);
    }
}
