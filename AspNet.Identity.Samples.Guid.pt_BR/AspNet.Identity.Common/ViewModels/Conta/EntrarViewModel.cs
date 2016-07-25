using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Common.ViewModels
{
    public class EntrarViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool LembrarMe { get; set; }
    }
}