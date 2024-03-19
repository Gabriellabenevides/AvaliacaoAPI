using AvaliacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoAPI.Data
{
    public class AvaliacaoContext : DbContext
    {
        public AvaliacaoContext(DbContextOptions<AvaliacaoContext> opts) : base(opts) 
        { 
        }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }
    }
}
