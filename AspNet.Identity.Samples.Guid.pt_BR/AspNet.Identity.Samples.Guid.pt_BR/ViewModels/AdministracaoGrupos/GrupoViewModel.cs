using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNet.Identity.Samples.pt_BR.ViewModels
{
    public class GrupoViewModel
    {
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Grupo nome")]
        public string Nome { get; set; }
    }
}