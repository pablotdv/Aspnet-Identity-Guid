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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Conta/EsqueceuSenhaConfirmacao.cshtml")]
    public partial class _Views_Conta_EsqueceuSenhaConfirmacao_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Conta_EsqueceuSenhaConfirmacao_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Conta\EsqueceuSenhaConfirmacao.cshtml"
  
    ViewBag.Title = "Esqueceu sua senha confirmação";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>");

            
            #line 6 "..\..\Views\Conta\EsqueceuSenhaConfirmacao.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n</hgroup>\r\n<div>\r\n    <p>\r\n        Por favor, verifique seu e-mail para r" +
"edefinir sua senha.\r\n    </p>\r\n    <p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">\r\n\r\n        Apenas para demonstração: Você pode clicar neste link para redefinir" +
" a\r\n        senha: <a");

WriteAttribute("href", Tuple.Create(" href=\"", 350), Tuple.Create("\"", 370)
            
            #line 15 "..\..\Views\Conta\EsqueceuSenhaConfirmacao.cshtml"
, Tuple.Create(Tuple.Create("", 357), Tuple.Create<System.Object, System.Int32>(ViewBag.Link
            
            #line default
            #line hidden
, 357), false)
);

WriteLiteral(">link</a>. Por favor, altere este\r\n        código para registrar um serviço de e-" +
"mail no IdentityConfig para enviar um e-mail.\r\n    </p>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
