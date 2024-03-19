using AvaliacaoAPI.Data;
using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoAPI.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly AvaliacaoContext _context;
        public FuncionarioRepository(AvaliacaoContext context)
        {
            _context = context;
        }
        public async Task AdicionarFuncionario(Funcionario funcionarios)
        {
            await _context.Funcionario.AddAsync(funcionarios);
            await _context.SaveChangesAsync();
        }

        public async Task <Funcionario> ObterPorNome(string nome)
        {
            Funcionario Funcionario = await _context.Funcionario.Where(x => x.NomeFuncionario == nome).FirstOrDefaultAsync();
            return Funcionario;
        }
    }
}
