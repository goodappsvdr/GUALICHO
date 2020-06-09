<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInicio.aspx.vb" Inherits="GUALICHO.BACKEND.frmInicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">
    <!-- App Favicon -->
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
</head>
<style>
    /* Paste this css to your style sheet file or under head tag */
    /* This only works with JavaScript, 
if it's not present, don't show loader */
    .no-js #loader
    {
        display: none;
    }
    .js #loader
    {
        display: block;
        position: absolute;
        left: 100px;
        top: 0;
    }
    .se-pre-con
    {
        position: fixed;
        left: 0px;
        top: 0px;
        width: 100%;
        height: 100%;
        z-index: 9999;
        background: url(https://gifimage.net/wp-content/uploads/2018/11/loading-gif-white-3.gif) center no-repeat #fff;
        background-size: 100px 100px;
    }
    
    
    .wrap
    {
        margin-top: 20px;
        background: #000;
        /*background: linear-gradient(135deg,#ff822f 0%,#9f4000 100%);*/
        padding: 20px 20px 20px 20px;
        text-align: center;
        box-shadow: 0 10px 20px rgba(0,0,0,0.19), 0 6px 6px rgba(0,0,0,0.23);
        cursor: pointer;
      transition: transform .2s; /* Animation */
      position: relative;
    }



    .divPrueba{
          -moz-transition: all 0.3s;
  -webkit-transition: all 0.3s;
  transition: all 0.3s;
    }


    .divPrueba:hover
    {
       /* background: linear-gradient(135deg,#ff822f 0%,#9f4000 100%);*/
        color: white;
        cursor: pointer;
        -ms-transform: scale(1.2); /* IE 9 */
        -webkit-transform: scale(1.2); /* Safari 3-8 */
        transform: scale(1.2);
   
    }
    
    .card-box
    {
        padding: 20px;
        box-shadow: 0 0px 8px 0 rgba(0, 0, 0, 0.00), 0 1px 0px 0 rgba(0, 0, 0, 0.00);
        -webkit-border-radius: 5px;
        border-radius: 5px;
        -moz-border-radius: 5px;
        background-clip: padding-box;
        margin-bottom: 20px;
        background-color: transparent;
    }
    .table-responsive
    {
        min-height: .01%;
        overflow-x: auto;
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

<body class="fixed-left" >
    <div class="se-pre-con">
    </div>
    <!-- Begin page -->
    <div id="wrapper">
        <!-- Top Bar Start -->
        <div class="topbar">
            <!-- LOGO -->
            <div class="topbar-left" style="background-color:#000; border-top-color:#000;">
            </div>
            <!-- Button mobile view to collapse sidebar menu -->
            <div class="navbar navbar-default"  style="background-color:#000; border-top-color:#000;" role="navigation">
                <div class="container">
                    <!-- Page title -->
                    <ul class="nav navbar-nav navbar-left">
                        <li>
                            <button class="button-menu-mobile open-left">
                                <i class="zmdi zmdi-menu"></i>
                            </button>
                        </li>
                        <li>
                            <h4 class="page-title">
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
        <form runat="server">
        <div class="left side-menu" style="background-color:#000;">
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
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Quienes Somos</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="FrmQuienesSomos.aspx">Editar Quienes Somos</a></li>
                            </ul>
                        </li>

                        <li id="Men_Nosotros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>La Fábrica</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmNosotrosABM.aspx">Editar Fábrica</a></li>
                            </ul>
                        </li>

                        <li id="Men_Banners" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Portada</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmBannersABM.aspx">Nueva Portada</a></li>
                                <li><a href="frmBanners.aspx">Editar Portada</a></li>
                            </ul>
                        </li>

                           <li id="Men_Sponsors" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Sponsors</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmSponsorABM.aspx">Nuevo Sponsor</a></li>
                                <li><a href="frmSponsors.aspx">Editar Sponsor</a></li>
                            </ul>
                        </li>

                        <li id="men_Marcas" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Marcas</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmMarcasABM.aspx">Nueva Marca</a></li>
                                <li><a href="frmMarcas.aspx">Editar Marcas</a></li>
                            </ul>
                        </li>

                        <li id="men_Rubros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Rubros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmRubrosABM.aspx">Nuevo Rubro</a></li>
                                <li><a href="frmRubros.aspx">Editar Rubros</a></li>
                            </ul>
                        </li>

                        <li id="men_SubRubros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>SubRubros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmSubRubrosABM.aspx">Nuevo SubRubro</a></li>
                                <li><a href="frmSubRubros.aspx">Editar SubRubros</a></li>
                            </ul>
                        </li>

                        <li id="Men_Item" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Productos</span><span class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemsABM.aspx">Nuevo Producto</a></li>
                                <li><a href="frmItems.aspx">Editar Producto</a></li>
                            </ul>
                        </li>

                        <li id="Men_ItemImagen" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Imagenes de Productos</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemImagenes.aspx">Agregar Imágenes de Prdocutos</a></li>
                            </ul>
                        </li>

                        <li id="men_Consultas" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Consultas</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmConsultas.aspx">Ver Consultas</a></li>
                            </ul>
                        </li>

                        <li id="men_Contacto" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Contacto</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmContactoABM.aspx">Ver Contacto</a></li>
                            </ul>
                        </li>

                        <li id="Men_Servicios" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-view-list"></i><span>Mercado Pago</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                    <li><a href="FrmPedidosMP.aspx">Ver Mercado Pago</a></li>
                                <%--<li><a href="frmServicios.aspx">Editar Servicio</a></li>--%>
                            </ul>
                        </li>

                        
                        <li id="men_CambiarPass" visible="false" runat="server"><a href="frmCambiarPass.aspx"
                            class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-refresh"></i><span>Cambiar Contraseña </span>
                        </a></li>
                        <li id="men_CerrarSesion" visible="false" runat="server"><a onserverclick="CerrarSesion"
                            runat="server" class="waves-effect" style="background-color:#000;"><i class="zmdi zmdi-lock"></i><span>Cerrar Sesión
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
        </form>
        <!-- Left Sidebar End -->
        <!-- ============================================================== -->
        <!-- Start right Content here -->
        <!-- ============================================================== -->
        <div class="content-page">
            <!-- Start content -->
            <div class="content">
                <div class="container">
                    <div class="card-box table-responsive" style="">


                        <div class="row">

                             <div class="col-md-3">
                                <a href="FrmQuienesSomos.aspx">
                                    <div class="wrap" style="background:#000;">
                                           <div class="divPrueba">
                                        <center>
                                            
                                            <img src="Imagenes/quienes somos.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                            <div class="col-md-3">
                                <a href="frmNosotrosABM.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/LaFabrica.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                             <div class="col-md-3">
                                <a href="frmBannersABM.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/Portada.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>


                            <div class="col-md-3">
                                <a href="frmSponsors.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/Sponsor.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            
                           
                        </div>

                        <div class="row">

                            <div class="col-md-3">
                                <a href="frmMarcasABM.aspx">
                                    <div class="wrap" style="background:#000">
                                      <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/MarcaP.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                            <div class="col-md-3">
                                <a href="frmRubrosABM.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/Rubro.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                            <div class="col-md-3">
                                <a href="frmSubRubrosABM.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/SubRubro.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                            <div class="col-md-3">
                                <a href="frmItems.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/Productos.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>
                         
                        </div>

                        <div class="row">

                               <div class="col-md-3">
                                <a href="frmItemImagenes.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/ImagenProducto.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>
                      

                            <div class="col-md-3">
                                <a href="frmConsultas.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/Consultass.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                            <div class="col-md-3">
                                <a href="frmContactoABM.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <img src="Imagenes/Contacto.png" style="height: 20%; width:60%; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>
                            
                            <div class="col-md-3">
                                <a href="FrmPedidosMP.aspx">
                                    <div class="wrap" style="background:#000">
                                           <div class="divPrueba">
                                        <center>
                                            <p style="color:white; font-weight:bold;  font-size:12px;">PEDIDOS MERCADO PAGO</p>
                                            <br />
                                            <img src="Imagenes/mp.png" style="height: 20%; width:auto; margin-top:-15px;"/>
                                        </center></div>
                                    </div>
                                </a>
                            </div>

                            
                           
                        </div>
                       
                        <div class="row">
                            <div class="col-md-12">
                            <center>
                                <img src="Imagenes/logonegro.png" style=" height:70px; margin-top:170px;"/>
             </center>
             
                            </div>
                            
                            </div>


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
        $(window).load(function () {
            // Animate loader off screen
            $(".se-pre-con").fadeOut("slow"); ;
        });
    </script>
</body>
</html>
