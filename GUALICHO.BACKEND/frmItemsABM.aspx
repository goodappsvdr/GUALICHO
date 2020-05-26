<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmItemsABM.aspx.vb" Inherits="GUALICHO.BACKEND.frmItemsABM" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">
    <link rel="shortcut icon" href="Imagenes/favicon.png">
    <title>Gualicho - Backend</title>
    <!--Morris Chart CSS -->
    <link rel="stylesheet" href="assets/plugins/morris/morris.css">
    <!-- App css -->
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/core.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/components.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/pages.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/menu.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/responsive.css" rel="stylesheet" type="text/css" />
    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->
    <script src="assets/js/modernizr.min.js"></script>
    <link href="css/wowCss.css" rel="stylesheet" type="text/css" />
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            //Initialize tooltips
            $('.nav-tabs > li a[title]').tooltip();

            //Wizard
            $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {

                var $target = $(e.target);

                if ($target.parent().hasClass('disabled')) {
                    return false;
                }
            });

            $(".next-step").click(function (e) {

                var $active = $('.wizard .nav-tabs li.active');
                $active.next().removeClass('disabled');
                nextTab($active);

            });
            $(".prev-step").click(function (e) {

                var $active = $('.wizard .nav-tabs li.active');
                prevTab($active);

            });
        });

        function nextTab(elem) {
            $(elem).next().find('a[data-toggle="tab"]').click();
        }
        function prevTab(elem) {
            $(elem).prev().find('a[data-toggle="tab"]').click();
        }
    </script>


 



</head>
<style>
    
     /* Paste this css to your style sheet file or under head tag */
/* This only works with JavaScript, 
if it's not present, don't show loader */
.no-js #loader { display: none;  }
.js #loader { display: block; position: absolute; left: 100px; top: 0; }
.se-pre-con {
	position: fixed;
	left: 0px;
	top: 0px;
	width: 100%;
	height: 100%;
	z-index: 9999;
	background: url(https://gifimage.net/wp-content/uploads/2018/11/loading-gif-white-3.gif) center no-repeat #fff;
	 background-size:100px 100px;
}
    
 #FondoProgeso {
  width: 100%; height: 100%; min-height:100%; 
  background: white;
    
     overflow: hidden;
    position: absolute;
    z-index:999;
     top: 0;
    right: 0;
    bottom: 0;
    left: 0;"
}

 .StatusModal
      {
          
     background:white;  
      box-shadow: 0 10px 20px rgba(0,0,0,0.19), 0 6px 6px rgba(0,0,0,0.23);
  height:300px; 
    width:100%; 
    max-width:300px; 
    border-radius:15px; 
    padding: 15px  15px 15px 15px;
       margin-top:250px;
        } 
        
        
        .icon-list-demo .col-md-4:hover {
     background-color: transparent;
}


input[type=checkbox], input[type=radio] {
    margin: 11px 0 0;
    margin-top: 1px\9;
    line-height: normal;
    cursor:pointer;
}



.BigCheckBox input
        {
            width: 24px;
            height: 24px;
            vertical-align: middle !important;
            -webkit-appearance: none;
  -moz-appearance: none;
  background: lightgray;
  appearance: none;
    border:1px solid #000;
        }
        
        .BigCheckBox input[type=checkbox]:checked + label
        {
            color: #000 !important;
            
        }
        
      
      input[type="checkbox"]:checked {
  background: #000;
  
}

input[type="checkbox"]:hover {
  filter: brightness(90%);
}



input[type="checkbox"]:disabled {
  background: #e6e6e6;
  opacity: 0.6;
  
  pointer-events: none;
  
}

input[type="checkbox"]:after {
  content: '';
  position: relative;
  
  left: 40%;
  top: 16%;
  width: 25%;
  height: 50%;
  border: solid #fff;
  border-width: 0 2px 2px 0;
  transform: rotate(45deg);
  display: none;
}

input[type="checkbox"]:checked:after {
  display: block;
  
}

input[type="checkbox"]:disabled:after {
  border-color: #7b7b7b;
 
}

.Status
{  width: 100%;
    height: 100%;
     min-height:100%; 
background-color:rgba(0, 0, 0, 0.5);
    
     overflow: hidden;
    position: absolute;
    z-index:99999;
     top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    }
      
      .wizard {
    margin: 20px auto;
    background: #fff;
}

    .wizard .nav-tabs {
        position: relative;
        margin: 40px auto;
        margin-bottom: 0;
        border-bottom-color: #000;
    }

    .wizard > div.wizard-inner {
        position: relative;
    }

.connecting-line {
    height: 2px;
    background: #000;
    position: absolute;
    width: 80%;
    margin: 0 auto;
    left: 0;
    right: 0;
    top: 50%;
    z-index: 1;
}

.wizard .nav-tabs > li.active > a, .wizard .nav-tabs > li.active > a:hover, .wizard .nav-tabs > li.active > a:focus {
    color: #555555;
    cursor: default;
    border: 0;
    border-bottom-color: transparent;
}

span.round-tab {
    width: 70px;
    height: 70px;
    line-height: 70px;
    display: inline-block;
    border-radius: 100px;
    background: #fff;
    border: 2px solid #e0e0e0;
    z-index: 2;
    position: absolute;
    left: 0;
    text-align: center;
    font-size: 25px;
}
span.round-tab i{
    color:#555555;
}
.wizard li.active span.round-tab {
    background: #fff;
    border: 2px solid #000;
    
}
.wizard li.active span.round-tab i{
    color: #000;
}

span.round-tab:hover {
    color: #333;
    border: 2px solid #333;
}

.wizard .nav-tabs > li {
    width: 25%;
}

.wizard li:after {
    content: " ";
    position: absolute;
    left: 46%;
    opacity: 0;
    margin: 0 auto;
    bottom: 0px;
    border: 5px solid transparent;
    border-bottom-color: #000;
    transition: 0.1s ease-in-out;
}

.wizard li.active:after {
    content: " ";
    position: absolute;
    left: 46%;
    opacity: 1;
    margin: 0 auto;
    bottom: 0px;
    border: 10px solid transparent;
    border-bottom-color: #000;
}

.wizard .nav-tabs > li a {
    width: 70px;
    height: 70px;
    margin: 20px auto;
    border-radius: 100%;
    padding: 0;
}

    .wizard .nav-tabs > li a:hover {
        background: transparent;
    }

.wizard .tab-pane {
    position: relative;
    padding-top: 10px;
}

.wizard h3 {
    margin-top: 0;
}

@media( max-width : 585px ) {

    .wizard {
        width: 90%;
        height: auto !important;
    }

    span.round-tab {
        font-size: 16px;
        width: 50px;
        height: 50px;
        line-height: 50px;
    }

    .wizard .nav-tabs > li a {
        width: 50px;
        height: 50px;
        line-height: 50px;
    }

    .wizard li.active:after {
        content: " ";
        position: absolute;
        left: 35%;
    }
}

.tab-content {
    padding: 20px;
    border: 2px solid #000;
    border-top: none;
}



	     .radioButtonList input[type="radio"] {
     -ms-transform: scale(1.5); /* IE 9 */
    -webkit-transform: scale(1.5); /* Chrome, Safari, Opera */
    transform: scale(1.5);
}

 /*estilos del menu*/
#sidebar-menu ul ul li.active a {
  color: #fff;
}
#sidebar-menu ul ul a {
  color: #838F9A;
  -webkit-transition: all 0.3s ease-out;
  -moz-transition: all 0.3s ease-out;
  -o-transition: all 0.3s ease-out;
  -ms-transition: all 0.3s ease-out;
  transition: all 0.3s ease-out;
  border-left: 3px solid transparent;
  display: block;
  padding: 10px 20px 10px 65px;
}
#sidebar-menu ul ul a:hover {
  color: #ffffff;
}
#sidebar-menu ul ul a i {
  margin-right: 5px;
}
#sidebar-menu ul ul ul a {
  padding-left: 80px;
}
#sidebar-menu .label {
  margin-top: 2px;
}
#sidebar-menu .subdrop {
  border-left: 3px solid #fff;
  color: #fff !important;
}
#sidebar-menu > ul > li > a {
  color: #838F9A;
  display: block;
  padding: 12px 20px;
  margin: 4px 0px;
  border-left: 3px solid transparent;
}
#sidebar-menu > ul > li > a:hover {
  color: #fff;
  text-decoration: none;
}
#sidebar-menu > ul > li > a > span {
  vertical-align: middle;
}
#sidebar-menu ul li a i {
  display: inline-block;
  font-size: 16px;
  line-height: 17px;
  margin-left: 3px;
  margin-right: 15px;
  text-align: center;
  vertical-align: middle;
  width: 20px;
}
#sidebar-menu ul li a i.md {
  font-size: 18px;
}
#sidebar-menu ul li a .drop-arrow {
  float: right;
}
#sidebar-menu ul li a .drop-arrow i {
  margin-right: 0px;
}
#sidebar-menu > ul > li > a.active {
  border-left: 3px solid #fff;
  color: #fff !important;
}

</style>
<body class="fixed-left">
    <div class="se-pre-con">
    </div>
    <form id="form1" runat="server">
    <div class="Status" id="DivStatus" runat="server" visible="false">
        <div class="wow zoomIn">
            <center>
                <div class="StatusModal">
                    <img src="Imagenes/cerrar.png" onclick="CerrarStatus()" style="cursor: pointer; height: 20px;
                        float: right;" />
                    <br />
                    <br />
                    <span id="TituloStatusSpan" style="font-size: 25px;" runat="server"></span>
                    <br />
                    <br />
                    <img src="" runat="server" id="ImagenStatus" style="height: 80px;" />
                </div>
            </center>
        </div>
    </div>
   
    


            <!-- Begin page -->
            <div id="wrapper">
                <!-- Top Bar Start -->
                <div class="topbar">
                    <!-- LOGO -->
                    <div class="topbar-left" style="background:#000; border-top-color:#000;">
                    </div>
                    <!-- Button mobile view to collapse sidebar menu -->
                    <div class="navbar navbar-default" style="border-top-color:#000;" role="navigation">
                        <div class="container">
                            <!-- Page title -->
                            <ul class="nav navbar-nav navbar-left">
                                <li>
                                    <button class="button-menu-mobile open-left">
                                        <i class="zmdi zmdi-menu"></i>
                                    </button>
                                </li>
                                <li>
                                    <h4 runat="server" id="lblTitulo" class="page-title">
                                    </h4>
                                </li>
                            </ul>
                            <!-- Right(Notification and Searchbox -->
                        </div>
                        <!-- end container -->
                    </div>
                    <!-- end navbar -->
                </div>
                <!-- Top Bar End -->
                <!-- ========== Left Sidebar Start ========== -->
                <div class="left side-menu" style="background:#000;">
                    <div class="sidebar-inner slimscrollleft">
                        <!-- User -->
                        <div class="user-box" style="padding: 10px 10px 0px 10px;">
                            <div style="padding: 15px; -webkit-filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5));
                                background: white;">
                                <a href="frmInicio.aspx">
                                    <img style="height: 55px;" src="Imagenes/logo.png" /></a>
                                <br />
                                <br />
                                <asp:Label ID="lblUsuario" Style="color: #000000;" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                        <!-- End User -->
                        <!--- Sidemenu -->
      <div id="sidebar-menu">
                    <ul>
                        <br />
                        <br />
                        <li class="text-muted menu-title">Menú Principal</li>



                           <li id="Men_QuienesSomos" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Quienes Somos</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="FrmQuienesSomos.aspx">Editar Quienes Somos</a></li>
                            </ul>
                        </li>

                        <li id="Men_Nosotros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>La Fábrica</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="FrmNosotros.aspx">Editar Fábrica</a></li>
                            </ul>
                        </li>
                          <li id="Men_Servicios" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Servicios</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                    <li><a href="frmServiciosABM.aspx">Nuevo Servicio</a></li>
                                <li><a href="frmServicios.aspx">Editar Servicio</a></li>
                            </ul>
                        </li>


                        <li id="Men_Banners" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Sliders</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmBannersABM.aspx">Nuevo Slider</a></li>
                                <li><a href="frmBanners.aspx">Editar Sliders</a></li>
                            </ul>
                        </li>

                           <li id="Men_Sponsors" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Sponsors</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmSponsorABM.aspx">Nuevo Sponsor</a></li>
                                <li><a href="frmSponsors.aspx">Editar Sponsor</a></li>
                            </ul>
                        </li>



                        <li id="men_Marcas" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Marcas</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmMarcasABM.aspx">Nueva marca</a></li>
                                <li><a href="frmMarcas.aspx">Editar Marcas</a></li>
                            </ul>
                        </li>
                        <li id="men_Rubros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Rubros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmRubrosABM.aspx">Nuevo Rubro</a></li>
                                <li><a href="frmRubros.aspx">Editar Rubros</a></li>
                            </ul>
                        </li>
                        <li id="men_SubRubros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>SubRubros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmSubRubrosABM.aspx">Nuevo SubRubro</a></li>
                                <li><a href="frmSubRubros.aspx">Editar SubRubros</a></li>
                            </ul>
                        </li>
                        <li id="Men_Item" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Items</span><span class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemsABM.aspx">Nuevo Item</a></li>
                                <li><a href="frmItems.aspx">Editar Items</a></li>
                            </ul>
                        </li>
                        <li id="Men_ItemImagen" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Imagenes Items</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemImagenes.aspx">Agregar Imágenes</a></li>
                            </ul>
                        </li>
                        <li id="men_Consultas" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Consultas</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmConsultas.aspx">Ver Consultas</a></li>
                            </ul>
                        </li>
                         <li id="men_Contacto" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Contacto</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmConsultas.aspx">Ver Contacto</a></li>
                            </ul>
                        </li>

                        
                        <li id="men_CambiarPass" visible="false" runat="server"><a href="frmCambiarPass.aspx"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-refresh"></i><span>Cambiar Contraseña </span>
                        </a></li>
                        <li id="men_CerrarSesion" visible="false" runat="server"><a onserverclick="CerrarSesion"
                            runat="server" class="waves-effect" style="background:#000;"><i class="zmdi zmdi-lock"></i><span>Cerrar Sesión
                            </span></a></li>
                    </ul>
                    <div class="clearfix">
                    </div>
                </div>
                        <!-- Sidebar -->
                        <div class="clearfix">
                        </div>
                    </div>
                </div>
                <!-- Left Sidebar End -->
                <!-- ============================================================== -->
                <!-- Start right Content here -->
                <!-- ============================================================== -->
                 <asp:ScriptManager ID="ScriptManager1"  runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1"  runat="server">
        <Triggers>
   <asp:PostBackTrigger ControlID="BtnAceptar" />
</Triggers>
        <ContentTemplate>
                <div class="content-page">
                    <!-- Start content -->
                    <div class="content">
                        <div class="content">
                            <div class="container">
                                <div class="row" runat="server" id="PanelControles">
                                    <div class="col-lg-12">
                                        <div class="card-box">
                                            <section>
        <div class="wizard">
            <div class="wizard-inner">
                <div class="connecting-line"></div>
                <ul class="nav nav-tabs" role="tablist">

                    <li role="presentation" class="active">
                        <a href="#step1" data-toggle="tab" aria-controls="step1" role="tab" title="Paso 1">
                            <span class="round-tab">
                                <i class="glyphicon glyphicon-pencil" style=" margin-top:17px;"></i>
                            </span>
                        </a>
                    </li>

                    <li role="presentation" class="disabled">
                        <a href="#step2" data-toggle="tab" aria-controls="step2" role="tab" title="Paso 2">
                            <span class="round-tab">
                                <i class="glyphicon glyphicon-usd" style=" margin-top:17px;"></i>
                            </span>
                        </a>
                    </li>
                    <li role="presentation" class="disabled">
                        <a href="#step3" data-toggle="tab" aria-controls="step3" role="tab" title="Paso 3">
                            <span class="round-tab">
                                <i class="glyphicon glyphicon-picture" style=" margin-top:17px;"></i>
                            </span>
                        </a>
                    </li>

                    <li role="presentation" class="disabled">
                        <a href="#complete" data-toggle="tab" aria-controls="complete" role="tab" title="Finalizar">
                            <span class="round-tab">
                                <i class="glyphicon glyphicon-ok" style=" margin-top:17px;"></i>
                            </span>
                        </a>
                    </li>
                </ul>
            </div>

            <form role="form" style="background:#000;">
                <div class="tab-content">
                    <asp:HiddenField ID="HfID_Item" runat="server"></asp:HiddenField>
                    
                    <div class="tab-pane active" role="tabpanel" id="step1">
                        <h3 style="color:#000;">PASO 1</h3>
                        
                         <div  class="form-group">
                                   <br />
                                   
                                          
                                       <div class="row">
                                      
                                       <div class="col col-md-6">
                                         <span style="color:#000; font-size:18px; "> Rubro</span>
                                               <asp:DropDownList class="form-control select2"  Height="50px" style=" width:100%;" 
                                               ID="CboRubro" runat="server" AppendDataBoundItems="True"
                                 AutoPostBack="true">
                            </asp:DropDownList>
                                       </div>

                                           <div class="col col-md-6">
                                         <span style="color:#000; font-size:18px; ">Sub Rubro</span>
                                               <asp:DropDownList class="form-control select2"  Height="50px" style=" width:100%;" 
                                               ID="CboSubRubro" runat="server" AppendDataBoundItems="True">
                            </asp:DropDownList>
                                       </div>


                                         


                                       </div>


                                       <div class="row">
                                      
                                      
                                         <div class="col col-md-6">
                                      <span style="color:#000; font-size:18px; ">Marca</span>
                                               <asp:DropDownList class="form-control select2"  Height="50px" style=" width:100%;" 
                                               ID="CboMarca" runat="server" AppendDataBoundItems="True">
                            </asp:DropDownList>
                                       </div>
                                    
                                
                                
                                <div class="col col-md-6">

  <span style="color:#000; font-size:18px; "> Nombre del Producto</span>
                                             <asp:TextBox ID="TxtDescripcion"  runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>



                                 
                                    
                                    
                                       </div>
                                
                                
                                    </div>
                                    
                                    
                                    
                                    
                                     <div class="row">

                                    <div class="col col-md-6">

  <span style="color:#000; font-size:18px; "> Descripción del Producto</span>
                                             <asp:TextBox ID="TxtDetalle"  runat="server"  ForeColor="Black"
                                                    class="form-control" textMode="MultiLine" Height="80px" Width="100%"></asp:TextBox>



                                 
                                    
                                    
                                       </div>
                                    
                                    <div class="col col-md-6">

  <span style="color:#000; font-size:18px; "> Observaciones Internas</span>
                                             <asp:TextBox ID="TxtObservaciones"  runat="server"  ForeColor="Black"
                                                    class="form-control" textMode="MultiLine" Height="80px"   Width="100%"></asp:TextBox>



                                 
                                    
                                    
                                       </div>
                                    
                                     </div>
                                    
                                    
                                    
                                    
                                    
                                    
                                    
                                       </div>















                        <ul class="list-inline pull-right">
                            <li><button runat="server" id="btnSiguiente1" type="button" style=" width:100%; min-width:220px; background:#000 !important; border: 1px solid #000 !important; border-radius: 2em; padding: 6px 18px;" class="btn btn-primary next-step">SIGUIENTE</button></li>

                        </ul>
                    </div>
                    
                    
                    
                    







                    <div class="tab-pane" role="tabpanel" id="step2">
                           <h3 style="color:#000;">PASO 2</h3>
                        
                         <div  class="form-group">
                                   <br />
                                   
                                          
                                       <div class="row">
                                      
                                      <div class="col col-md-6">

  <span style="color:#000; font-size:18px; "> Precio Sugerido</span>
                                             <asp:TextBox ID="TxtPrecio"  runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>



                                 
                                    
                                    
                                       </div>
                                      
                                      <div class="col col-md-6">

  <span style="          color: #000;
          font-size: 18px;
  "> Stock</span>
                                             <asp:TextBox ID="TxtStock"  runat="server"  ForeColor="Black"
                                                    class="form-control"  Height="50px" Width="100%"></asp:TextBox>



                                 
                                    
                                    
                                       </div>
                                      
                                       </div>
                                       <br />
                                       <div class="row">
                                       
                                       <div class="col col-md-12">

  <span style="color:#000; font-size:18px; "> Estado del Item</span>
                                            


                                             <asp:RadioButtonList ID="TipoItemRadioButon" RepeatDirection="Horizontal" CssClass="radioButtonList" runat="server" >
    <asp:ListItem style="color: White;  color:Red; font-size:16px;" Text="&nbsp;&nbsp;USADO"  Value="1" Selected="True"></asp:ListItem>
        <asp:ListItem style="color: White;  margin-left:40px; font-size:16px; color:Green; " Text="&nbsp;&nbsp;NUEVO" Value="2"></asp:ListItem>
</asp:RadioButtonList>

                                 
                                    
                                    
                                       </div>
                                       
                                       </div>
                                       
                                       
                                       
                                       
                                       
                                       
                                       
                                       
                                       </div>
                       
                       
                       
                       
                       
                       
                       
                        <ul class="list-inline pull-right">
                            <li><button type="button" class="btn btn-default prev-step" style=" width:100%; min-width:220px;  border-radius: 2em; padding: 6px 18px;" >ANTERIOR</button></li>

                            <li><button type="button" class="btn btn-primary next-step" style=" width:100%; min-width:220px; background:#000 !important; border: 1px solid #000 !important; border-radius: 2em; padding: 6px 18px;" >SIGUIENTE</button></li>
                        </ul>
                    </div>
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    <div class="tab-pane" role="tabpanel" id="step3">
                         <h3 style="color:#000;">PASO 3</h3>
                        
                         <div  class="form-group">
                                   <br />
                    


                    
                                         <div class="row">

                                             <div class="col col-md-4">
                                                   <br />
                                            <span style="color:#000; font-size:18px; ">Subir Imágen</span>
                                        
                                        <script type="text/javascript">
                                            function readURL(input) {
                                                if (input.files && input.files[0]) {
                                                    var reader = new FileReader();

                                                    reader.onload = function (e) {
                                                        $('#ImgItem')
                    .attr('src', e.target.result)
                    .width(220)
                    .height(220);
                                                    };

                                                    reader.readAsDataURL(input.files[0]);
                                                }
                                            }
                                        </script>
                                         <br />

                                    

                                    <div alt="Cargando Imagen..." style="background-image:url('Imagenes/subir.png');background-size: cover;   height:50px;width:50px;cursor:pointer;decoration:none;" required="" name="imagen" id="files" type="file" accept="image/*">
      <center> <asp:FileUpload style="background-image:url('Imagenes/ErrorTickets.png');background-size: cover; opacity: 0; height:80px;width:80px;cursor:pointer;margin-top:-5px;decoration:none;"  runat="server" id="btnSubirImg"  onchange="readURL(this);" runat="server"></asp:FileUpload></center></div>



                                                       

                                             </div>

                                                  
                                               <div class="col col-md-4">

                                                <br />
                                            <span style="color:#000; font-size:18px; ">Imágen del Item</span><br />
                                        <img src="" id="ImgItem" runat="server"  style=" width:220px;  height:220px;border: 8px solid #fff;
    box-shadow: 0px 0px 30px rgba(0, 0, 0, 0.2); object-fit:cover;" />


                                       </div>
                                  

                                  <div class="col col-md-4">

                                                <br />
 <span style="color:#000; font-size:18px; ">¿Activo?</span>
                                          <br />
                                     <asp:CheckBox CssClass="BigCheckBox" ID="chkActivo" runat="server"></asp:CheckBox>
                                     </div>
                                       
                                         </div>


                                          
                                          
                                          




                       
                       </div>
                       
                       
                       
                       
                       
                        <ul class="list-inline pull-right">
                            <li><button type="button" class="btn btn-default prev-step" style=" width:100%; min-width:220px;  border-radius: 2em; padding: 6px 18px;">ANTERIOR</button></li>
                          
                            <li><button type="button" class="btn btn-primary btn-info-full next-step" style=" width:100%; min-width:220px; background:#000 !important; border: 1px solid #000 !important; border-radius: 2em; padding: 6px 18px;">SIGUIENTE</button></li>
                        </ul>
                    </div>
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                    <div class="tab-pane" role="tabpanel" id="complete">
                   <h3 style="color:#000;">COMPLETADO</h3>
                   
                     <ul class="list-inline">
                    <li><button type="button" class="btn btn-default prev-step" style=" width:100%; min-width:220px;  border-radius: 2em; padding: 6px 18px;">ANTERIOR</button></li>
                    <li><asp:Button  runat="server" id="BtnAceptar"  style=" width:100%; min-width:220px; color:White; background:#000 !important; border: 1px solid #000 !important; border-radius: 2em; padding: 6px 18px;" runat="server" Text="GUARDAR Y SUBIR"></asp:Button></li>
                   
                      
                   
                    </ul>


                    </div>

                    <div class="clearfix"></div>
                </div>
            </form>
        </div>
    </section>
                                        </div>
                                    
                                    </div>
                                </div>

                                    <div class="row" runat="server" id="PanelVolver" visible="false">
                                            <div class="card-box" style="min-height: 200px;">
                                                <section class="icon-list-demo">
                      <div class="col col-md-12">


                                       <br />
                                       <center>
                                        <button type="button" style=" width:50%; background:#000 !important; border: 1px solid #000 !important;" id="btnVolver" runat="server" class="btn btn-success btn-rounded w-md waves-effect waves-light m-b-5">
                    VOLVER A ITEMS</button>


                    </center>
                                       </div>
                                       </section>
                                            </div>
                                        </div>
                                <!-- container -->
                            </div>
                            <!-- content -->
                            <footer class="footer text-right">
                     2019 - 2020 © GoodApps.
                </footer>
                        </div>
                        <!-- ============================================================== -->
                        <!-- End Right content here -->
                        <!-- ============================================================== -->
                        <!-- Right Sidebar -->
                        <!-- /Right-bar -->
                    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" runat="server">
        <ProgressTemplate>
            <div id="FondoProgeso">
                <img style="margin: 0; position: absolute; top: 50%; left: 50%; -ms-transform: translate(-50%, -50%);
                    transform: translate(-50%, -50%); height: 100px;" src="https://gifimage.net/wp-content/uploads/2018/04/loading-gif-orange-8.gif" />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    </form>
    <script type="text/javascript">
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_endRequest(function (s, e) {


            $(document).ready(function () {
                //Initialize tooltips
                $('.nav-tabs > li a[title]').tooltip();

                //Wizard
                $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {

                    var $target = $(e.target);

                    if ($target.parent().hasClass('disabled')) {
                        return false;
                    }
                });

                $(".next-step").click(function (e) {

                    var $active = $('.wizard .nav-tabs li.active');
                    $active.next().removeClass('disabled');
                    nextTab($active);

                });
                $(".prev-step").click(function (e) {

                    var $active = $('.wizard .nav-tabs li.active');
                    prevTab($active);

                });
            });

            function nextTab(elem) {
                $(elem).next().find('a[data-toggle="tab"]').click();
            }
            function prevTab(elem) {
                $(elem).prev().find('a[data-toggle="tab"]').click();
            }


        });
</script>
    <!-- END wrapper -->
    <script>
        var resizefunc = [];
    </script>
    <!-- jQuery  -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/detect.js"></script>
    <script src="assets/js/fastclick.js"></script>
    <script src="assets/js/jquery.blockUI.js"></script>
    <script src="assets/js/waves.js"></script>
    <script src="assets/js/jquery.nicescroll.js"></script>
    <script src="assets/js/jquery.slimscroll.js"></script>
    <script src="assets/js/jquery.scrollTo.min.js"></script>
    <!-- KNOB JS -->
    <!--[if IE]>
        <script type="text/javascript" src="assets/plugins/jquery-knob/excanvas.js"></script>
        <![endif]-->
    <script src="assets/plugins/jquery-knob/jquery.knob.js"></script>
    <!--Morris Chart-->
    <script src="assets/plugins/morris/morris.min.js"></script>
    <script src="assets/plugins/raphael/raphael-min.js"></script>
    <!-- Dashboard init -->
    <script src="assets/pages/jquery.dashboard.js"></script>
    <!-- App js -->
    <script src="assets/js/jquery.core.js"></script>
    <script src="assets/js/jquery.app.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {


            setTimeout(function () {
                document.getElementById("DivStatus").style.display = "none";
            }, 5000);

        });
    </script>
    <script>
        function CerrarStatus() {
            document.getElementById("DivStatus").style.display = "none";
        }
    </script>
    <script type="text/javascript">
        $(window).load(function () {
            // Animate loader off screen
            $(".se-pre-con").fadeOut("slow"); ;
        });
    </script>
    <script src="Scripts/wowJs.js" type="text/javascript"></script>
    <script>
        new WOW().init();
    </script>
</body>
</html>
