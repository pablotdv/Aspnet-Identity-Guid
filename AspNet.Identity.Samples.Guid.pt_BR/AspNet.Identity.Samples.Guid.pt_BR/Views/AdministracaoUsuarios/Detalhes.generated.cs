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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AdministracaoUsuarios/Detalhes.cshtml")]
    public partial class _Views_AdministracaoUsuarios_Detalhes_cshtml : System.Web.Mvc.WebViewPage<AspNet.Identity.Samples.Common.Models.Usuario>
    {
        public _Views_AdministracaoUsuarios_Detalhes_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
  
    ViewBag.Title = "Detalhes";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Detalhes.</h2>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<h4>List of roles for this user</h4>\r\n");

            
            #line 22 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
 if (ViewBag.RoleNames.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <hr />\r\n");

WriteLiteral("    <p>No roles found for this user.</p>\r\n");

            
            #line 26 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n\r\n");

            
            #line 30 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
     foreach (var item in ViewBag.RoleNames)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 34 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
           Write(item);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");

            
            #line 37 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</table>\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 40 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
Write(Html.ActionLink("Editar", "Editar", new { id = Model.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("    ");

            
            #line 41 "..\..\Views\AdministracaoUsuarios\Detalhes.cshtml"
Write(Html.ActionLink("Voltar para Listagem", "Indice"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
