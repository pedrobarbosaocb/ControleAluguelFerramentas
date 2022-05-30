using System.ComponentModel.DataAnnotations;

namespace ProvaTecnica_ControleAlugueis.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [RegularExpression(@"^[0-9]{5}\-?[0-9]{3}$")]
        public string CEP { get; set; }
    }
}
