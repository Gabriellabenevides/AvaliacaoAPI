using AvaliacaoAPI.Models;

namespace AvaliacaoAPI.Interface.Repository
{
    public interface IFuncionarioRepository
    {
        Task AdicionarFuncionario(Funcionario funcionarios);
        Task <Funcionario> ObterPorNome(string nome);
    }
}
