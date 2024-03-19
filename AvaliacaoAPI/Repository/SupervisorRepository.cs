using AvaliacaoAPI.Data;
using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoAPI.Repository
{
    public class SupervisorRepository : ISupervisorRepository
    {
        private readonly AvaliacaoContext _context;
        public SupervisorRepository(AvaliacaoContext context)
        {
            _context = context;
        }
        public async Task AdicionarSupervisor(Supervisor supervisores)
        {
            await _context.Supervisor.AddAsync(supervisores);
            await _context.SaveChangesAsync();

        }

        public async Task<Supervisor> ObterPorNome(string nome)
        {
            Supervisor Supervisor = await _context.Supervisor.Where(x => x.NomeSup == nome).FirstOrDefaultAsync();
            return Supervisor;
        }
    }
}
