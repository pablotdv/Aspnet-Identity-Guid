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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AdministracaoUsuarios/Excluir.cshtml")]
    public partial class _Views_AdministracaoUsuarios_Excluir_cshtml : System.Web.Mvc.WebViewPage<AspNet.Identity.Samples.Common.Models.Usuario>
    {
        public _Views_AdministracaoUsuarios_Excluir_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
  
    ViewBag.Title = "Excluir";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Excluir.</h2>\r\n\r\n<h3>Tem certeza de que deseja excluir este usuário?</h3>" +
"\r\n<div>\r\n    <h4>User.</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");

            
            #line 23 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
     using (Html.BeginForm()) {
        
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
                                


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-actions no-color\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Excluir\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" /> |\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
       Write(Html.ActionLink("Voltar para Listagem", "Indice"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 30 "..\..\Views\AdministracaoUsuarios\Excluir.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
