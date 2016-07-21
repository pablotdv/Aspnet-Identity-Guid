using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNet.Identity.Samples.pt_BR.ViewModels
{
    public class AdicionarNumeroTelefoneViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Número do telefone")]
        public string Numero { get; set; }
    }
}