using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNet.Identity.Samples.pt_BR.ViewModels
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