var stockValidar;

$(document).ready(function () {


    BuscarCarrito_Ws();

    //obtiene url para validar que existan querystring
    var url = new URL(window.location.href);

    if (url.searchParams.get('ID')) {

        BuscarStock();
    } else {


    }

});


function AbrirModalCarrito() {

    $('#ModalCarrito').modal('toggle');
    $('#ModalCarrito').modal('show');
    //$('#ModalCarrito').modal('hide');


}

function CerrarModalCarrito() {
    $('#ModalCarrito').modal('hide');
}


function EnviarEmailContacto() {

    var Email = $('#TxtEmailContacto').val();


    var par = "{\"Email\":\"" + Email + "\"}";


    var payload = {
        cadena: par
    };


    $.ajax({
        type: "POST",
        url: "frmInicio.aspx/EnviarEmailContacto_Ws",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {


            var json = $.parseJSON(data.d);
            var status = json.Status;



            if (status == 200) {


                //swal({
                //    backdrop: true,
                //    allowOutsideClick: false,
                //    title: 'Email enviado con Éxito!!',
                //    text: 'Pronto seras respondido/a',
                //    type: 'success',
                //    confirmButtonText: 'CONTINUAR',
                //}).then(function () {
                //    window.location = "frmDetalleProducto.aspx?ID=" + ID_Item;
                //})

                swal("Email enviado con Éxito!!", "Pronto seras respondido/a", "success");


            } else if (status == 401) {




                swal.close();


                swal("ERROR", "No se pudo enviar la consulta", "warning");


            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);


        },
        beforeSend: function () {



            $("#btnEnviarEmailContacto").hide();
            $("#btnEnviarEmailContactoGif").show();



        },
        complete: function () {


            $("#btnEnviarEmailContacto").show();
            $("#btnEnviarEmailContactoGif").hide();



        }
    })
}


function BuscarCarrito_Ws() {

    $.ajax({
        type: "POST",
        url: "frmDetalleProducto.aspx/BuscarCarrito_Ws",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {


            var json = $.parseJSON(data.d);
            var status = json.Status;



            if (status == 200) {

                $("#GrillaCarrito").empty();
                for (var x = 0; x < json.Carrito.length; x++) {
                    $("#GrillaCarrito").append(" <tr ><th style='vertical-align: middle;'>" + json.Carrito[x].Descripcion + "</th><td><img style='height:80px; width:80px; object-fit:cover; border-radius:50%;' src='" + json.Carrito[x].Imagen + "'</></td><td style='vertical-align: middle;'>" + json.Carrito[x].Cantidad + "</td><td style='text-align:right; vertical-align: middle;'>" + json.Carrito[x].Precio + "</td><td style='text-align:right; vertical-align: middle;'>" + json.Carrito[x].Total + "</td><td><span onclick='ValidarEliminarItem(" + json.Carrito[x].ID_Carrito + "," + '"' + json.Carrito[x].Descripcion + '"' + ")' aria-hidden='true' class='EliminarItem'>&times;</span></td></tr>")
                };


                $("#TxtTotalGeneral").html(json.TotalGeneral);

            } else if (status == 401) {







                //swal("ERROR", "No se pudo enviar la consulta", "warning");


            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);


        },
        beforeSend: function () {





        },
        complete: function () {




        }
    })
}



function EliminarCarrito() {

    $.ajax({
        type: "POST",
        url: "frmDetalleProducto.aspx/EliminarTodoCarrito_Ws",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {


            var json = $.parseJSON(data.d);
            var status = json.Status;



            if (status == 200) {

                BuscarCarrito_Ws();
            } else if (status == 401) {







                //swal("ERROR", "No se pudo enviar la consulta", "warning");


            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);


        },
        beforeSend: function () {



            $("#ModalBodyGifCarrito").show();
            $("#ModalBodyCarrito").hide();


        },
        complete: function () {

            $("#ModalBodyGifCarrito").hide();
            $("#ModalBodyCarrito").show();


        }
    })

}


function ValidarAgregarCarrito() {
    swal({
        title: "¿Estas seguro/a de Agregar al Carrito?",
        type: "question",
        showCancelButton: true,
        cancelButtonText: 'CANCELAR',
        reverseButtons: true,
        confirmButtonText: 'ACEPTAR',
        confirmButtonColor: '#39b2c7',
        closeOnConfirm: false,
        showLoaderOnConfirm: true,
        allowOutsideClick: false,
        preConfirm: function () {

            AgregarAlCarrito();

        }
    });
}


function ValidarEliminarItem(id, item) {
    swal({
        title: "¿Estas seguro/a de Eliminar <b>" + item + "</b> del Carrito?",
        type: "question",
        showCancelButton: true,
        cancelButtonText: 'CANCELAR',
        reverseButtons: true,
        confirmButtonText: 'ACEPTAR',
        confirmButtonColor: '#39b2c7',
        closeOnConfirm: false,
        showLoaderOnConfirm: true,
        allowOutsideClick: false,
        preConfirm: function () {

            EliminarItem(id);

        }
    });
}


function EliminarItem(id_carrito) {


    var par = { ID_Carrito: id_carrito };
    var payload = { cadena: JSON.stringify(par) };





    $.ajax({
        type: "POST",
        "url": "frmDetalleProducto.aspx/EliminarItemCarrito_Ws",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                BuscarCarrito_Ws();


            } else {
                (status == 400)

                // alert('Error');
            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);

        },
        beforeSend: function () {

            $("#ModalBodyGifCarrito").show();
            $("#ModalBodyCarrito").hide();



            //$('#ImagenloaderM').show();
        },
        complete: function () {
            swal.close();
            // AbrirModalCarrito();

            $("#ModalBodyGifCarrito").hide();
            $("#ModalBodyCarrito").show();

        }
    })


}

function ValidarEliminarTodo() {
    swal({
        title: "¿Estas seguro/a de Eliminar todos los productos del Carrito?",
        type: "question",
        showCancelButton: true,
        cancelButtonText: 'CANCELAR',
        reverseButtons: true,
        confirmButtonText: 'ACEPTAR',
        confirmButtonColor: '#39b2c7',
        closeOnConfirm: false,
        showLoaderOnConfirm: true,
        allowOutsideClick: false,
        preConfirm: function () {

            EliminarCarrito();

        }
    });
}


function AgregarAlCarrito() {
    var urlParams = new URLSearchParams(window.location.search);
    var ID_Item_ = urlParams.get('ID');

    var CantidadSeleccionada = $("#TxtCantidad").val();
    var Imagen_ = $("#TxtImagenUrl").html();

    var par = { ID_Item: ID_Item_, Cantidad: CantidadSeleccionada, Imagen: Imagen_ };
    var payload = { cadena: JSON.stringify(par) };





    $.ajax({
        type: "POST",
        "url": "frmDetalleProducto.aspx/AgregarCarrito_Ws",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {


                $("#GrillaCarrito").empty();

                for (var x = 0; x < json.Carrito.length; x++) {
                    $("#GrillaCarrito").append(" <tr ><th style='vertical-align: middle;'>" + json.Carrito[x].Descripcion + "</th><td><img style='height:80px; width:80px; object-fit:cover; border-radius:50%;' src='" + json.Carrito[x].Imagen + "'</></td><td style='vertical-align: middle;'>" + json.Carrito[x].Cantidad + "</td><td style='text-align:right; vertical-align: middle;'>" + json.Carrito[x].Precio + "</td><td style='text-align:right; vertical-align: middle;'>" + json.Carrito[x].Total + "</td><td><span onclick='ValidarEliminarItem(" + json.Carrito[x].ID_Carrito + "," + '"' + json.Carrito[x].Descripcion + '"' + ")' aria-hidden='true' class='EliminarItem'>&times;</span></td></tr>")
                };



                $("#TxtTotalGeneral").html(json.TotalGeneral);


            } else {
                (status == 400)

                // alert('Error');
            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);

        },
        beforeSend: function () {

            //$("#ModalBodyGifCarrito").show();
            //$("#ModalBodyCarrito").hide();



            //$('#ImagenloaderM').show();
        },
        complete: function () {
            swal.close();
            AbrirModalCarrito();

            //$("#ModalBodyGifCarrito").hide();
            //$("#ModalBodyCarrito").show();

        }
    })



}


function ValidarTotalClick() {


    var CantidadSeleccionada = $("#TxtCantidad").val();

    if (CantidadSeleccionada > stockValidar) {
        $("#TxtCantidad").val(stockValidar);
    } else if (CantidadSeleccionada < 0) {
        $("#TxtCantidad").val(1);
    } else if (CantidadSeleccionada == 0) {
        $("#TxtCantidad").val(1);
    }

    CalcularTotal();

}


function CalcularTotal() {

    var CantidadSeleccionada = $("#TxtCantidad").val();
    var PrecioCalculo = $("#TxtPrecioCalculo").html();

    PrecioCalculo = PrecioCalculo.replace(',', '.');


    var Total;



    Total = CantidadSeleccionada * parseFloat(PrecioCalculo);



    $("#TxtPrecio").html('$ ' + Total.toFixed(2));





}

function BuscarStock() {

    var urlParams = new URLSearchParams(window.location.search);
    var ID_Item_ = urlParams.get('ID');


    var par = { ID_Item: ID_Item_ };
    var payload = { cadena: JSON.stringify(par) };




    $.ajax({
        type: "POST",
        "url": "frmDetalleProducto.aspx/BuscarStock_Ws",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {



                var Stock = json.Data;


                stockValidar = Stock;

                $("#TxtCantidad").attr({
                    "max": parseInt(Stock),
                    "min": 1
                });






            } else {
                (status == 400)

                // alert('Error');
            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);

        },
        beforeSend: function () {




            //$('#ImagenloaderM').show();
        },
        complete: function () {



            $(".se-pre-con").fadeOut("slow");;

        }
    })



}

function ClickBusqueda() {

    var busqueda = $('#TxtBusquedaGenerica').val();
    window.location = "frmBusquedaItems.aspx?Busqueda=" + busqueda;
}


function ValidarFinalizarCompra() {
    swal({
        title: "¿Estas seguro/a de finalizar la compra?",
        type: "question",
        showCancelButton: true,
        cancelButtonText: 'CANCELAR',
        reverseButtons: true,
        confirmButtonText: 'ACEPTAR',
        confirmButtonColor: '#39b2c7',
        closeOnConfirm: false,
        showLoaderOnConfirm: true,
        allowOutsideClick: false,
        preConfirm: function () {

            FinalizarCompra();

        }
    });
}


function EnviarConsulta() {



    var RazonSocial = $('#TxtNombre').val();
    var Email = $('#TxtEmail').val();

    var Mensaje = $('#TxtMensaje').val();
    var Telefono = $('#TxtTelefono').val();


    var urlParams = new URLSearchParams(window.location.search);
    var ID_Item = urlParams.get('ID');



    var par = "{\"RazonSocial\":\"" + RazonSocial + "\"" + ",\"Email\":\"" + Email + "\"" + ",\"Mensaje\":\"" + Mensaje + "\"" + ",\"ID_Item\":\"" + ID_Item + "\"" + ",\"Telefono\":\"" + Telefono + "\"}";


    var payload = { cadena: par };





    $.ajax({
        type: "POST",
        url: "frmDetalleProducto.aspx/Consulta_Enviar_Ws",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {


            var json = $.parseJSON(data.d);
            var status = json.Status;



            if (status == 200) {


                swal({
                    backdrop: true,
                    allowOutsideClick: false,
                    title: 'Consulta enviada con Éxito!!',
                    text: 'Pronto seras contactado/a',
                    type: 'success',
                    confirmButtonText: 'CONTINUAR',
                }).then(function () {
                    window.location = "frmDetalleProducto.aspx?ID=" + ID_Item;
                })



            } else if (status == 401) {




                swal.close();


                swal("ERROR", "No se pudo enviar la consulta", "warning");


            }


        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);


        },
        beforeSend: function () {


            $("#ModalBodyGif").show();
            $("#ModalBody").hide();

        },
        complete: function () {

            $("#ModalBodyGif").hide();
            $("#ModalBody").show();


        }
    })






}
