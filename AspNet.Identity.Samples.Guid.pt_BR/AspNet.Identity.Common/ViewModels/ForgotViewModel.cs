using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Common.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}