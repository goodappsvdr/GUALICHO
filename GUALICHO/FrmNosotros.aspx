<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmNosotros.aspx.vb" Inherits="GUALICHO.FrmNosotros" %>

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
       <link href="tableResponsive.css" rel="stylesheet" />

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


         *:focus {
        outline: none !Important;
    }

    
    a.button-cart {
        position: fixed;
        bottom: 0;
        right: 0;
        z-index:999999;
        margin-bottom: 35px;
        margin-right: 35px;
        width: 168px;
        height: 46px;
        border-radius: 40px;
        /*box-shadow: 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22);*/
        transition: all 0.5s cubic-bezier(.7,0,.5,1.4);
    }


        a.button-cart.active {
            width: 178px;
        }

        a.button-cart:hover {
            text-decoration: none;
        }

     .button-bg {
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        border-radius: 14px;
        z-index: 1;
        /*box-shadow: 0px 8px 16px 0px rgba(143, 255, 213, 0.26);*/
        -webkit-animation: quickScaleIn 0.6s cubic-bezier(.7,0,.5,1.4) alternate;
        transform-origin: bottom left;
        overflow: hidden;
        background: #EDDE5D;  /* fallback for old browsers */
        background: -webkit-linear-gradient(to right, #EDDE5D, #EDDE5D);  /* Chrome 10-25, Safari 5.1-6 */
        background: linear-gradient(to right, #EDDE5D, #EDDE5D); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#3dfcff', endColorstr='#afffd3', GradientType=1 );
        transition: all .3s cubic-bezier(.7,0,.5,1.4);
    }

        .circle {
            cursor: pointer !important;
            position: absolute;
            overflow: hidden;
            z-index: 2;
            top: -22px;
            left: -12px;
            width: 50px;
            height: 50px;
            border-radius: 14px;
            -webkit-animation: quickScaleIn 0.6s cubic-bezier(.7,0,.5,1.4) backwards;
            transform-origin: bottom left;
            animation-delay: 0.2s;
            /*box-shadow: 5px 5px 15px 0px rgba(238, 146, 255, 0.25);*/
            background: #000;
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#e5c9ff', endColorstr='#ffdbde', GradientType=1 );
            transition: all .3s cubic-bezier(.7,0,.5,1.4);
        }

        .button-cart.active .circle {
            -webkit-animation: moveUpDown 0.4s ease-in-out;
            animation-iteration-count: 1;
            cursor: pointer !important;
        }

        .icon-cart svg {
            position: absolute;
            width: 22px;
            z-index: 3;
            top: 14px;
            left: 12px;
            fill: #fff;
            -webkit-animation: quickFadeIn 0.4s ease backwards;
            animation-delay: 0.7s;
            transition: all 0.1s cubic-bezier(.7,0,.5,1.4);
            transition-delay: 0.3s;
            cursor: pointer !important;
        }

        .button-cart.active .icon-cart svg {
            top: 60px;
        }

        .icon-checkmark svg {
            position: absolute;
            width: 22px;
            height: 26px;
            z-index: 3;
            top: -30px;
            left: 14px;
            fill: #433746;
            transition: all 0.1s cubic-bezier(.7,0,.5,1.4);
            transition-delay: 0.4s;
        }

        .button-cart.active .icon-checkmark svg {
            top: 12px;
        }

        .text {
            color: #221f25;
            font-weight: 600;
            font-size: 14px;
        }

        .text-before {
            position: absolute;
            left: 50px;
            top: 13px;
            z-index: 4;
            -webkit-animation: quickFadeIn 0.4s ease-out backwards;
            animation-delay: 0.6s;
            transition: all 0.2s cubic-bezier(.7,0,.5,1.4);
            transition-delay: 0.1s;
        }

        a.button-cart.active .text-before {
            top: 80px;
        }

        .text-after {
            position: absolute;
            left: 50px;
            top: 13px;
            z-index: 4;
            top: -30px;
            transition: all 0.2s cubic-bezier(.7,0,.5,1.4);
            transition-delay: 0.2s;
        }

        a.button-cart.active .text-after {
            top: 13px;
        }

        /* KEYFRAMES */
        @-webkit-keyframes quickScaleIn {
            From {
                -webkit-transform: scale(0);
            }

            To {
                -webkit-transform: scale(1);
            }
        }

        @-webkit-keyframes quickFadeIn {
            From {
                opacity: 0;
            }

            To {
                opacity: 1;
            }
        }

    @-webkit-keyframes moveUpDown {
        0% {
            top: -22px;
        }

        50% {
            top: -16px;
        }

        100% {
            top: -22px;
        }
    }


    .EliminarItem {
        cursor: pointer;
        font-size: 27px;
        color: black;
        font-weight: 700;
        padding: 5px 16px 5px 16px;
        text-align: right;
        box-shadow: 0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
        transition: all 0.3s cubic-bezier(.25,.8,.25,1);
        float: right;
        margin-top: 16px;
        border-radius: 50%;
        background: #AAAAAA;
    }
    </style>
<body>

    
     <a href="#" class="button-cart" style="cursor:pointer;" id="btnCarrito" onclick="" runat="server" >
    <span class="circle">
      <span class="icon icon-cart" >
        <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 459.529 459.529" style="enable-background:new 0 0 459.529 459.529;" xml:space="preserve">
          <g>
            <path d="M17,55.231h48.733l69.417,251.033c1.983,7.367,8.783,12.467,16.433,12.467h213.35c6.8,0,12.75-3.967,15.583-10.2
						l77.633-178.5c2.267-5.383,1.7-11.333-1.417-16.15c-3.117-4.817-8.5-7.65-14.167-7.65H206.833c-9.35,0-17,7.65-17,17
						s7.65,17,17,17H416.5l-62.9,144.5H164.333L94.917,33.698c-1.983-7.367-8.783-12.467-16.433-12.467H17c-9.35,0-17,7.65-17,17
						S7.65,55.231,17,55.231z" />
            <path d="M135.433,438.298c21.25,0,38.533-17.283,38.533-38.533s-17.283-38.533-38.533-38.533S96.9,378.514,96.9,399.764
						S114.183,438.298,135.433,438.298z" />
            <path d="M376.267,438.298c0.85,0,1.983,0,2.833,0c10.2-0.85,19.55-5.383,26.35-13.317c6.8-7.65,9.917-17.567,9.35-28.05
						c-1.417-20.967-19.833-37.117-41.083-35.7c-21.25,1.417-37.117,20.117-35.7,41.083
						C339.433,422.431,356.15,438.298,376.267,438.298z" />
          </g>
        </svg>
      </span>

      <span class="icon icon-checkmark"  >
        <svg version="1.1" id="Layer_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 511.999 511.999" style="enable-background: new 0 0 511.999 511.999;" xml:space="preserve">
          <g>
            <path d="M506.231,75.508c-7.689-7.69-20.158-7.69-27.849,0l-319.21,319.211L33.617,269.163c-7.689-7.691-20.158-7.691-27.849,0
					c-7.69,7.69-7.69,20.158,0,27.849l139.481,139.481c7.687,7.687,20.16,7.689,27.849,0l333.133-333.136
					C513.921,95.666,513.921,83.198,506.231,75.508z" />
          </g>
        </svg>
      </span>
    </span>

    <span class="button-bg">
      <span class="text text-before" style="font-family: 'Poppins', sans-serif;">Abrir Carrito</span>
    </span>
  </a>

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
                
                <div class="container" style="margin-right: auto; margin-left: auto;padding-left:30px; padding-right: 50px; width:100%;" >
                  
                    
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
                                        <li class="drop"><a href="frminicio.aspx">HOME</a></li>
                                             <li class="drop"><a href="frmNosotros.aspx">LA FÁBRICA</a></li>
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


                                        <li class="drop"><a href="#">BEER STORE</a>
                                            <ul class="dropdown">
                                                
                                                <asp:Repeater runat="server" ID="RepeaterMenuRubros">
                                             <ItemTemplate>
                                              <li><a href='<%# Eval("url")%>'><%# Eval("Descripcion")%></a></li>
                                        </ItemTemplate>
                                                </asp:Repeater>
                                                
                                            </ul>
                                        </li>
                                       <%-- <li  runat="server" visible="false" id="MenuMisConsultas"><a href="frmServicios.aspx">SERVICIOS</a></li>--%>
                                        <li><a href="frmContacto.aspx">CONTACTO</a></li>
                                                <li runat="server" id="MenuMisCompras"><a href="FrmMisCompras.aspx">MIS COMPRAS</a></li>
                                         <li style="display:block;" runat="server"  id="MenuIniciarSesion"><a style="color:#000;" href="frmLogin.aspx">INGRESAR</a></li>
                                        <li style="display:block;" runat="server" id="MenuCerrarSesion"><a style="color:#000;"  id="A1" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>

                                    </ul>
                                </nav>

                                 <div class="mobile-menu clearfix visible-xs visible-sm">
                                    <nav id="mobile_dropdown">
                                        <ul>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="frmInicio.aspx">HOME</a></li>
                                           <li><a style="font-family: 'Poppins', sans-serif;" href="frmNosotros.aspx">LA FÁBRICA</a></li>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="#">BEER STORE</a>
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
                                            
                                                  <li runat="server" id="MenuMisComprasMobile"><a style="font-family: 'Poppins', sans-serif;" href="frmMisCompras.aspx">MIS COMPRAS</a></li>
                                             <li style="display:block;" runat="server" id="MenuIniciarSesionMobile"><a style="color:#000; font-family: 'Poppins', sans-serif; color:#fff;" href="frmLogin.aspx">INGRESAR</a></li>
                                             <li style="display:block;" runat="server" id="MenuCerrarSesionMobile"><a style=" font-family: 'Poppins', sans-serif; color:#fff;"  id="A2" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>
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

                            <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2"  style=" padding: 0px 10px 0px 0px;"> 
                                <%--<div class="logo">
                                     <a href="frminicio.aspx"><img src="imagenes/copmaco.png"  style="max-height: 90px;" alt="logo images"></a>
                                </div>--%>
                                
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
    font-family: 'Poppins', sans-serif;
    text-align: left;">
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
            <div class="ht__bradcaump__wrap"style="background-color:black">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="bradcaump__inner">
                                <nav class="bradcaump-inner" style="background-color:black" >
                                  <a class="breadcrumb-item" href="frmInicio.aspx" style="color:white;">Principal</a>
                                  <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;"></i></span>
                                  <span class="breadcrumb-item active" style="color:white;">LA FÁBRICA</span>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Bradcaump area -->
        <!-- Start Product Grid -->
        <section class="htc__product__grid bg__white ptb--100" style="padding:20px;">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                     
                       
                  <div class="row">
                       <br /> <br />
                      <div class="col-sm-12 col-md-8">

                          <h1 id="TxtTitulo" runat="server">Linea Dorada S.A</h1>
                          <br />
                          <span id="TxtDescripcion1" runat="server" style="color:black;font-family: 'Poppins', sans-serif; ">
                              En nuestra empresa encontrara una gran linea de productos de excelente calidad, desde queso duro, semiduro y blando. Contamos con más de diez tipos de quesos.

Nuestro objetivo es seguir creciendo dia a dia y para crecer, solo es posible si el cliente elige los productos Linea Dorada S.A, es por eso que intentamos mejorar la calidad de nuestros exquisitos quesos. Hace 25 años que se creó esta empresa, con el objetivo del valor agregado a la produccion de leche de nuestros tambos.

Con el tiempo para satisfacer la demanda se empezó a comprar leche a otros tambos, siempre cuidando que cumplan los requisitos de calidad de leche que hemos establecido en menos de 20.000 ufc y menos de 280.000 celulas somaticas.

Con una filosofía tradicional y seria, el objetivo principal de Linea Dorada S.A es ofrecer un producto de máxima calidad, elaborado con las mejores materias primas y, como no, con el mejor servicio y trato a sus clientes.

Actualmente disponemos de las más avanzadas tecnologías, mejorando día a día e innovando en sus sistemas de Control, tanto de Calidad, como de Elaboración. Nuestra empresa sigue inmersa en el saber hacer, para poder ofrecérselo a sus amigos y clientes, mejorando continuamente y avanzando con los tiempos.

El Saber Hacer, nuestras Recetas y nuestros estrictos Controles de Calidad, han dado como resultado los más exquisitos Quesos, ampliamente reconocidos de manera nacional, y ganadores de numerosos premios a lo largo de los años.
                          </span>

                      </div>
                          <div class="col-sm-12 col-md-4">

                              <img id="ImgEmpresa" runat="server" src="http://www.lineadorada.com.ar/Imagenes/Empresa/1.jpg" />
                      </div>

                  </div>
                        <br /><br /><br />
                        <div class="row">
                            <center>
                            
                         
                                
                                               <span id="TxtDescripcion2" runat="server" style="color:black;font-family: 'Poppins', sans-serif; ">
                                    Elaboramos quesos que hacen los momentos más especiales de todas las ocasiones.

Quesos que dan gran sabor y gusto incluso a los usos más cotidianos, para hacerte sentir en cada instante la riqueza de lo auténtico.

Elaborados con dedicación artesana, pero también con la garantía y posibilidades que el saber de hoy nos ofrece para vivir mejor. Sólo así, todos y en todo momento podremos disfrutar de lo mejor. Linea Dorada S.A no es solo una empresa, todos su miembros son una gran familia que cada día cada uno de sus miembros aporta su experiencia y dedicación para elaborar productos cuidados desde la recogida de la leche, siempre fresca del día, hasta que sale el producto de nuestras instalaciones siempre puesto a punto para ser degustado por los consumidores.

El compromiso firme con la satisfacción de nuestros clientes hace de Linea Dorada una empresa orientada a conseguir el máximo nivel calidad. Un compromiso que se materializa en nuestras certificaciones de calidad que se aplican en cada fase del proceso de producción para garantizar la excelencia en cada uno de nuestros productos.

</span>
                          
                           
                            </center>
                           
                            
                      


                        </div>
                        
                                
                            <div class="row">

                                <div id="myCarousel" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
<%--  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>--%>

  <!-- Wrapper for slides -->
  <div class="carousel-inner">
      <asp:Repeater runat="server" ID="RepeaterImagenesNosotros"><ItemTemplate>
      <div class="<%# Eval("Clase")%>">
      <img src="<%# Eval("Imagen")%>" alt="Los Angeles">
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
                               
                                    <li><img style="width:100%; object-fit:cover;" src="<%# Eval("Imagen").ToString%>" alt="brand images"></li>
                          
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
 
     <footer id="htc__footer" style="background-color:#000">
            <!-- Start Footer Widget -->
            <div class="footer__container bg__black" background-color:#000 style ="background-image:url(Imagenes/PRUEBA2.PNG);background-size:100%;width:100%; background-repeat:no-repeat">
                <div class="container">
                    <div class="row" style="background-color:transparent;">
                        <!-- Start Single Footer Widget -->
                        <div class="col-md-4 col-sm-6 col-xs-12">
                            <div class="footer">
                                <h2 class="title__line--2"></h2>
                                <div class="ft__details">
                                    <p style="font-family: 'Poppins', sans-serif;color:#fff">Recordás cuando ibas a tu bar
                                        favorito y pedías esa pinta de birra que tanto te gustaba? Recordás el primer
                                        aroma que sentías cuando la llevabas a la boca? Y cuando la pasabas por la
                                        garganta? Esa sensación de mezcla entre gusto y regusto? Todo eso lo pensamos
                                        cada vez que armamos una receta. Disfruta cada trago. Hasta la birra!</p>
                                    <div class="ft__social__link">
                                        <ul class="social__link">
                                            <li style="display:none;"><a href="#" id="HrefTwitter" runat="server"><i
                                                        class="icon-social-twitter icons" style="color:#000;"></i></a>
                                            </li>

                                            <li><a href="#" id="HrefFacebook" runat="server"><i><img
                                                            style="width:33px; height:30px;"
                                                            src="imagenes/facebook.png" /></i></a></li>

                                            <li><a href="#" id="HrefInstagram" runat="server"><i><img
                                                            style="width:33px; height:30px"
                                                            src="imagenes/instagram.png" /></i></a></li>

                                            <li><a href="#" id="HrefWhatsapp" runat="server"><i><img
                                                            style="width:33px; height:30px"
                                                            src="imagenes/whatsapp.png" /></i></a></li>

                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- End Single Footer Widget -->
                        <!-- Start Single Footer Widget -->
                        <div class="col-md-4 col-sm-6 col-xs-12 xmt-40">
                            <div class="footer">
                                <h2 class="title__line--2"></h2>
                                <div class="ft__inner">
                                    <ul class="ft__list" style="font-family: 'Poppins', sans-serif;">
                                        <li><a style="color:#fff" href="frminicio.aspx">Home</a></li>
                                        <li><a style="color:#fff" href="frmnosotros.aspx">La Fábrica</a></li>
                                        <li><a style="color:#fff" href="frmContacto.aspx">Contacto</a></li>
                                        <%--    <li><a href="#">Terms  & Condition</a></li>
                                        <li><a href="#">Manufactures</a></li>--%>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-4 col-sm-6 col-xs-12 xmt-40 smt-40">
                            <div class="footer">
                                <h2 class="title__line--2"> </h2>
                                <div class="ft__inner">
                                    <div class="news__input">
                                        <span
                                            style="font-family: 'Poppins', sans-serif; color: #fff;font-size: 16px; line-height: 22px;">Recibir
                                            mas información</span>
                                        <br />
                                        <input type="text" id="TxtEmailContacto"
                                            style="font-family: 'Poppins', sans-serif;background-color:#fff" placeholder="Su email*">
                                        <div class="send__btn">

                                            <button class="fr__btn" style="border:none;background-color:#AFB0B8;color:#000;"
                                                onclick="EnviarEmailContacto()" id="btnEnviarEmailContacto"
                                                type="button">Enviar</button>
                                            <button class="fr__btn" style="border:none; display:none;background-color:#AFB0B8;color:#000;"
                                                id="btnEnviarEmailContactoGif" type="button">Enviando<img
                                                    src="Imagenes/btngif.gif"
                                                    style="height:20px; margin-left:10px;" /></button>



                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>

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
                                <p style="font-family: 'Poppins', sans-serif;">Copyright© <a style="color:#AFB0B8;"
                                        href="https://www.goodapps.com.ar/">GoodApps</a> 2019-2020. Todos los derechos
                                    reservados.</p>
                                <a style="display:none;" href="#"><img src="images/others/shape/paypol.png"
                                        alt="payment images"></a>
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
    <!-- Waypoints.min.js. -->


         <script>
                   var owl1 = $('#RepeaterImagenesNosotros');
                   owl1.owlCarousel({
                       items: 1,
                       loop: true,
                       margin: 10,
                       autoplay: true,
                       autoplayTimeout: 2000,
                       autoplayHoverPause: true
                   });
                   $('.play').on('click', function () {
                       owl1.trigger('play.owl.autoplay', [1000])
                   })
                   $('.stop').on('click', function () {
                       owl1.trigger('stop.owl.autoplay')
                   })
          </script>


           <script>
               var owl = $('#DivSponsors');
               owl.owlCarousel({
                   items: 3,
                   loop: true,
                   margin: 10,
                   autoplay: true,
                   autoplayTimeout: 3000
                   //autoplayHoverPause: true
               });
               $('.play').on('click', function () {
                   owl.trigger('play.owl.autoplay', [3000])
               })
               $('.stop').on('click', function () {
                   owl.trigger('stop.owl.autoplay')
               })

            </script>



    <script src="js/waypoints.min.js"></script>
    <!-- Main js file that contents all jQuery plugins activation. -->
    <script src="js/main.js"></script>

    

    

     <link href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.css" rel="stylesheet" type="text/css">
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.js"></script>

    
       
            <script src="CodigoCarrito.js"></script>


    <script>




        $(document).ready(function () {


         
        });



      
        function ClickBusqueda() {

            var busqueda = $('#TxtBusquedaGenerica').val();
            window.location = "frmBusquedaItems.aspx?Busqueda=" + busqueda;
        }

    </script>
    
               <div class="modal fade" id="ModalCarrito" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" style=" display:none;" aria-hidden="true">
	<div class="modal-dialog modal-lg" role="document">
		<div class="modal-content" style="    -webkit-background-clip: padding-box;
    background-clip: padding-box;
    border: 1px solid #999;
    border: 1px solid rgba(0,0,0,.2);
    border-radius: 6px;
    outline: 0;
    -webkit-box-shadow: 0 3px 9px rgba(0,0,0,.5);">
			<div class="modal-header">
				<button type="button" class="close" data-dismiss="modal" aria-label="Close">
					<span aria-hidden="true">&times;</span>
				</button>
				<h4 class="modal-title">Mi Carrito</h4>
			</div>



			<div id="ModalBodyCarrito" class="modal-body ">
			
              
                <table class="responsive-table striped" style="font-family: 'Poppins', sans-serif;">
                 <thead>
      <tr>
       
        <th></th>
        <th></th>
          <th></th>
          <th style="text-align:right;"></th>
          <th style="text-align:right;"></th>
          <th></th>
      </tr>
    </thead>
    <tbody id="GrillaCarrito">

        </tbody>

</table>
                
                <br />

                <span style="float:right; margin-right:20px; color:black; font-size:22px; font-family: 'Poppins', sans-serif;" id="TxtTotalGeneral"></span>
               

             <br />

                <hr />

                  <div class="row">
                 
                    <div class="col-md-4" style="margin-bottom:10px;">
                        <center>
                        <button type="button" style=" margin-right:20px; background:#B60A0A; font-family: 'Poppins', sans-serif; color:White; border:none; height:45px; width:170px;  min-width:170px;   font-size:14px;"  onclick="ValidarEliminarTodo()">VACIAR CARRITO</button>
                       </center>
                            </div>
                                       <div class="col-md-4" style="margin-bottom:10px;">
                                           <center>
                                            <button type="button" style="margin-right:20px; background:#1CA811; font-family: 'Poppins', sans-serif; color:White; border:none; height:45px; width:170px;  min-width:170px;    font-size:14px;"  onclick="ValidarFinalizarCompra()">FINALIZAR COMPRA</button>
                                          </center>
                                           </div>

                           <div class="col-md-4" style="margin-bottom:10px;">
                               <center>
                                                     <button type="button" style=" margin-right:20px; background:black; font-family: 'Poppins', sans-serif; color:White; border:none; height:45px; width:170px;  min-width:170px;  font-size:14px;"  onclick="CerrarModalCarrito()">CERRAR</button>
                              </center>
                               </div>



                </div>
                
                        
                       
               
   
           
              
            </div>



               <div id="ModalBodyGifCarrito" class="modal-body" style=" min-height:320px; display:none;">
             <center>
             <img src="https://www.pointcomfort.com/ResourcePackages/PointComfort/assets/dist/images/spinner.gif"  style=" margin-top:120px; height:50px;"/>
         </center>
                 </div>


		</div>
	</div>
</div>
         </form>
</body>

</html>