﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmServiciosDetalle.aspx.vb" Inherits="GUALICHO.frmServiciosDetalle" %>


<!doctype html>
<html class="no-js" lang="zxx">
<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>.:: GUALICHO ::.</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    
    <!-- Place favicon.ico in the root directory -->
    <link rel="shortcut icon" type="image/x-icon" href="imagenes/favicon.png">
    <link rel="apple-touch-icon" href="apple-touch-icon.png">
    

    <!-- All css files are included here. -->
    <!-- Bootstrap fremwork main css -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- Owl Carousel min css -->
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <!-- This core.css file contents all plugings css file. -->
    <link rel="stylesheet" href="css/core.css">
    <!-- Theme shortcodes/elements style -->
    <link rel="stylesheet" href="css/shortcode/shortcodes.css">
    <!-- Theme main style -->
    <link rel="stylesheet" href="style.css">
    <!-- Responsive css -->
    <link rel="stylesheet" href="css/responsive.css">
    <!-- User style -->
    <link rel="stylesheet" href="css/custom.css">


    <!-- Modernizr JS -->
    <script src="js/vendor/modernizr-3.5.0.min.js"></script>
</head>
    <style>

        .pagination>.active>a, .pagination>.active>span, .pagination>.active>a:hover, .pagination>.active>span:hover, .pagination>.active>a:focus, .pagination>.active>span:focus {
    z-index: 3;
    color: #fff;
    background-color: #000;
    border-color: #000;
    cursor: default;
}

        

        .DivLoader {
         width: 100%; height: 2500px; min-height:100%; 
  background-color:rgba(0, 0, 0, 0.8);
     overflow: hidden;
    position: absolute;
    z-index:999999;
     top: 0;
    right: 0;
    bottom: 0;
    left: 0;
        }


        
            .BtnBusquedaClase {
            background: white none repeat scroll 0 0;
    border: 0 none;
    border-radius: 0;
    cursor: pointer;
    height: 60px;
    line-height: 60px;
    position: absolute;
    right: 40px;
    top: 0;
   margin-top: 50px;
    margin-right: -38px;
    width: 60px;
    transition: 0.3s;
        }


        .BtnBusquedaClase:hover::before {
    color: #fff;
    background:#000;

}
.BtnBusquedaClase::before {
    color: #333;
    content: "";
    display: block;
    font-family: Material-Design-Iconic-Font;
    font-size: 29px;
    transition: color 300ms ease 0s;
}
*:before, *:after {
    box-sizing: border-box;
}


         .MenuWebNuevo {
        padding: 20px 0px 20px 0px;
        }

          
       @media only screen and (min-width: 0px) and (max-width:800px) {  
                    
       
         .MenuWebNuevo {
        padding: 0px 0px 0px 0px;
        }
       
       }
                     

       .col-xs-1, .col-sm-1, .col-md-1, .col-lg-1, .col-xs-2, .col-sm-2, .col-md-2, .col-lg-2, .col-xs-3, .col-sm-3, .col-md-3, .col-lg-3, .col-xs-4, .col-sm-4, .col-md-4, .col-lg-4, .col-xs-5, .col-sm-5, .col-md-5, .col-lg-5, .col-xs-6, .col-sm-6, .col-md-6, .col-lg-6, .col-xs-7, .col-sm-7, .col-md-7, .col-lg-7, .col-xs-8, .col-sm-8, .col-md-8, .col-lg-8, .col-xs-9, .col-sm-9, .col-md-9, .col-lg-9, .col-xs-10, .col-sm-10, .col-md-10, .col-lg-10, .col-xs-11, .col-sm-11, .col-md-11, .col-lg-11, .col-xs-12, .col-sm-12, .col-md-12, .col-lg-12 {
    position: relative;
    min-height: 1px;
    padding-left: 0px !important; 
     padding-right:  0px !important; 
}


        .VerMas {
        background:#4A0C86; color:white; padding:20px; 
        transition: transform .2s; 
        }
        .VerMas:hover {
  transform: scale(1.2); /* (150% zoom - Note: if the zoom is too large, it will go outside of the viewport) */
}

        .main__menu > li:hover > a {
        color: #AFB0B8;
        }
        .main__menu li.drop ul.dropdown li:hover > a {
        background: #fafafa none repeat scroll 0 0;
        color: #AFB0B8;
        }
        .main__menu li.drop ul.dropdown.mega_dropdown li:hover > a {
        background: transparent none repeat scroll 0 0;
        color: #AFB0B8;
        }

    </style>
<body>
     <form runat="server">
    <!--[if lt IE 8]>
        <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->  
        <div class="DivLoader" id="DivLoader1" style="display:none;">

          <img style="margin: 0; position: absolute; top: 20%; left: 50%; -ms-transform: translate(-50%, -50%);
                    transform: translate(-50%, -50%); height:60px;" src="https://www.pointcomfort.com/ResourcePackages/PointComfort/assets/dist/images/spinner.gif" />

    </div>

    <!-- Body main wrapper start -->
    <div class="wrapper">
        <!-- Start Header Style -->
        <header id="htc__header" class="htc__header__area header--one">
            <!-- Start Mainmenu Area -->
            <div id="sticky-header-with-topbar" class="mainmenu__wrap sticky__header">
                
                <div class="container" style="margin-right: auto; margin-left: auto;padding-left: 30px; padding-right: 50px; width:100%;" >
                  
                    
                    <div class="row" >
                        
                        <div class="MenuWebNuevo">
                        <div class="menumenu__container clearfix">
                            <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" style=" padding: 0px 10px 0px 0px;"> 
                                <div class="logo">
                                     <a href="frminicio.aspx"><img src="Imagenes/logo.png" alt="logo images" style="max-height: 80px;"></a>
                                </div>
                                
                            </div>
    
                            <div class="col-md-6 col-lg-6 col-sm-4 col-xs-3">
                                <nav class="main__menu__nav hidden-xs hidden-sm">
                                    <ul class="main__menu">
                                        <li class="drop"><a href="frminicio.aspx">PRINCIPAL</a></li>
                                             <li class="drop"><a href="frmNosotros.aspx">NOSOTROS</a></li>
                                       <%-- <li class="drop"><a href="#">women</a>--%>
                                          
                                            
                                           <%-- <ul class="dropdown mega_dropdown">
                                                <li><a class="mega__title" href="product-grid.html">Shop Pages</a>
                                                    <ul class="mega__item">
                                                        <li><a href="product-grid.html">Product Grid</a></li>
                                                        <li><a href="cart.html">cart</a></li>
                                                        <li><a href="checkout.html">checkout</a></li>
                                                        <li><a href="wishlist.html">wishlist</a></li>
                                                    </ul>
                                                </li>
                                                <li><a class="mega__title" href="product-grid.html">Variable Product</a>
                                                    <ul class="mega__item">
                                                        <li><a href="#">Category</a></li>
                                                        <li><a href="#">My Account</a></li>
                                                        <li><a href="wishlist.html">Wishlist</a></li>
                                                        <li><a href="cart.html">Shopping Cart</a></li>
                                                        <li><a href="checkout.html">Checkout</a></li>
                                                    </ul>
                                                </li>
                                                <li><a class="mega__title" href="product-grid.html">Product Types</a>
                                                    <ul class="mega__item">
                                                        <li><a href="#">Simple Product</a></li>
                                                        <li><a href="#">Variable Product</a></li>
                                                        <li><a href="#">Grouped Product</a></li>
                                                        <li><a href="#">Downloadable Product</a></li>
                                                        <li><a href="#">Simple Product</a></li>
                                                    </ul>
                                                </li>
                                                
                                            </ul>
                                      
                                            
                                        
                                        
                                        
                                        
                                        </li>--%>
                                        <%--<li class="drop"><a href="#">RUBROS</a>
                                            <ul class="dropdown mega_dropdown">
                                             
                                                <li><a class="mega__title" href="product-grid.html">Nuestros rubros</a>
                                                    <ul class="mega__item">
                                                        <li><a href="product-grid.html">Product Grid</a></li>
                                                        <li><a href="cart.html">cart</a></li>
                                                        <li><a href="checkout.html">checkout</a></li>
                                                        <li><a href="wishlist.html">wishlist</a></li>
                                                    </ul>
                                                </li>
                                              
                                            </ul>
                                        </li>--%>


                                        <li class="drop"><a href="#">PRODUCTOS</a>
                                            <ul class="dropdown">
                                                
                                                <asp:Repeater runat="server" ID="RepeaterMenuRubros">
                                             <ItemTemplate>
                                              <li><a href='<%# Eval("url")%>'><%# Eval("Descripcion")%></a></li>
                                        </ItemTemplate>
                                                </asp:Repeater>
                                                
                                            </ul>
                                        </li>
                                        <li  runat="server" visible="false" id="MenuMisConsultas"><a href="frmServicios.aspx">SERVICIOS</a></li>
                                        <li><a href="frmContacto.aspx">CONTACTO</a></li>
                                         <li style="display:none;" runat="server" visible="false" id="MenuIniciarSesion"><a style="color:#000;" href="frmLogin.aspx">INGRESAR</a></li>
                                        <li style="display:none;" runat="server" visible="false" id="MenuCerrarSesion"><a style="color:#000;"  id="A1" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>

                                    </ul>
                                </nav>

                                   <div class="mobile-menu clearfix visible-xs visible-sm">
                                    <nav id="mobile_dropdown">
                                        <ul>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="frmInicio.aspx">PRINCIPAL</a></li>
                                           <li><a style="font-family: 'Poppins', sans-serif;" href="frmNosotros.aspx">NOSOTROS</a></li>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="#">RUBROS</a>
                                                <ul>
                                                     <asp:Repeater runat="server" ID="RepeaterMenuRubrosMobile">
                                             <ItemTemplate>
                                              <li><a style="font-family: 'Poppins', sans-serif;" href='<%# Eval("url")%>'><%# Eval("Descripcion")%></a></li>
                                        </ItemTemplate>
                                                </asp:Repeater>
                                                </ul>
                                            </li>
                                            <%-- <li  runat="server" visible="false" id="MenuMisConsultasMobile"><a href="FrmServicios.aspx">SERVICIOS</a></li>--%>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="frmContacto.aspx">CONTACTO</a></li>
                                             <li style="display:none;" runat="server" visible="false" id="MenuIniciarSesionMobile"><a style="color:#000;" href="frmLogin.aspx">INICIAR SESIÓN</a></li>
                                             <li style="display:none;" runat="server" visible="false" id="MenuCerrarSesionMobile"><a style="color:#000;"  id="A2" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>
                                        </ul>
                                    </nav>
                                </div> 
                            </div>
                            <div class="col-md-2 col-lg-2 col-sm-4 col-xs-4">
                                <div class="header__right" style="padding-right: 40px;">
                                    <div class="header__search search search__open">
                                        <a href="#"><i class="icon-magnifier icons"></i></a>
                                    </div>
                                    <div class="header__account search search__open" style="cursor: pointer;">
                                    
                                
                            
                                        <span style="font-family: 'Poppins', sans-serif;">Buscar</span>
                                    </div>
                                </div>
                            </div>

                            <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2"  style="                                    padding: 0px 10px 0px 0px;
                            "> 
                                <div class="logo">
                                     <a href="frminicio.aspx"><img src="imagenes/copmaco.png"  style="max-height: 90px;" alt="logo images"></a>
                                </div>
                                
                            </div>

                        </div>
</div>






                    </div>
                  
                    
                    <div class="mobile-menu-area"></div>
                </div>


            </div>
            <!-- End Mainmenu Area -->
        </header>
        <!-- End Header Area -->

        <div class="body__overlay"></div>
        <!-- Start Offset Wrapper -->
        <div class="offset__wrapper">
            <!-- Start Search Popap -->
         <div class="search__area" style="height:170px;">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="search__inner" style="padding-right: 60px;">
                                <form action="#" method="get">
                                    <input placeholder="Qué estas buscando?" id="TxtBusquedaGenerica"  type="text" style="background: #fff none repeat scroll 0 0;
    border: medium none;
    color: #333;
    font-size: 25px;
    font-weight: 300;
    height: 60px;
        margin-top: 50px;
    line-height: 60px;
    padding: 0 70px 0 20px;
    text-align: left;
    font-family: 'Poppins', sans-serif;
    ">
                                    <button class="BtnBusquedaClase" type="button" onclick="ClickBusqueda()"></button>
                                </form>
                                <div class="search__close__btn" style="    margin-right: -30px; margin-top: 55px;">
                                    <span class="search__close__btn_icon"><i class="zmdi zmdi-close"></i></span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Search Popap -->
            <!-- Start Cart Panel -->
            
            <!-- End Cart Panel -->
        </div>
        <!-- End Offset Wrapper -->
        <!-- Start Bradcaump area -->
        <div class="ht__bradcaump__area" style="background: rgba(0, 0, 0, 0) url(imagenes/imgRubros.jpg) no-repeat scroll center center / cover ;">
            <div class="ht__bradcaump__wrap">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="bradcaump__inner">
                                <nav class="bradcaump-inner" >
                                  <a class="breadcrumb-item" href="frmInicio.aspx" style="color:white;">Principal</a>
                                  <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;"></i></span>
                                  <span class="breadcrumb-item active" style="color:white;">Servicios</span>
                                       <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;"></i></span>
                                     <span id="txtServicioArriba" runat="server" class="breadcrumb-item active" style="color:white;"></span>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Bradcaump area -->
        <!-- Start Product Grid -->
                <section class="htc__contact__area ptb--100 bg__white" >
            <div class="container">
            
                <div class="row">
                    
                  <div class="col-md-12">
                      <center>
                      <h1 id="TxtServicio" runat="server">

                      </h1>
<hr />

                          <p runat="server" id="txtDetalle">

                          </p>

                          

                          <hr />

                               <div class="row">

                                <div id="myCarousel" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->

  <div class="carousel-inner">
      <asp:Repeater runat="server" ID="RepeaterImagenesServicios"><ItemTemplate>
      <div class="<%# Eval("Clase")%>">
      <img src="<%# Eval("Imagen")%>" alt="Los Angeles" style="width:100%; max-width:800px; height:auto; object-fit:cover; max-height:550px;">
    </div>
          </ItemTemplate></asp:Repeater>
   

  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
                            </div>

                          </center>
                  </div>
                
                </div>
                
            </div>
        </section>
        <!-- End Product Grid -->
        <!-- Start Brand Area -->

        <!-- End Brand Area -->
        <!-- Start Banner Area -->
        
         <div class="htc__brand__area bg__cat--4">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="ht__brand__inner">
                            <ul class="brand__list owl-carousel clearfix" id="DivSponsors">
                        <asp:Repeater id="RepeaterSponsors" runat="server">
                                    <ItemTemplate>
                               
                                    <li><img style="width:210px; height:80px; object-fit:cover;" src="<%# Eval("Imagen").ToString%>" alt="brand images"></li>
                          
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
 
        <footer id="htc__footer">
            <!-- Start Footer Widget -->
            <div class="footer__container bg__white">
                <div class="container">
                    <div class="row">
                        <!-- Start Single Footer Widget -->
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <div class="footer">
                                <h2 class="title__line--2">ABOUT US</h2>
                                <div class="ft__details">
 <p   style="font-family: 'Poppins', sans-serif;">Recordás cuando ibas a tu bar favorito y pedías esa pinta de birra que tanto te gustaba? Recordás el primer aroma que sentías cuando la llevabas a la boca? Y cuando la pasabas por la garganta? Esa sensación de mezcla entre gusto y regusto? Todo eso lo pensamos cada vez que armamos una receta. Disfruta cada trago. Hasta la birra!</p>
                                    <div class="ft__social__link">
                                        <ul class="social__link">
                                            <li style="display:none;"><a href="#" id="HrefTwitter" runat="server"><i class="icon-social-twitter icons" style="color:#000;"></i></a></li>

                                             <li><a href="#" id="HrefFacebook" runat="server"><i><img style="width:33px; height:30px;"  src="imagenes/icono facebook gualicho.png" /></i></a></li>

                                            <li><a href="#" id="HrefInstagram" runat="server"><i><img style="width:33px; height:30px"  src="imagenes/icono instagram gualicho.png" /></i></a></li>

                                            <li><a href="#" id="HrefWhatsapp" runat="server"><i><img style="width:33px; height:30px"  src="imagenes/icono whatsapp gualicho.png" /></i></a></li>

                                             

                                             
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- End Single Footer Widget -->
                        <!-- Start Single Footer Widget -->
                        <div class="col-md-4 col-sm-6 col-xs-12 xmt-40">
                            <div class="footer">
                                <h2 class="title__line--2">information</h2>
                                <div class="ft__inner">
                                    <ul class="ft__list"  style="font-family: 'Poppins', sans-serif;">
                                        <li><a href="frminicio.aspx">Principal</a></li>
                                        <li><a href="frmnosotros.aspx">La Fabrica</a></li>
                                        <li><a href="frmContacto.aspx">Contacto</a></li>
                                    <%--    <li><a href="#">Terms  & Condition</a></li>
                                        <li><a href="#">Manufactures</a></li>--%>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!-- End Single Footer Widget -->
                        <!-- Start Single Footer Widget -->
                        <%--<div class="col-md-2 col-sm-6 col-xs-12 xmt-40 smt-40">
                            <div class="footer">
                                <h2 class="title__line--2">my account</h2>
                                <div class="ft__inner">
                                    <ul class="ft__list">
                                        <li><a href="#">My Account</a></li>
                                        <li><a href="cart.html">My Cart</a></li>
                                        <li><a href="#">Login</a></li>
                                        <li><a href="wishlist.html">Wishlist</a></li>
                                        <li><a href="checkout.html">Checkout</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>--%>
                        <!-- End Single Footer Widget -->
                        <!-- Start Single Footer Widget -->
                        <%--<div class="col-md-2 col-sm-6 col-xs-12 xmt-40 smt-40">
                            <div class="footer">
                                <h2 class="title__line--2">Our service</h2>
                                <div class="ft__inner">
                                    <ul class="ft__list">
                                        <li><a href="#">My Account</a></li>
                                        <li><a href="cart.html">My Cart</a></li>
                                        <li><a href="#">Login</a></li>
                                        <li><a href="wishlist.html">Wishlist</a></li>
                                        <li><a href="checkout.html">Checkout</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>--%>
                        <!-- End Single Footer Widget -->
                        <!-- Start Single Footer Widget -->
                        <div class="col-md-4 col-sm-6 col-xs-12 xmt-40 smt-40">
                            <div class="footer">
                                <h2 class="title__line--2">NEWSLETTER </h2>
                                <div class="ft__inner">
                                    <div class="news__input">
                                        <input type="text" style="font-family: 'Poppins', sans-serif;"  placeholder="Su email*">
                                        <div class="send__btn">
                                            <a class="fr__btn" href="#">Enviar</a>
                                        </div>
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                        <!-- End Single Footer Widget -->
                    </div>
                </div>
            </div>
            <!-- End Footer Widget -->
            <!-- Start Copyright Area -->
            <div class="htc__copyright bg__cat--5">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="copyright__inner">
                                <p style="font-family: 'Poppins', sans-serif;">Copyright© <a style="color:white" href="https://www.goodapps.com.ar/">GoodApps</a> 2019-2020. Todos los derechos reservados.</p>
                                <a style="display:none;" href="#"><img src="images/others/shape/paypol.png" alt="payment images"></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Copyright Area -->
        </footer>

        <!-- End Footer Style -->
    </div>
    <!-- Body main wrapper end -->


        <script src="js/jplist.min.js" type="text/javascript"></script>

        <script>
            jplist.init();
        </script>

    <!-- Placed js at the end of the document so the pages load faster -->

    <!-- jquery latest version -->
    <script src="js/vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap framework js -->
    <script src="js/bootstrap.min.js"></script>
    <!-- All js plugins included in this file. -->
    <script src="js/plugins.js"></script>
    <script src="js/slick.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>

         <script>



             //var owl1 = $('#DivBanners');
             //owl1.owlCarousel({
             //    items: 1,
             //    loop: true,
             //    margin: 10,
             //    autoplay: true,
             //    autoplayTimeout: 2000,
             //    autoplayHoverPause: true
             //});
             //$('.play').on('click', function () {
             //    owl1.trigger('play.owl.autoplay', [1000])
             //})
             //$('.stop').on('click', function () {
             //    owl1.trigger('stop.owl.autoplay')
             //})



             var owl = $('#DivSponsors');
             owl.owlCarousel({
                 items: 3,
                 loop: true,
                 margin: 10,
                 autoplay: true,
                 autoplayTimeout: 1000
                 //autoplayHoverPause: true
             });
             $('.play').on('click', function () {
                 owl.trigger('play.owl.autoplay', [1000])
             })
             $('.stop').on('click', function () {
                 owl.trigger('stop.owl.autoplay')
             })

            </script>

    <!-- Waypoints.min.js. -->
    <script src="js/waypoints.min.js"></script>
    <!-- Main js file that contents all jQuery plugins activation. -->
    <script src="js/main.js"></script>

    

    

     <link href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.css" rel="stylesheet" type="text/css">
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.js"></script>

    
    <%--    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>

--%>

    <script>




</script>


         </form>
</body>

</html>