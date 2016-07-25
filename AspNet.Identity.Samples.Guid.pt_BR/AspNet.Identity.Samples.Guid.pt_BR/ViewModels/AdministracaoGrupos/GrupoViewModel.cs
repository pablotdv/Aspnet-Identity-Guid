using System;
using System.ComponentModel.DataAnnotations;

namespace AspNet.Identity.Samples.Common.ViewModels
{
    public class GrupoViewModel
    {
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Grupo nome")]
        public string Nome { get; set; }
    }
}