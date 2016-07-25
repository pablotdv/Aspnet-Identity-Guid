using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Samples.Common.ViewModels
{
    public class AlterarSenhaViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        public string SenhaAtual { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string SenhaNova { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("SenhaNova", ErrorMessage = "A nova senha e confirmação de senha não correspondem.")]
        public string SenhaConfirmacao { get; set; }
    }
}