using System.ComponentModel.DataAnnotations;

namespace ProvaTecnica_ControleAlugueis.Models
{
    public class Ferramenta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Estoque Máximo")]
        public int EstMax { get; set; }
        [Display(Name = "Estoque Mínimo")]
        public int EstMin { get; set; }
        [Display(Name = "Estoque Atual")]
        public int EstAtu { get; set; }
        [Display(Name = "Preço Diária")]
        public double PrecoDiaria { get; set; }
    }
}
