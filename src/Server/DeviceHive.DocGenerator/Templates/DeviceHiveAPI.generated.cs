﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviceHive.DocGenerator.Templates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Templates\DeviceHiveAPI.cshtml"
    using DeviceHive.DocGenerator;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Templates\DeviceHiveAPI.cshtml"
    using DeviceHive.DocGenerator.Templates;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    public partial class DeviceHiveAPI : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 4 "..\..\Templates\DeviceHiveAPI.cshtml"

    public Metadata ApiMetadata { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




WriteLiteral(@"
<!DOCTYPE html>
<html>
<head>
    <title>RESTful | DeviceHive</title>
    <link type=""text/css"" rel=""stylesheet"" href=""Css/Styles.css"" media=""all"" />
    <script src=""http://code.jquery.com/jquery-1.8.2.min.js""></script>
</head>
<body>
<div id=""wrap"">
    <h1 id=""page-title"" class=""title"">RESTful</h1>
    ");


            
            #line 17 "..\..\Templates\DeviceHiveAPI.cshtml"
Write(new PartialApi { ApiMetadata = ApiMetadata }.TransformText());

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n</body>\r\n</html>");


        }
    }
}
#pragma warning restore 1591
