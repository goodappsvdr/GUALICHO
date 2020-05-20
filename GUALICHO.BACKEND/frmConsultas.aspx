<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmConsultas.aspx.vb" Inherits="GUALICHO.BACKEND.frmConsultas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">
    <link rel="shortcut icon" href="Imagenes/favicon.png">
    <title>Hiercons - Backend</title>
    <!-- DataTables -->
    <link href="assets/plugins/datatables/jquery.dataTables.min.css" rel="stylesheet"
        type="text/css" />
    <link href="assets/plugins/datatables/buttons.bootstrap.min.css" rel="stylesheet"
        type="text/css" />
    <link href="assets/plugins/datatables/fixedHeader.bootstrap.min.css" rel="stylesheet"
        type="text/css" />
    <link href="assets/plugins/datatables/responsive.bootstrap.min.css" rel="stylesheet"
        type="text/css" />
    <link href="assets/plugins/datatables/scroller.bootstrap.min.css" rel="stylesheet"
        type="text/css" />
    <!-- App CSS -->
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
    a {
        color: #000;
        cursor: pointer;
        text-decoration: none;
    }



    .pagination > .active > a, .pagination > .active > a:focus, .pagination > .active > a:hover, .pagination > .active > span, .pagination > .active > span:focus, .pagination > .active > span:hover {
        z-index: 3;
        color: #fff;
        cursor: default;
        background-color: #000;
        border-color: #000;
    }


    /* Paste this css to your style sheet file or under head tag */
    /* This only works with JavaScript, 
if it's not present, don't show loader */
    .no-js #loader {
        display: none;
    }

    .js #loader {
        display: block;
        position: absolute;
        left: 100px;
        top: 0;
    }

    .se-pre-con {
        position: fixed;
        left: 0px;
        top: 0px;
        width: 100%;
        height: 100%;
        z-index: 9999;
        background: url(https://gifimage.net/wp-content/uploads/2018/04/loading-gif-orange-8.gif) center no-repeat #fff;
        background-size: 100px 100px;
    }
</style>
<body class="fixed-left">
    <div class="se-pre-con"></div>
    <form id="Form1" runat="server">





        <!-- Begin page -->
        <div id="wrapper">
            <!-- Top Bar Start -->
            <div class="topbar">
                <!-- LOGO -->
                <div class="topbar-left">
                </div>
                <!-- Button mobile view to collapse sidebar menu -->
                <div class="navbar navbar-default" style="" role="navigation">




                    <div class="container">



                        <!-- Page title -->
                        <ul class="nav navbar-nav navbar-left">
                            <li>
                                <button class="button-menu-mobile open-left">
                                    <i class="zmdi zmdi-menu"></i>
                                </button>


                            </li>
                            <li>
                                <h4 class="page-title"></h4>
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

            <div class="left side-menu">
                <div class="sidebar-inner slimscrollleft">
                    <!-- User -->
                    <div class="user-box" style="padding: 10px 10px 0px 10px;">

                        <div style="padding: 15px; -webkit-filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5)); background: white;">

                            <a href="frmInicio.aspx">
                                <img style="height: 55px;" src="Imagenes/logo1.png" /></a>
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
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Quienes Somos</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="FrmQuienesSomos.aspx">Editar Quienes Somos</a></li>
                            </ul>
                        </li>

                        <li id="Men_Nosotros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Nosotros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="FrmNosotros.aspx">Editar Nosotros</a></li>
                            </ul>
                        </li>
                          <li id="Men_Servicios" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Servicios</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                    <li><a href="frmServiciosABM.aspx">Nuevo Servicio</a></li>
                                <li><a href="frmServicios.aspx">Editar Servicio</a></li>
                            </ul>
                        </li>


                        <li id="Men_Banners" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Sliders</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmBannersABM.aspx">Nuevo Slider</a></li>
                                <li><a href="frmBanners.aspx">Editar Sliders</a></li>
                            </ul>
                        </li>

                           <li id="Men_Sponsors" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Sponsors</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmSponsorABM.aspx">Nuevo Sponsor</a></li>
                                <li><a href="frmSponsors.aspx">Editar Sponsor</a></li>
                            </ul>
                        </li>



                        <li id="men_Marcas" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Marcas</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmMarcasABM.aspx">Nueva marca</a></li>
                                <li><a href="frmMarcas.aspx">Editar Marcas</a></li>
                            </ul>
                        </li>
                        <li id="men_Rubros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Rubros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmRubrosABM.aspx">Nuevo Rubro</a></li>
                                <li><a href="frmRubros.aspx">Editar Rubros</a></li>
                            </ul>
                        </li>
                        <li id="men_SubRubros" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>SubRubros</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmSubRubrosABM.aspx">Nuevo SubRubro</a></li>
                                <li><a href="frmSubRubros.aspx">Editar SubRubros</a></li>
                            </ul>
                        </li>
                        <li id="Men_Item" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Items</span><span class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemsABM.aspx">Nuevo Item</a></li>
                                <li><a href="frmItems.aspx">Editar Items</a></li>
                            </ul>
                        </li>
                        <li id="Men_ItemImagen" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect"><i class="zmdi zmdi-view-list"></i><span>Imagenes Items</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemImagenes.aspx">Agregar Imágenes</a></li>
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
                                <li><a href="frmConsultas.aspx">Ver Contacto</a></li>
                            </ul>
                        </li>

                        
                        <li id="men_CambiarPass" visible="false" runat="server"><a href="frmCambiarPass.aspx"
                            class="waves-effect"><i class="zmdi zmdi-refresh"></i><span>Cambiar Contraseña </span>
                        </a></li>
                        <li id="men_CerrarSesion" visible="false" runat="server"><a onserverclick="CerrarSesion"
                            runat="server" class="waves-effect"><i class="zmdi zmdi-lock"></i><span>Cerrar Sesión
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
                <div class="row">
                    <div class="col-sm-12">
                        <div class="card-box table-responsive">

                            <h4 class="header-title m-t-0 m-b-30">Consultas</h4>

                            <table id="datatable" class="table table-striped table-bordered" style="cursor: pointer;">
                                <thead>
                                    <tr>
                                        <th class="style1">Usuario
                                        </th>
                                        <th class="style1">Razón Social
                                        </th>
                                        <th class="style1">Teléfono
                                        </th>
                                        <th class="style1">Fecha
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RepeaterConsultas" runat="server">
                                        <ItemTemplate>
                                            <tr onclick="window.open( '<%# Eval("urlweb")%>','_top' ); return false;">
                                                <th>
                                                    <a style="text-decoration: none;">
                                                        <%# Eval("Usuario")%></a>
                                                </th>
                                                <th>
                                                    <a style="text-decoration: none;">
                                                        <%# Eval("RazonSocial")%></a>
                                                </th>
                                                <th>
                                                    <a style="text-decoration: none;">
                                                        <%# Eval("Telefono")%></a>
                                                </th>
                                                <th>
                                                    <a style="text-decoration: none;">
                                                        <%# Eval("Fecha")%></a>
                                                </th>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>



                            </table>

                            <center>
                            </center>
                        </div>
                    </div>
                    <!-- end col -->
                </div>
                <!-- end row -->
                <!-- end row -->
                <!-- end row -->
            </div>
            <!-- container -->
        </div>
        <!-- content -->
        <footer class="footer text-right">
                    2019 © GoodApps.
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
    <script src="assets/js/jquery.slimscroll.js"></script>
    <script src="assets/js/jquery.blockUI.js"></script>
    <script src="assets/js/waves.js"></script>
    <script src="assets/js/jquery.nicescroll.js"></script>
    <script src="assets/js/jquery.scrollTo.min.js"></script>
    <!-- Datatables-->
    <script src="assets/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="assets/plugins/datatables/dataTables.bootstrap.js"></script>
    <script src="assets/plugins/datatables/dataTables.buttons.min.js"></script>
    <script src="assets/plugins/datatables/buttons.bootstrap.min.js"></script>
    <script src="assets/plugins/datatables/jszip.min.js"></script>
    <script src="assets/plugins/datatables/pdfmake.min.js"></script>
    <script src="assets/plugins/datatables/vfs_fonts.js"></script>
    <script src="assets/plugins/datatables/buttons.html5.min.js"></script>
    <script src="assets/plugins/datatables/buttons.print.min.js"></script>
    <script src="assets/plugins/datatables/dataTables.fixedHeader.min.js"></script>
    <script src="assets/plugins/datatables/dataTables.keyTable.min.js"></script>
    <script src="assets/plugins/datatables/dataTables.responsive.min.js"></script>
    <script src="assets/plugins/datatables/responsive.bootstrap.min.js"></script>
    <script src="assets/plugins/datatables/dataTables.scroller.min.js"></script>
    <!-- Datatable init js -->
    <script src="assets/pages/datatables.init.js"></script>
    <!-- App js -->
    <script src="assets/js/jquery.core.js"></script>
    <script src="assets/js/jquery.app.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#datatable').dataTable();
            $('#datatable-keytable').DataTable({ keys: true });
            $('#datatable-responsive').DataTable();
            $('#datatable-scroller').DataTable({ ajax: "assets/plugins/datatables/json/scroller-demo.json", deferRender: true, scrollY: 380, scrollCollapse: true, scroller: true });
            var table = $('#datatable-fixed-header').DataTable({ fixedHeader: true });
        });
        TableManageButtons.init();

    </script>




    <script type="text/javascript">
        $(window).load(function () {
            // Animate loader off screen
            $(".se-pre-con").fadeOut("slow");;
        });
    </script >





</body >
</html >

