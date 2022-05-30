using System.ComponentModel.DataAnnotations;

namespace ProvaTecnica_ControleAlugueis.Models
{
    public class Solicitacao
    {
        public int Id { get; set; }
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        [Display(Name = "Ferramenta")]
        public int FerramentaId { get; set; }
        public Ferramenta Ferramenta { get; set; }

        [Display(Name = "Quantidade de Ferramentas")]
        [Range(1, 1000000, ErrorMessage = "Insira um valor entre 1 e 1.000.000")]
        public int QtdFerramentas { get; set; }
        [Display(Name = "Período Aluguel (Dias)")]
        [Range(1,1000000, ErrorMessage = "Insira um valor entre 1 e 1.000.000")]
        public int QtdDias { get; set; }
    }
}
