﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/CubeError.cshtml")]
    public partial class _Views_Shared_CubeError_cshtml : System.Web.Mvc.WebViewPage<System.Web.Mvc.HandleErrorInfo>
    {
        public _Views_Shared_CubeError_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\CubeError.cshtml"
  
    //Layout = "_Ace_Layout.cshtml";
    Layout = "_Layout.cshtml";
    //Layout = NewLife.Cube.Setting.Current.Layout;
    ViewBag.Title = "处理你的请求时出错";

    var error = "没有捕捉到异常信息";
    var context = ViewBag.Context as ExceptionContext;
    if (context != null && context.Exception != null)
    {
        // 由于nginx的配置导致出现奇葩错误
        error = context.Exception.Message;
        if (NewLife.Log.XTrace.Debug)
        {
            error = context.Exception.ToString();
        }
    }
    error = error.Replace("--->", "--->" + Environment.NewLine);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n        <strong>\r\n            <pre");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Shared\CubeError.cshtml"
                                                    Write(error);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n        </strong>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"javascript: history.go(-1);\"");

WriteLiteral(" class=\"btn btn-info\"");

WriteLiteral(">返回上一页</a>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
