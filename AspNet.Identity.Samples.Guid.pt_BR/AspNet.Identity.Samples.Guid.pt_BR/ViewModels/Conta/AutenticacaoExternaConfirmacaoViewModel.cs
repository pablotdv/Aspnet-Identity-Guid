using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Samples.Common.ViewModels
{
    public class AutenticacaoExternaConfirmacaoViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}