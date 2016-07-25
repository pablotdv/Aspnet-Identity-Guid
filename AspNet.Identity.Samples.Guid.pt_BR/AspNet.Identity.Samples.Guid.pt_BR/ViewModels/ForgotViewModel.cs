using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Samples.Common.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}