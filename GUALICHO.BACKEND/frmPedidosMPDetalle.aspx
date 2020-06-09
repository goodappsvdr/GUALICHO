<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPedidosMPDetalle.aspx.vb" Inherits="GUALICHO.BACKEND.frmPedidosMPDetalle" %>

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

<div class="se-pre-con"></div>
    <form id="form1" runat="server" >


    <div class="Status" id="DivStatus" runat="server" visible="false">
    <div class="wow zoomIn">
    <center>
    <div class="StatusModal">
    <img src="Imagenes/cerrar.png"  onclick="CerrarStatus()" style=" cursor:pointer; height:20px; float:right;" />
    <br /> <br />
     <span id="TituloStatusSpan" style=" font-size:25px;" runat="server"></span><br />
     <br />   
        <img src="" runat="server" id="ImagenStatus" style=" height:80px;" />
    </div>
    </center>
    </div>
    </div>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>




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
                <div class="user-box"  style=" padding: 10px 10px 0px 10px;">
                    
                     <div style=" padding:15px;   -webkit-filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5));    background:white;">

                                 <a href="frmInicio.aspx"> <img style="height: 55px; " src="Imagenes/logo.png" /></a>
                                 <br /><br />
                                   <asp:Label ID="lblUsuario" style=" color:#000000;" runat="server"  Text=""></asp:Label>
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
                                <li><a href="frmNosotrosABM.aspx">Editar Fábrica</a></li>
                            </ul>
                        </li>

                        <li id="Men_Banners" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Portada</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmBannersABM.aspx">Nueva Portada</a></li>
                                <li><a href="frmBanners.aspx">Editar Portada</a></li>
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
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Productos</span><span class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemsABM.aspx">Nuevo Producto</a></li>
                                <li><a href="frmItems.aspx">Editar Producto</a></li>
                            </ul>
                        </li>
                        <li id="Men_ItemImagen" visible="false" runat="server" class="has_sub"><a href="javascript:void(0);"
                            class="waves-effect" style="background:#000;"><i class="zmdi zmdi-view-list"></i><span>Imágenes de Productos</span><span
                                class="menu-arrow"></span></a>
                            <ul class="list-unstyled">
                                <li><a href="frmItemImagenes.aspx">Agregar Imágenes de Productos</a></li>
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
        <div class="content-page">
            <!-- Start content -->
            <div class="content">
                 <div class="content">
                <div class="container">
                    <div class="row"  runat="server" id="PanelControles">
                        <div class="col-lg-12">
                            <div class="card-box">
                                <section class="icon-list-demo">
                                   <%--EMPIEZO BACKEND--%>
                             
                                    <center>
                                        <br />
                                    
                                        <div  class="form-group">
                                          


                                               <center>

                                  <asp:Repeater runat="server" ID="RepeaterMisPedidos">
             <ItemTemplate>
             <div  class="row" style="font-family: 'Poppins', sans-serif;  padding:24px 10px 0px 10px;background: #fff;   margin-left: 0.5px; width:100%;" >
                       
                          <div class="col-md-2" style=" padding-bottom:24px;">
                           <img  src="Imagenes/logo.png" style=" display:inline; height:60px; width:160px; object-fit:contain;   -webkit-filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5)); " />
                          </div>

                              <div class="col-md-3" style=" padding-bottom:24px;">
                                 <span style="font-size: 16px; font-weight:bold; color: #555555;"><%# Eval("Nropedido")%> </span><br />
                                  <span style="font-size: 14px; color: #999;"><%# Eval("Fecha")%> </span>
                                </div>

                                
                                 <div class="col-md-4" style=" padding-bottom:24px;">
                               <span style="font-size: 14px; font-weight:bold; color: #999;"><%# Eval("Estado")%> </span><br />
                                     <%# Eval("BotonPago")%>
                                  </div>
                        


                        
                         <div class="col-md-1" style=" padding-bottom:24px;">
                           <span style="font-size: 14px; font-weight:bold; color: #999;">$<%#  FormatNumber((Eval("total").ToString), 2)%> </span><br />
                                 
                                </div>

                                   <div class="col-md-2" style=" padding-bottom:24px;">
                                   <a id="txtVerMas<%# Eval("id_pedido")%>" style=" cursor:pointer; color:#3e774b; font-weight:bold;" onclick="VerDetalle(<%# Eval("id_pedido")%>)">Ver Detalles +</a>
                                   </div>
                          </div>



                          <asp:HiddenField ID="hd1"  Value='<%# Eval("id_pedido")%>' runat="server" />     

                       
                          <div id="DivDetalle<%# Eval("id_pedido")%>" class="row" style="display:none;">
                             
                                <asp:Repeater ID="RepeaterPedidosDetalles" runat="server"><ItemTemplate>
                              
                                    
                                    
                                    <div style=" border-bottom:1px solid black;   max-width:1169px; width:100%; "></div>
                              
                                    <div  class="row"  style="background: #dddddd; padding:5px; max-width:1169px; width:100%;" >
                             <div class="col-md-3" style=" padding-bottom:5px;">
                           <img runat="server" id="Img1" src='<%# Eval("Imagen")%>' style=" display:inline; height:50px; width:50px; object-fit:cover;   -webkit-filter: drop-shadow(0px 4px 3px rgba(0, 0, 0, 0.5)); " />
                          </div>
                          

                            <div class="col-md-3" style=" padding-bottom:5px; ">
                                 <span style="font-size: 14px; color:black; font-family: 'Poppins', sans-serif;"><%# Eval("descripcion")%> </span><br />
                                 </div>

                                   <div class="col-md-4" style=" padding-bottom:5px;">
                                 <span style="font-size: 14px;  color:black; font-family: 'Poppins', sans-serif;">$ <%# Eval("Valor")%> </span><br />
                                  <span style="font-size: 14px;  color: black; font-family: 'Poppins', sans-serif;"><%# Eval("cantidad")%> Unidad/es </span>
                                  </div>

                                    <div class="col-md-2" style=" padding-bottom:5px;">
                                <span style="font-size: 14px; color: black; font-family: 'Poppins', sans-serif;">$ <%#  FormatNumber((Eval("total").ToString), 2)%></span><br />
                                  </div>

                                    
                                 </div>


                            </ItemTemplate>
                          </asp:Repeater>

                              
                                    <div style=" border-bottom:1px solid black;  max-width:1169px; width:100%; "></div>
                              </div>
                              
                          </ItemTemplate>
			</asp:Repeater>

</center>
                   



                                             <div class="row">
                                      <div class="col col-md-6"></div>
                                      
                                       <div class="col col-md-6">
                                       <br />
                                        <button type="button" style=" width:100%; background:#000 !important; display:none; border: 1px solid #000 !important;" id="cmdAceptar" runat="server" class="btn btn-success btn-rounded w-md waves-effect waves-light m-b-5">
                    ACEPTAR</button>
                                       </div>
                                       
                                       </div>
                                     
                                      
                                                  
                                                
                                                
                                                
                                                
                                                
                                                  

                                            </div>
                            </div>
                            
                           
                        </div>
                       
                      
                        <asp:HiddenField ID="HfID_Contacto" runat="server" />
                      
                        <br />
                        <asp:Label ID="lblError" class="lbl2" ForeColor="Red" runat="server" Text=""></asp:Label>
                        <br />
                        <br />
                        </center>


                        <%--TERMINO BACKEND--%>
                        </section>
                    </div>
                    
                    
                    <div class="row" runat="server" id="PanelVolver" visible="false">
                    
                       <div class="card-box" style="    min-height: 200px;">
                                <section class="icon-list-demo" >
                      <div class="col col-md-12">


                                       <br />
                                       <center>
                                        <button  type="button" style="                                                width: 50%;
                                                background: #000 !important;
                                                border: 1px solid #000 !important;" id="btnVolver" runat="server" class="btn btn-success btn-rounded w-md waves-effect waves-light m-b-5">
                    VOLVER A CONTACTO</button>
                    </center>
                                       </div>
                                       </section>

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
    
    
         </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" runat="server">
            <ProgressTemplate>
                <div id="FondoProgeso">
                    <img style=" margin: 0;
    position: absolute;
    top: 50%;
    left: 50%;
    -ms-transform: translate(-50%, -50%);
    transform: translate(-50%, -50%);  height:100px;" src="https://gifimage.net/wp-content/uploads/2018/04/loading-gif-orange-8.gif" />
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </form>
   
   
   
   
   
   
   
   
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

        function VerDetalle(id) {



            if (document.getElementById("DivDetalle" + id).style.display == "none") {
                document.getElementById("DivDetalle" + id).style.display = "block";
                document.getElementById("txtVerMas" + id).innerHTML = "Cerrar Detalles -";
                document.getElementById("txtVerMas" + id).style = "cursor:pointer; color:#8b3e46; font-weight:bold;";

            } else {
                document.getElementById("DivDetalle" + id).style.display = "none";
                document.getElementById("txtVerMas" + id).innerHTML = "Ver Detalles +";
                document.getElementById("txtVerMas" + id).style = "cursor:pointer; color:#3e774b; font-weight:bold;";


            }



        }
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
            $(".se-pre-con").fadeOut("slow");;
        });
    </script>



    
    <script src="Scripts/wowJs.js" type="text/javascript"></script>
        <script>
            new WOW().init();
</script>

</body>
</html>
