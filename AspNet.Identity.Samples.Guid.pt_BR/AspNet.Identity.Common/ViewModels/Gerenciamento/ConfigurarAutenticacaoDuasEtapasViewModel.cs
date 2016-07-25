using System.Collections.Generic;

namespace AspNet.Identity.Common.ViewModels
{
    public class ConfigurarAutenticacaoDuasEtapasViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}