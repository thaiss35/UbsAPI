using System.ComponentModel.DataAnnotations;

namespace UbsApi.Models
{
    public class PacienteModel
    {
        [Required]
        public string? Cpf { get; set; }
        public string? Nome { get; set; }      
        public string? Telefone { get; set; }
        public DateTime DatadeNasciemnto { get; set; }
        public string? Endereco { get; set; }
        public string? NomeAgentedeSaude { get; set; }
        public string? CpfResponsavel { get; set; }
    }
}
