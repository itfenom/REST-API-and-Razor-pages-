#pragma checksum "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce5e6d191321381669065be1c8f892bd13cbc669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WineCollectionApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WineCollectionApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\_ViewImports.cshtml"
using WineCollectionApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce5e6d191321381669065be1c8f892bd13cbc669", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255158d03bf91117789a4ab8d448bbcf3982ee88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Producer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Bottle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ayaka\source\repos\WineCollectionApp\WineCollectionApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-left:50px; margin-right:50px;"">
    <div class=""text-center"">
        <h1 class=""display-4"" style=""background-color:cornsilk;"">Welcome</h1>
        <div class=""text-left row"">
            <div class=""col-md-3"" >
                <h2>
                    All Producers
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce5e6d191321381669065be1c8f892bd13cbc6694324", async() => {
                WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-default\" style=\"border-color: cadetblue;\" aria-label=\"Left Align\">\r\n                            <span aria-hidden=\"true\">+</span>\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h2>\r\n                <ul id=\"producers\" style=\"background-color: aliceblue;\" />\r\n            </div>\r\n\r\n            <div class=\"col-md-9\">\r\n                <h2>\r\n                    Bottles\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce5e6d191321381669065be1c8f892bd13cbc6696186", async() => {
                WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-default\" style=\"border-color: cadetblue;\" aria-label=\"Left Align\">\r\n                            <span aria-hidden=\"true\">+</span>\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h2>\r\n\r\n                <table class=\"table\" id=\"tblBottle\"></table>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <script src=\"https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js\"></script> ");
            WriteLiteral(@"
        <script>
            var uri = 'api/producer/getall';

            $(document).ready(function () {
                // Send an AJAX request
                $.getJSON(uri)
                    .done(function (data) {
                        // On success, 'data' contains a list of producers.
                        $.each(data, function (key, item) {
                            // Add a list item for the producer.

                            var button = document.createElement(""button"");
                            button.innerHTML = ""Show bottles"";
                            button.classList.add(""btn"");
                            button.classList.add(""btn-primary"");                            
                            button.style = ""float: right;"";
                            button.setAttribute(""onclick"", ""getBottlesByProducerId("" + item.id + "")"");

                            var li = document.createElement(""li"");
                            li.style = ""height:40px;"";
    ");
            WriteLiteral(@"                        li.appendChild(document.createTextNode(formatProducer(item)));
                            li.appendChild(button);
                            $('#producers').append(li);
                        });
                    });
            });

            function getBottlesByProducerId(id) {

                $.getJSON('api/producer/' + id + '/GetBottles')
                    .done(function (data) {
                        // On success, 'data' contains a list of bottles.
                        clearTable();
                        if (data.length > 0) {
                            var table = document.getElementById('tblBottle');
                            createTableHead(data, table);
                        }
                        $.each(data, function (key, item) {
                            // Add a list item for the bottles.
                            createTableDataRow(item, table);
                        });
                    });
            }

    ");
            WriteLiteral(@"        function deleteBottle(id) {
                $.ajax({
                    type: ""DELETE"",
                    url: 'api/producer/DeleteBottle/' + id,
                    success: function (data) {
                        console.log(data);
                    },
                    error: function (data) {
                        console.log('Error:', data);
                    }
                });

                $('#' + id).remove();
            }


            function createTableHead(data, table) {
                var thead = document.createElement(""thead"");
                var tr = document.createElement(""tr"");
                thead.appendChild(tr);
                table.appendChild(thead);

                for (i in Object.keys(data[0])) {
                    var colName = Object.keys(data[0])[i];
                    createTableHeadColumn(table.tHead.children[0], colName);
                }

                //For the last column that contains the button
             ");
            WriteLiteral(@"   createTableHeadColumn(table.tHead.children[0], """");
            }

            function createTableHeadColumn(tr, columnName) {
                var th = document.createElement(""th"");
                th.innerHTML = columnName;
                tr.appendChild(th);
            }

            function createTableDataRow(item, table) {

                var rowNode = document.createElement(""tr"");

                for (i in Object.keys(item)) {
                    var name = Object.keys(item)[i];
                    var value = item[name];

                    if (name == ""id"") {
                        rowNode.id = value; //so that we can identify the bottle row
                    }

                    var cellNode = document.createElement(""td"");
                    var textNode = document.createTextNode(value);
                    cellNode.appendChild(textNode);
                    rowNode.appendChild(cellNode);
                }

                var button = document.createElement(""");
            WriteLiteral(@"button"");
                button.innerHTML = ""Delete"";
                button.classList.add(""btn"");
                button.classList.add(""btn-danger"");           
                button.setAttribute(""onclick"", ""deleteBottle("" + item.id + "")"");

                rowNode.appendChild(button);
                table.appendChild(rowNode);
            }

            function clearTable() {
                $('#tblBottle').empty();
            }

            function formatProducer(item) {
                return item.name + ': ' + item.address;
            };


        </script>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
