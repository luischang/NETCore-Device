#pragma checksum "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc182427dd87f273650c2cbcd3fee7679a5e44b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Equipo_Views_Registro_Index), @"mvc.1.0.view", @"/Areas/Equipo/Views/Registro/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc182427dd87f273650c2cbcd3fee7679a5e44b8", @"/Areas/Equipo/Views/Registro/Index.cshtml")]
    public class Areas_Equipo_Views_Registro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DEVICE.Web.ViewModels.RegistroEquipoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
  
    ViewData["Title"] = "Registro de Equipos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<form asp-area=""Equipo"" asp-controller=""Registro"" asp-action=""Index"" method=""post"">
    <div class=""form-row"">
        <div class=""form-group col-md-2"">
            <label for=""inputPassword4"">Tipo</label>
            <select name=""TipoProductoID"" id=""cboTipoProducto"" class=""form-control"">
                <option selected>---SELECCIONE---</option>
");
#nullable restore
#line 13 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                 foreach (var item in Model.ListadoTipoProducto)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 587, "\"", 603, 1);
#nullable restore
#line 15 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
WriteAttributeValue("", 595, item.Id, 595, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                                        Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 16 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>

        <div class=""form-group col-md-5"" id=""divNumeroSerie"" style=""display:inline"">
            <label for=""inputEmail4"">N° Serie</label>
            <input type=""text"" name=""NumeroSerie"" class=""form-control"" id=""txtNroSerie"" placeholder=""Ingrese el número de serie"">
        </div>
        <div class=""form-group col-md-5"" id=""divNumeroProducto"" style=""display:inline"">
            <label for=""inputEmail4"">N° Producto</label>
            <input type=""text"" name=""NumeroProducto"" class=""form-control"" id=""txtNroProducto"" placeholder=""Ingrese el número de producto"">
        </div>


    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-3"">
            <label for=""inputEmail4"">Memoria RAM</label>
            <select name=""MemoriaRam"" id=""cboMemoriaRam"" class=""form-control"">
                <option selected>---SELECCIONE---</option>
");
#nullable restore
#line 36 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                 for (int i = 4; i <= 64; i += 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 1666, "\"", 1676, 1);
#nullable restore
#line 38 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
WriteAttributeValue("", 1674, i, 1674, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                                   Write(i + "GB");

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 39 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""form-group col-md-9"">
            <label for=""inputEmail4"">Modelo del Sistema</label>
            <input type=""text"" name=""ModeloSistema"" class=""form-control"" id=""txtModeloSistema"" placeholder=""Ingrese el modelo del sistema"">
        </div>

    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">Sistema Operativo</label>
            <select name=""SistemaOperativoID"" id=""cboSistemaOperativo"" class=""form-control"">
                <option selected>---SELECCIONE---</option>
");
#nullable restore
#line 53 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                 foreach (var item in Model.ListadoSistemaOperativo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 2442, "\"", 2458, 1);
#nullable restore
#line 55 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
WriteAttributeValue("", 2450, item.Id, 2450, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                                        Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 56 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">Fabricante</label>
            <select name=""FabricanteID"" id=""cboFabricante"" class=""form-control"">
                <option selected>---SELECCIONE---</option>
");
#nullable restore
#line 63 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                 foreach (var item in Model.ListadoFabricante)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 2898, "\"", 2914, 1);
#nullable restore
#line 65 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
WriteAttributeValue("", 2906, item.Id, 2906, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                                        Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 66 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">Procesador</label>
            <select name=""ProcesadorID"" id=""cboProcesador"" class=""form-control"">
                <option selected>---SELECCIONE---</option>
");
#nullable restore
#line 73 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                 foreach (var item in Model.ListadoProcesador)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 3354, "\"", 3370, 1);
#nullable restore
#line 75 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
WriteAttributeValue("", 3362, item.Id, 3362, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                                        Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 76 "C:\Users\Personal\source\repos\Personalizado\Device\DEVICE\DEVICE.Web\Areas\Equipo\Views\Registro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>
    <div id=""divIP"" style=""display:none"" class=""form-row"">
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">IP</label>
            <input type=""text"" name=""IP"" class=""form-control"" id=""txtIP"" placeholder=""Ingrese la dirección IP"">
        </div>
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">Usuario IP</label>
            <input type=""text"" name=""Usuario"" class=""form-control"" id=""txtUsuario"" placeholder=""Ingrese el Usuario IP"">
        </div>
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">Password IP</label>
            <input type=""text"" name=""Password"" class=""form-control"" id=""txtPassword"" placeholder=""Ingrese el Password IP"">
        </div>

    </div>

    <div id=""divSSID"" style=""display:none"" class=""form-row"">
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">SSID Nombre</label>
            <input type=""text"" name");
            WriteLiteral(@"=""SSIDNombre"" class=""form-control"" id=""txtSSIDNombre"" placeholder=""Ingrese la dirección IP"">
        </div>
        <div class=""form-group col-md-4"">
            <label for=""inputEmail4"">SSID Password</label>
            <input type=""text"" name=""SSIDPassword"" class=""form-control"" id=""txtSSIDPassword"" placeholder=""Ingrese el Usuario IP"">
        </div>
       

    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-12"">
            <label for=""inputEmail4"">Comentarios</label>
            <input type=""hidden"" id=""hidIDProducto"" value=""-1"" />
");
            WriteLiteral(@"            <textarea name=""Comentario"" class=""form-control"" id=""txtDescripcion"" cols=""40"" rows=""3""></textarea>

        </div>

    </div>
    <div class=""d-flex justify-content-center"">
        <button type=""button"" id=""btnGuardar"" class=""btn btn-success btn-lg mr-5"">Guardar</button>
        <button type=""reset"" class=""btn btn-danger btn-sm"">Cancelar</button>
    </div>

</form>

<hr />

<div id=""divListado"">

</div>



<script>


    $('#cboTipoProducto').on('change', function () {

        //1	Desktop	True	    1
        //2	Laptop	True	    1
        //3	Impresora	True	2
        //4	Cámara	True	    3
        //5	Servidores	True	1
        //6	Fortinet	True	4
        //7	TP - Link	True	5
        //8	Handheld	True	6

        let idTipoProducto = $(this).val();
        //alert(idTipoProducto);

        switch (idTipoProducto) {
            case ""1"":
                $('#divIP').css('display', 'inline');
                $('#divSSID').css('display', 'none');
              ");
            WriteLiteral(@"  $('#divNumeroSerie').css('display', 'none');
                $('#divNumeroProducto').css('display', 'none');
                break;
            case ""2"":
                $('#divIP').css('display', 'inline');
                $('#divSSID').css('display', 'none');
                $('#divNumeroSerie').css('display', 'none');
                $('#divNumeroProducto').css('display', 'none');
                break;
            case ""3"":
                $('#divIP').css('display', 'inline');               
                $('#divSSID').css('display', 'none');
                $('#divNumeroSerie').css('display', 'none');
                $('#divNumeroProducto').css('display', 'none');
                break;
            case ""7"":
                $('#divIP').css('display', 'inline');               
                $('#divSSID').css('display', 'inline');
                $('#divNumeroSerie').css('display', 'inline');
                $('#divNumeroProducto').css('display', 'none');
                break;
 ");
            WriteLiteral(@"           case 7:
                // code block
                break;
            case 7:
                // code block
                break;
            default:
            // code block
        }
        //if (idTipoProducto == 3 || idTipoProducto == 7) {
        //    $('#divIP').css('display', 'inline');
        //} else {
        //    $('#divIP').css('display', 'none');
        //}
    });



    CargarProductos()
    function CargarProductos() {
        //alert(baseUrl);
        $.ajax({
            type: ""GET"",
            url: ""/Equipo/Registro/Listado"",
            cache: false,
            success: function (dataHtml) {
                $(""#divListado"").html(dataHtml);
                //$(""#divListadoEmpresa #tbEmpresa"").DataTable();
            }
        });
    }



    $(""#btnGuardar"").click(function () {
        let vIDProducto = $(""#hidIDProducto"").val();
        let vDescripcion = $(""#txtDescripcion"").val();
        let vTipoProductoID = $(""#cboTipoProd");
            WriteLiteral(@"ucto"").val();
        let vNumeroSerie = $(""#txtNroSerie"").val();
        let vNumeroProducto = $(""#txtNroProducto"").val();
        let vMemoriaRam = $(""#cboMemoriaRam"").val();
        let vModeloSistema = $(""#txtModeloSistema"").val();
        let vSistemaOperativoID = $(""#cboSistemaOperativo"").val();
        let vFabricanteID = $(""#cboFabricante"").val();
        let vProcesadorID = $(""#cboProcesador"").val();

        var objProducto = JSON.stringify({
            ID: (vIDProducto == -1 ? 0 : vIDProducto),
            ProductoNombre: vDescripcion,
            TipoProductoID: vTipoProductoID,
            NumeroSerie: vNumeroSerie,
            NumeroProducto: vNumeroProducto,
            MemoriaRam: vMemoriaRam,
            ModeloSistema: vModeloSistema,
            SistemaOperativoID: vSistemaOperativoID,
            FabricanteID: vFabricanteID,
            ProcesadorID: vProcesadorID

        });


        var dataType = 'application/json; charset=utf-8';

        $.ajax({
         ");
            WriteLiteral(@"   type: 'POST',
            url: '/Equipo/Registro/Index',
            dataType: 'json',
            contentType: dataType,
            data: objProducto,
            success: function (exito) {
                if (exito) {
                    alert(""Se registró correctamente!"")
                    CargarProductos();
                    //$(""#modalRegistroEmpresa"").modal(""toggle"");
                    //limpiarControles();
                } else {
                    alert(""Ocurrió un error en la transacción"")
                }
            }
        });
    });



    $(""#divListado"").on('click', '.btnEliminarProducto', function () {
        let vIdProducto = $(this).attr('data-id');

        $.ajax({
            type: ""POST"",
            url: '/Equipo/Registro/Eliminar',
            data: { id: vIdProducto },
            cache: false,
            success: function (exito) {
                if (exito) {
                    alert(""La Empresa fue eliminada exitosamente."");
      ");
            WriteLiteral(@"              CargarProductos();
                } else {
                    alert(""Ocurrió un error en la transacción"");
                }
            }
        });


    });

    $(""#divListado"").on('click', '.btnEditarProducto', function () {
        //LimpiarControles();
        let vIdProducto = $(this).attr('data-id');
        $(""#hidIDProducto"").val(vIdProducto);

        $.ajax({
            type: ""GET"",
            url: ""/Equipo/Registro/Obtener"",
            data: { id: vIdProducto },
            cache: false,
            success: function (objProducto) {
                console.log(objProducto);
                $(""#hidIDProducto"").val(objProducto.id);
                $(""#txtDescripcion"").val(objProducto.productoNombre);
                $(""#cboTipoProducto"").val(objProducto.tipoProductoId);
                $(""#txtNroSerie"").val(objProducto.numeroSerie);
                $(""#txtNroProducto"").val(objProducto.numeroProducto);
                $(""#cboMemoriaRam"").val(objProduct");
            WriteLiteral(@"o.memoriaRam);
                $(""#txtModeloSistema"").val(objProducto.modeloSistema);
                $(""#cboSistemaOperativo"").val(objProducto.sistemaOperativoId);
                $(""#cboFabricante"").val(objProducto.fabricanteId);
                $(""#cboProcesador"").val(objProducto.procesadorId);

            }
        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DEVICE.Web.ViewModels.RegistroEquipoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591