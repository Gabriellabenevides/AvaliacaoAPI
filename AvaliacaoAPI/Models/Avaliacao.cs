namespace AvaliacaoAPI.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public string NomeAvaliador { get; set; }
        public string NomeAvaliado { get; set; }
        public DateTime? DataAvaliacao { get; set; } = DateTime.Now;
        public string Comentario { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
