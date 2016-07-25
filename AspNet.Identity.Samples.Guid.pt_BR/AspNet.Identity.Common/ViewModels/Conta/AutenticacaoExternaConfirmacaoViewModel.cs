using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Common.ViewModels
{
    public class AutenticacaoExternaConfirmacaoViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}