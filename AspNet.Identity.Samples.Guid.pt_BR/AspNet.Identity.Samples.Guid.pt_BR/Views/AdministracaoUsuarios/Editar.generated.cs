﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AdministracaoUsuarios/Editar.cshtml")]
    public partial class _Views_AdministracaoUsuarios_Editar_cshtml : System.Web.Mvc.WebViewPage<AspNet.Identity.Samples.Common.ViewModels.EditarUsuarioViewModel>
    {
        public _Views_AdministracaoUsuarios_Editar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
  
    ViewBag.Title = "Editar";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Editar.</h2>\r\n\r\n\r\n");

            
            #line 10 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
                            


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <h4>Formulário de edição de usuário.</h4>\r\n        <hr />\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
   Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
       Write(Html.LabelFor(model => model.Email, new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("               ");

            
            #line 22 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
          Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("               ");

            
            #line 23 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
          Write(Html.ValidationMessageFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
       Write(Html.Label("Roles", new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" class=\" col-md-10\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
                 foreach (var item in Model.RolesList)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"SelectedRole\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1017), Tuple.Create("\"", 1036)
            
            #line 31 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
, Tuple.Create(Tuple.Create("", 1025), Tuple.Create<System.Object, System.Int32>(item.Value
            
            #line default
            #line hidden
, 1025), false)
);

WriteAttribute("checked", Tuple.Create(" checked=\"", 1037), Tuple.Create("\"", 1061)
            
            #line 31 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
            , Tuple.Create(Tuple.Create("", 1047), Tuple.Create<System.Object, System.Int32>(item.Selected
            
            #line default
            #line hidden
, 1047), false)
);

WriteLiteral(" class=\"checkbox-inline\"");

WriteLiteral(" />\r\n");

            
            #line 32 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
               Write(Html.Label(item.Value, new { @class = "control-label" }));

            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
                                                                             
                }

            
            #line default
            #line hidden
WriteLiteral("            </span>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Salvar\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 43 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 46 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
Write(Html.ActionLink("Voltar para Listagem", "Indice"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 50 "..\..\Views\AdministracaoUsuarios\Editar.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
