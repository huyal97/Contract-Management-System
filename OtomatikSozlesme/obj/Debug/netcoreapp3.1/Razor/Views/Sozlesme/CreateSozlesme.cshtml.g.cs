#pragma checksum "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\Sozlesme\CreateSozlesme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "877606f060e507376368fddbd438b581d6f3f286"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sozlesme_CreateSozlesme), @"mvc.1.0.view", @"/Views/Sozlesme/CreateSozlesme.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\_ViewImports.cshtml"
using OtomatikSozlesme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\_ViewImports.cshtml"
using OtomatikSozlesme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877606f060e507376368fddbd438b581d6f3f286", @"/Views/Sozlesme/CreateSozlesme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629f7c3e155e65f21e8f1e00a7270c6c83477f78", @"/Views/_ViewImports.cshtml")]
    public class Views_Sozlesme_CreateSozlesme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OtomatikSozlesme.Models.SozlesmePersonelModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "True", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "False", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Başkent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ayeşaş", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\Sozlesme\CreateSozlesme.cshtml"
  
    ViewData["Title"] = "SignUp";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h2>Yeni Sözleşme Oluştur</h2>\r\n\r\n\r\n    <hr />\r\n\r\n    <div>\r\n");
#nullable restore
#line 13 "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\Sozlesme\CreateSozlesme.cshtml"
         using (Html.BeginForm("SignUp", "Sozlesme", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">

            <div class=""form-group"">
                <label For=Firma class=""control-label"">Firma</label>
                <input type=""text"" name=""Firma"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""Tarih"" class=""control-label"">Tarih</label>
                <input type=""date"" name=""Tarih"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""TarihBitis"" class=""control-label"">Bitis Tarihi</label>
                <input type=""date"" name=""TarihBitis"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""Arti_Eksilis"" class=""control-label"">Artış eksiliş</label>
                <input type=""number"" name=""Arti_Eksilis"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""Baslik");
            WriteLiteral(@""" class=""control-label"">Başlık</label>
                <input type=""text"" name=""Baslik"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""Talep_Tarihi"" class=""control-label"" Talep Tarihi>Talep Tarihi</label>
                <input type=""date"" name=""Talep_Tarihi"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""Tamamlanma_Tarihi"" class=""control-label"">Tamamlanma Tarihi</label>
                <input type=""date"" name=""Tamamlanma_Tarihi"" class=""form-control form-control-sm"" />

            </div>
            <div class=""form-group"">
                <label for=""Sorumlu"" class=""control-label"">Sorumlu</label>
                <input type=""text"" name=""Sorumlu"" class=""form-control form-control-sm"" />

            </div>

            <div class=""form-group"">
                <label for=""Faturalama_Durum"" class=""control-label"">Faturalama Durumu</label>");
            WriteLiteral("\r\n                <select type=\"text\" name=\"Faturalama_Durum\" class=\"custom-select custom-select-sm\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877606f060e507376368fddbd438b581d6f3f2867273", async() => {
                WriteLiteral("Bölge Seçiniz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877606f060e507376368fddbd438b581d6f3f2868569", async() => {
                WriteLiteral("Evet");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877606f060e507376368fddbd438b581d6f3f2869746", async() => {
                WriteLiteral("Hayır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </select>

            </div>

            <div class=""form-group"">
                <label for=""Bolge"" class=""control-label"">Bölge</label>
                <select type=""text"" name=""Bolge"" class=""custom-select custom-select-sm"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877606f060e507376368fddbd438b581d6f3f28611188", async() => {
                WriteLiteral("Bölge Seçiniz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877606f060e507376368fddbd438b581d6f3f28612485", async() => {
                WriteLiteral("Başkent");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877606f060e507376368fddbd438b581d6f3f28613666", async() => {
                WriteLiteral("Ayeşaş");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </select>\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n");
            WriteLiteral("            <div id=\"container1\">\r\n                <h4>Personel:</h4>\r\n\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""form-group"">
                <button class=""btn btn-primary"" id=""add_form_field"">

                    <span style=""font-size:16px; font-weight:bold;"">+ </span>
                </button>
                <input type=""submit"" value=""Oluştur"" class=""btn btn-primary"" style=""float: right;"" />
            </div>
");
#nullable restore
#line 98 "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\Sozlesme\CreateSozlesme.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>


    <script type='text/javascript'>
        $(document).ready(function () {
            var max_fields = 10;
            var wrapper = $(""#container1"");
            var add_button = $(""#add_form_field"");

            var x = 0;
            $(add_button).click(function (e) {
                e.preventDefault();
                if (x < max_fields) {
                    x++;
                    $(wrapper).append('<div class= ""row"">\
    <div class=""form-group"">\
        <label for=""Adamsaat' + x + '"" class=""control-label"">Adam Saat</label>\
        <input type=""number"" name=""Adamsaat' + x + '"" class=""form-control form-control-sm""/>\
    </div>\
	<div class=""form-group"">\
        <label for=""SorumluYonetici' + x + '"" class=""control-label"">Sorumlu Yönetici</label>\
        <input type=""text"" name=""SorumluYonetici' + x + '"" class=""form-control form-control-sm""/>\
	</div>\
	<div class=""form-group"">\
        <label for=""Rate' + x + '"" class=""control-label"">Rate</label>\
		<input t");
            WriteLiteral(@"ype=""number"" name=""Rate' + x + '"" class=""form-control form-control-sm""/>\
    </div>\
    <div class=""form-group"">\
		<label for=""KaynakTipi'+ x +'"" class=""control-label"">Kaynak Tipi</label>\
		<select type=""text"" name=""KaynakTipi' + x + '"" class=""custom-select custom-select-sm"">\
			<option selected>Kaynak Tipi Seciniz</option>\
			<option value=""Uzman"">Uzman</option>\
			<option value=""Deneyimli"">Deneyimli</option>\
			<option value=""Kıdemli"">Kıdemli</option>\
		</select>\
	</div>\
    <div class=""form-group"">\
		<label for=""Uzmanlik' + x + '"" class=""control-label"">Uzmanlık</label>\
		<input type=""text"" name=""Uzmanlik' + x + '"" class=""form-control form-control-sm""/>\
    </div>\
	<div class=""form-group"">\
		<label for=""Isim' + x + '"" class=""control-label"">Isim</label>\
		<input type=""text"" name=""Isim' + x + '"" class=""form-control form-control-sm""/>\
	</div></div>'); //add input box
                } else {
                    alert('You Reached the limits')
                }
          ");
            WriteLiteral("  });\r\n\r\n            $(wrapper).on(\"click\", \".delete\", function (e) {\r\n                e.preventDefault();\r\n                $(this).parent(\'div\').remove();\r\n                x--;\r\n            })\r\n        });\r\n\r\n    </script>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 159 "C:\Users\hyalc\source\repos\OtomatikSozlesme\Views\Sozlesme\CreateSozlesme.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OtomatikSozlesme.Models.SozlesmePersonelModel> Html { get; private set; }
    }
}
#pragma warning restore 1591