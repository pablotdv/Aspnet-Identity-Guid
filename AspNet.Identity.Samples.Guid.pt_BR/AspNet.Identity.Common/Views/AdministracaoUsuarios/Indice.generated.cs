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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AdministracaoUsuarios/Indice.cshtml")]
    public partial class _Views_AdministracaoUsuarios_Indice_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<AspNet.Identity.Common.Models.Usuario>>
    {
        public _Views_AdministracaoUsuarios_Indice_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
  
    ViewBag.Title = "Indice";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Indice</h2>\r\n\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
Write(Html.ActionLink("Criar novo", "Criar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n<table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n    <tr>\r\n        <th>\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n\r\n        </th>\r\n    </tr>\r\n\r\n");

            
            #line 22 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
     foreach (var item in Model)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
           Write(Html.ActionLink("Editar", "Editar", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
           Write(Html.ActionLink("Detalhes", "Detalhes", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
           Write(Html.ActionLink("Excluir", "Excluir", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");

            
            #line 34 "..\..\Views\AdministracaoUsuarios\Indice.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</table>\r\n");

        }
    }
}
#pragma warning restore 1591
