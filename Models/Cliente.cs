using System.ComponentModel.DataAnnotations;

namespace ProvaTecnica_ControleAlugueis.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o campo Nome")]
        public string Nome { get; set; }
        [RegularExpression(@"^\(?[0-9]{2}\)?[0-9]{5}\-?[0-9]{4}$", ErrorMessage = "Celular Inválido")]
        public string Celular { get; set; }
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        [RegularExpression(@"^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}$", ErrorMessage = "CPF Inválido")]
        public string CPF { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
