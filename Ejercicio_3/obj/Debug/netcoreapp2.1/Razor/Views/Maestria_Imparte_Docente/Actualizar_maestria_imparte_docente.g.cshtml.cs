#pragma checksum "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14972dc8a4cd97a4c0e7635e643ae5663d570cac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maestria_Imparte_Docente_Actualizar_maestria_imparte_docente), @"mvc.1.0.view", @"/Views/Maestria_Imparte_Docente/Actualizar_maestria_imparte_docente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Maestria_Imparte_Docente/Actualizar_maestria_imparte_docente.cshtml", typeof(AspNetCore.Views_Maestria_Imparte_Docente_Actualizar_maestria_imparte_docente))]
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
#line 1 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\_ViewImports.cshtml"
using Ejercicio_3;

#line default
#line hidden
#line 2 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\_ViewImports.cshtml"
using Ejercicio_3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14972dc8a4cd97a4c0e7635e643ae5663d570cac", @"/Views/Maestria_Imparte_Docente/Actualizar_maestria_imparte_docente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0c7903755d73e668b11b5a961d72b799bd421a", @"/Views/_ViewImports.cshtml")]
    public class Views_Maestria_Imparte_Docente_Actualizar_maestria_imparte_docente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maestria_Imparte_Docente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Maestria_Imparte_Docente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Actualizar_maestria_imparte_docente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 36, true);
            WriteLiteral("<h1>Update_Maestria_Docente</h1>\r\n\r\n");
            EndContext();
            BeginContext(76, 2025, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321d1dc49d614a9382809e588fb5a738", async() => {
                BeginContext(187, 130, true);
                WriteLiteral("\r\n    <div class=\"input-group mb-3\">\r\n        <div class=\"input-group-prepend\">\r\n            <label>Maestria</label>\r\n            ");
                EndContext();
                BeginContext(317, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31907f0377554e1ea2406573ec1abc64", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 10 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Maestria);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(376, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(390, 626, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1f51c526cd4960bcdb051ef1c22fca", async() => {
                    BeginContext(441, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 12 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                 foreach (var item in CRUD.Maestrias)
                {
                    if (item.Id_Maestria == CRUD.Maestria_Imparte_Docentes[ViewBag.ID].Id_Maestria)
                    {

#line default
#line hidden
                    BeginContext(641, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(665, 104, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1cd380a883f43f8a089a30adf0225f8", async() => {
                        BeginContext(720, 16, false);
#line 16 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                                         Write(item.Id_Maestria);

#line default
#line hidden
                        EndContext();
                        BeginContext(736, 3, true);
                        WriteLiteral(" - ");
                        EndContext();
                        BeginContext(740, 20, false);
#line 16 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                                                             Write(item.Nombre_Maestria);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 16 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                           WriteLiteral(item.Id_Maestria);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(769, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 17 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                    BeginContext(843, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(867, 84, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "189f564464b44872a23fc3d0133f3752", async() => {
                        BeginContext(902, 16, false);
#line 20 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                     Write(item.Id_Maestria);

#line default
#line hidden
                        EndContext();
                        BeginContext(918, 3, true);
                        WriteLiteral(" - ");
                        EndContext();
                        BeginContext(922, 20, false);
#line 20 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                                         Write(item.Nombre_Maestria);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 20 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                           WriteLiteral(item.Id_Maestria);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(951, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 21 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                    }
                }

#line default
#line hidden
                    BeginContext(995, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 11 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Maestria);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1016, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1030, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b2e2027596f4ebdbcb32a1f384fdab4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 24 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Maestria);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1096, 109, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"input-group-prepend\">\r\n            <label>Docente</label>\r\n            ");
                EndContext();
                BeginContext(1205, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beab8d3c3f79409888864943d0a07743", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 28 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Docente);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1263, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1277, 616, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd605f5ad5644eac94b991f5bad60c5a", async() => {
                    BeginContext(1327, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 30 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                 foreach (var item in CRUD.Docentes)
                {
                    if (item.Id_Docente == CRUD.Maestria_Imparte_Docentes[ViewBag.ID].Id_Docente)
                    {

#line default
#line hidden
                    BeginContext(1524, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(1548, 101, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c8e52667d5b4ef6867d52b26b061e54", async() => {
                        BeginContext(1602, 15, false);
#line 34 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                                        Write(item.Id_Docente);

#line default
#line hidden
                        EndContext();
                        BeginContext(1617, 3, true);
                        WriteLiteral(" - ");
                        EndContext();
                        BeginContext(1621, 19, false);
#line 34 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                                                           Write(item.Nombre_Docente);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 34 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                           WriteLiteral(item.Id_Docente);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1649, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 35 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                    BeginContext(1723, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(1747, 81, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165a3b0edced43f797d705c355b4f4fe", async() => {
                        BeginContext(1781, 15, false);
#line 38 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                    Write(item.Id_Docente);

#line default
#line hidden
                        EndContext();
                        BeginContext(1796, 3, true);
                        WriteLiteral(" - ");
                        EndContext();
                        BeginContext(1800, 19, false);
#line 38 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                                                                       Write(item.Nombre_Docente);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 38 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                           WriteLiteral(item.Id_Docente);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1828, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 39 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
                    }
                }

#line default
#line hidden
                    BeginContext(1872, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 29 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Docente);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1893, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1907, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f53f731184604b14b213093affe75e56", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 42 "E:\ITLA\ITLA\5to cuatri\Programacion III\Tarea 5\Ejercicio_3\Ejercicio_3\Views\Maestria_Imparte_Docente\Actualizar_maestria_imparte_docente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Docente);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1972, 122, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <p>\r\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Agregar\">\r\n    </p>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maestria_Imparte_Docente> Html { get; private set; }
    }
}
#pragma warning restore 1591
