using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Models;
using AvaliacaoAPI.Repository;

namespace AvaliacaoAPI.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository repository)
        {
            _funcionarioRepository = repository;
        }
        public async Task AdicionarFuncionario(Funcionario funcionarios)
        {
            await _funcionarioRepository.AdicionarFuncionario(funcionarios);
        }

        public async Task <Funcionario> ObterPorNome(string nome)
        {
            var nomeFuncionario = await _funcionarioRepository.ObterPorNome(nome);
            return nomeFuncionario;
        }
    }
}
