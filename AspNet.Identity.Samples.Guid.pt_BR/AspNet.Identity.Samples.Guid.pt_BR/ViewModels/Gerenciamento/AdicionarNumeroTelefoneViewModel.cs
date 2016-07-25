using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Samples.Common.ViewModels
{
    public class AdicionarNumeroTelefoneViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Número do telefone")]
        public string Numero { get; set; }
    }
}