using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Samples.Common.ViewModels
{
    public class VerificarCodigoViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Lembrar este navegador?")]
        public bool LembrarNavegador { get; set; }
    }
}