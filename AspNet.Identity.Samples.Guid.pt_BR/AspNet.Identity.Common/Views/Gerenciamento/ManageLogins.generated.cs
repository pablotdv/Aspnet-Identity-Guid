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
    
    #line 2 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
    using Microsoft.Owin.Security;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Gerenciamento/ManageLogins.cshtml")]
    public partial class _Views_Gerenciamento_ManageLogins_cshtml : System.Web.Mvc.WebViewPage<AspNet.Identity.Samples.Common.ViewModels.ManageLoginsViewModel>
    {
        public _Views_Gerenciamento_ManageLogins_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
  
    ViewBag.Title = "Manage your external logins";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 7 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h2>\r\n\r\n<p");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                   Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 10 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
 if (Model.CurrentLogins.Count > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <h4>Registered Logins</h4>\r\n");

WriteLiteral("    <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n        <tbody>\r\n");

            
            #line 15 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
             foreach (var account in Model.CurrentLogins)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");

            
            #line 18 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                   Write(account.LoginProvider);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>\r\n");

            
            #line 20 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                         if (ViewBag.ShowRemoveButton)
                        {
                            using (Html.BeginForm("RemoveLogin", "Manage"))
                            {
                                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                                                        

            
            #line default
            #line hidden
WriteLiteral("                                <div>\r\n");

WriteLiteral("                                    ");

            
            #line 26 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                               Write(Html.Hidden("loginProvider", account.LoginProvider));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 27 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                               Write(Html.Hidden("providerKey", account.ProviderKey));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" value=\"Remove\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1095), Tuple.Create("\"", 1161)
, Tuple.Create(Tuple.Create("", 1103), Tuple.Create("Remove", 1103), true)
, Tuple.Create(Tuple.Create(" ", 1109), Tuple.Create("this", 1110), true)
            
            #line 28 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                                  , Tuple.Create(Tuple.Create(" ", 1114), Tuple.Create<System.Object, System.Int32>(account.LoginProvider
            
            #line default
            #line hidden
, 1115), false)
, Tuple.Create(Tuple.Create(" ", 1137), Tuple.Create("login", 1138), true)
, Tuple.Create(Tuple.Create(" ", 1143), Tuple.Create("from", 1144), true)
, Tuple.Create(Tuple.Create(" ", 1148), Tuple.Create("your", 1149), true)
, Tuple.Create(Tuple.Create(" ", 1153), Tuple.Create("account", 1154), true)
);

WriteLiteral(" />\r\n                                </div>\r\n");

            
            #line 30 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                            }
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral(" &nbsp;\r\n");

            
            #line 35 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");

            
            #line 38 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");

            
            #line 41 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
}

            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
 if (Model.OtherLogins.Count > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <h4>Add another service to log in.</h4>\r\n");

WriteLiteral("    <hr />\r\n");

            
            #line 46 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
    using (Html.BeginForm("LinkLogin", "Manage"))
    {
        
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                                

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"socialLoginList\"");

WriteLiteral(">\r\n        <p>\r\n");

            
            #line 51 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
            
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
             foreach (AuthenticationDescription p in Model.OtherLogins)
            {

            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1873), Tuple.Create("\"", 1899)
            
            #line 53 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 1878), false)
);

WriteLiteral(" name=\"provider\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1916), Tuple.Create("\"", 1945)
            
            #line 53 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                                , Tuple.Create(Tuple.Create("", 1924), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 1924), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1946), Tuple.Create("\"", 1990)
, Tuple.Create(Tuple.Create("", 1954), Tuple.Create("Log", 1954), true)
, Tuple.Create(Tuple.Create(" ", 1957), Tuple.Create("in", 1958), true)
, Tuple.Create(Tuple.Create(" ", 1960), Tuple.Create("using", 1961), true)
, Tuple.Create(Tuple.Create(" ", 1966), Tuple.Create("your", 1967), true)
            
            #line 53 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                                                                               , Tuple.Create(Tuple.Create(" ", 1971), Tuple.Create<System.Object, System.Int32>(p.Caption
            
            #line default
            #line hidden
, 1972), false)
, Tuple.Create(Tuple.Create(" ", 1982), Tuple.Create("account", 1983), true)
);

WriteLiteral(">");

            
            #line 53 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
                                                                                                                                                                               Write(p.AuthenticationType);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 54 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </p>\r\n        </div>\r\n");

            
            #line 57 "..\..\Views\Gerenciamento\ManageLogins.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
