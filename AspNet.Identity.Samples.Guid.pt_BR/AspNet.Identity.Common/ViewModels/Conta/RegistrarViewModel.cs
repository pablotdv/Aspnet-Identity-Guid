using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Common.ViewModels
{
    public class RegistrarViewModel
    {                
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("Senha", ErrorMessage = "A nova senha e confirmação de senha não correspondem.")]
        public string SenhaConfirmacao { get; set; }
    }
}