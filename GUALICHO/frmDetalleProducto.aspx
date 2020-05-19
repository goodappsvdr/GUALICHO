<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmDetalleProducto.aspx.vb" Inherits="GUALICHO.frmDetalleProducto" %>

<!doctype html>
<html class="no-js" lang="zxx">
 <head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>.:: GUALICHO ::.</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    
      <meta property="og:image"  runat="server" id="imagenRedesSociales"  content="" >
     <meta property="og:description" runat="server" id="DescripcionRedesSociales" content="">
    
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
    background:#ef7f2d;

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
                     
    </style>
<body>
     <form runat="server">
    <!--[if lt IE 8]>
        <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->  

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
                                        <li class="drop"><a href="frminicio.aspx">PRINCIPAL</a></li>
                                             <li class="drop"><a href="frmNosotros.aspx">LA FABRICA</a></li>
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
                                       <%-- <li  runat="server" visible="false" id="MenuMisConsultas"><a href="frmServicios.aspx">SERVICIOS</a></li>--%>
                                        <li><a href="frmContacto.aspx">CONTACTO</a></li>
                                         <li style="display:none;" runat="server" visible="false" id="MenuIniciarSesion"><a style="color:#ef7f2d;" href="frmLogin.aspx">INGRESAR</a></li>
                                        <li style="display:none;" runat="server" visible="false" id="MenuCerrarSesion"><a style="color:#ef7f2d;"  id="A1" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>

                                    </ul>
                                </nav>

                                <div class="mobile-menu clearfix visible-xs visible-sm">
                                    <nav id="mobile_dropdown">
                                        <ul>
                                            <li><a href="frmInicio.aspx">PRINCIPAL</a></li>
                                           <li><a href="frmNosotros.aspx">NOSOTROS</a></li>
                                            <li><a href="#">RUBROS</a>
                                                <ul>
                                                     <asp:Repeater runat="server" ID="RepeaterMenuRubrosMobile">
                                             <ItemTemplate>
                                              <li><a href='<%# Eval("url")%>'><%# Eval("Descripcion")%></a></li>
                                        </ItemTemplate>
                                                </asp:Repeater>
                                                </ul>
                                            </li>
                                             <li  runat="server" visible="false" id="MenuMisConsultasMobile"><a href="FrmServicios.aspx">SERVICIOS</a></li>
                                            <li><a href="frmContacto.aspx">CONTACTO</a></li>
                                             <li style="display:none;" runat="server" visible="false" id="MenuIniciarSesionMobile"><a style="color:#ef7f2d;" href="frmLogin.aspx">INICIAR SESIÓN</a></li>
                                             <li style="display:none;" runat="server" visible="false" id="MenuCerrarSesionMobile"><a style="color:#ef7f2d;"  id="A2" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>
                                        </ul>
                                    </nav>
                                </div>  
                            </div>
                            <div class="col-md-2 col-lg-2 col-sm-4 col-xs-4">
                                <div class="header__right" style="padding-right: 40px;">
                                    <div class="header__search search search__open">
                                        <a href="#"><i class="icon-magnifier icons"></i></a>
                                    </div>
                                    <div class="header__account search search__open" style="cursor:pointer;">
                                    
                                
                            
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
                                    <input placeholder="Qué estas buscando?" id="TxtBusquedaGenerica"  type="text" style="background: #fff none repeat scroll 0 0; border: medium none; color: #333; font-size: 25px; font-weight: 300; height: 60px; margin-top: 50px; line-height: 60px; padding: 0 70px 0 20px; text-align: left; font-family: 'Poppins', sans-serif; ">
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
            <div class="shopping__cart">
                <div class="shopping__cart__inner">
                    <div class="offsetmenu__close__btn">
                        <a href="#"><i class="zmdi zmdi-close"></i></a>
                    </div>
                    <div class="shp__cart__wrap">
                        <div class="shp__single__product">
                            <div class="shp__pro__thumb">
                                <a href="#">
                                    <img src="images/product-2/sm-smg/1.jpg" alt="product images">
                                </a>
                            </div>
                            <div class="shp__pro__details">
                                <h2><a href="<%# Eval("url")%>">BO&Play Wireless Speaker</a></h2>
                                <span class="quantity">QTY: 1</span>
                                <span class="shp__price">$105.00</span>
                            </div>
                            <div class="remove__btn">
                                <a href="#" title="Remove this item"><i class="zmdi zmdi-close"></i></a>
                            </div>
                        </div>
                        <div class="shp__single__product">
                            <div class="shp__pro__thumb">
                                <a href="#">
                                    <img src="images/product-2/sm-smg/2.jpg" alt="product images">
                                </a>
                            </div>
                            <div class="shp__pro__details">
                                <h2><a href="<%# Eval("url")%>">Brone Candle</a></h2>
                                <span class="quantity">QTY: 1</span>
                                <span class="shp__price">$25.00</span>
                            </div>
                            <div class="remove__btn">
                                <a href="#" title="Remove this item"><i class="zmdi zmdi-close"></i></a>
                            </div>
                        </div>
                    </div>
                    <ul class="shoping__total">
                        <li class="subtotal">Subtotal:</li>
                        <li class="total__price">$130.00</li>
                    </ul>
                    <ul class="shopping__btn">
                        <li><a href="cart.html">View Cart</a></li>
                        <li class="shp__checkout"><a href="checkout.html">Checkout</a></li>
                    </ul>
                </div>
            </div>
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
                                  <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;" ></i></span>
                                  <a class="breadcrumb-item" href="product-grid.html" style="color:white;">Producto</a>
                                   <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;"></i></span>
                                     <span class="breadcrumb-item active" style="color:white;" id="TxtProducto" runat="server">Producto</span>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Bradcaump area -->
        <!-- Start Product Details Area -->
        <section class="htc__product__details bg__white ptb--100">
            <!-- Start Product Details Top -->
            <div class="htc__product__details__top">
                <div class="container">
                    <div class="row">
                        <div class="col-md-5 col-lg-5 col-sm-12 col-xs-12">
                            <div class="htc__product__details__tab__content">
                                <!-- Start Product Big Images -->
                                <div class="product__big__images">
                                    <div class="portfolio-full-image tab-content">
                                       
                                        <asp:Repeater runat="server" id="RepeaterImgGrandes"><ItemTemplate>
                                        <div role="tabpanel" class="<%# Eval("Clase")%>" id="img-tab-<%# Eval("ID")%>">
                                            <img src="<%# Eval("Imagen")%>" style=" width:510px; height:550px; object-fit:cover;" alt="full-image">
                                        </div>
                                      </ItemTemplate></asp:Repeater>
                                        
                                        
                                        <%-- <div role="tabpanel" class="tab-pane fade" id="img-tab-2">
                                            <img src="images/product-2/big-img/2.jpg" alt="full-image">
                                        </div>
                                        <div role="tabpanel" class="tab-pane fade" id="img-tab-3">
                                            <img src="images/product-2/big-img/3.jpg" alt="full-image">
                                        </div>--%>
                                 
                                        
                                    </div>
                                </div>
                                <!-- End Product Big Images -->
                                <!-- Start Small images -->
                                <ul class="product__small__images" role="tablist">
                                   
                                       <asp:Repeater runat="server" id="RepeaterImgChicas"><ItemTemplate>
                                    <li role="presentation" class="<%# Eval("Clase2")%>">
                                        <a href="#img-tab-<%# Eval("ID")%>" role="tab" data-toggle="tab">
                                            <img src="<%# Eval("Imagen")%>" alt="small-image" style=" width:60px; height:86px; object-fit:cover;">
                                        </a>
                                    </li>
                                      </ItemTemplate></asp:Repeater>

                                 <%--   <li role="presentation" class="pot-small-img">
                                        <a href="#img-tab-2" role="tab" data-toggle="tab">
                                            <img src="images/product-2/sm-img-3/1.jpg" alt="small-image">
                                        </a>
                                    </li>
                                    <li role="presentation" class="pot-small-img">
                                        <a href="#img-tab-3" role="tab" data-toggle="tab">
                                            <img src="images/product-2/sm-img-3/2.jpg" alt="small-image">
                                        </a>
                                    </li>--%>
                                </ul>
                                <!-- End Small images -->
                            </div>
                        </div>
                        <div class="col-md-7 col-lg-7 col-sm-12 col-xs-12 smt-40 xmt-40">
                            <div class="ht__product__dtl">
                                <h2 id="TxtTitulo" runat="server" style="color:#ef7f2d; font-family: 'Poppins', sans-serif;">jean shirt to sassy girl</h2>
                                <h6 >Marca: <i><span style="font-family: 'Poppins', sans-serif;" id="TxtMarca" runat="server">MNG001</span></i></h6>
                                      <h6 >Rubro: <i><span style="font-family: 'Poppins', sans-serif;" id="TxtRubro" runat="server">MNG001</span></i></h6>
                                                       <h6 >Sub Rubro: <i><span style="font-family: 'Poppins', sans-serif;" id="TxtSubRubro" runat="server">MNG001</span></i></h6>
                              <%--  <ul class="rating">
                                    <li><i class="icon-star icons"></i></li>
                                    <li><i class="icon-star icons"></i></li>
                                    <li><i class="icon-star icons"></i></li>
                                    <li class="old"><i class="icon-star icons"></i></li>
                                    <li class="old"><i class="icon-star icons"></i></li>
                                </ul>--%>
                            
                                <div class="ht__pro__desc">
                                    <div class="sin__desc">
                                   
                                    
                                    </div><br />

                                     <ul  class="pro__prize">
                                   
                                    <li  style="font-size:35px; color:#ef7f2d;"  id="TxtPrecio" runat="server"></li>
                                </ul><br /><br />


                                        <button runat="server" id="CmdAbrirConsulta" type="button" style=" background:#ef7f2d; font-family: 'Poppins', sans-serif; color:White; border:none; height:45px; width:350px;    font-size:14px;  " data-toggle="modal" data-target="#miModal">Hacer una consulta</button>

                                   <%-- <div class="sin__desc align--left">
                                        <p><span>color:</span></p>
                                        <ul class="pro__color">
                                            <li class="red"><a href="#">red</a></li>
                                            <li class="green"><a href="#">green</a></li>
                                            <li class="balck"><a href="#">balck</a></li>
                                        </ul>
                                        <div class="pro__more__btn">
                                            <a href="#">more</a>
                                        </div>
                                    </div>--%>
                                  <%--  <div class="sin__desc align--left">
                                        <p><span>size</span></p>
                                        <select class="select__size">
                                            <option>s</option>
                                            <option>l</option>
                                            <option>xs</option>
                                            <option>xl</option>
                                            <option>m</option>
                                            <option>s</option>
                                        </select>
                                    </div>--%>
                                 
                                    <hr />
                                    <div class="sin__desc product__share__link">
                                        <p><span>Compartí este producto</span></p>
                                         <div class="a2a_kit a2a_kit_size_32 a2a_default_style" style="">

<a class="a2a_button_facebook" style="border: none; width: 35px;"><img src="images/iconofacebook.png"/></a>
<!--<a class="a2a_button_instagram"  style="border: none;  width: 35px;"><img src="images/iconoinstagram.png"/></a>-->                     
<a class="a2a_button_twitter"  style="border: none;  width: 35px;"><img src="images/iconotwitter.png"/></a>
<a class="a2a_button_whatsapp" style="border: none; width: 35px;"><img src="images/iconowhatsapp.png"/></a>
</div>
                       
                           
     
<script>
    product = document.getElementsByName("prod")[0].value;
    var a2a_config = a2a_config || {};
    a2a_config.linkname = product;
    a2a_config.locale = "es-AR";
    a2a_config.prioritize = ["facebook", "twitter", "whatsapp", "facebook_messenger", "sms"];
</script>
<script async src="https://static.addtoany.com/menu/page.js"></script>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Product Details Top -->
        </section>
        <!-- End Product Details Area -->
        <!-- Start Product Description -->
        <section class="htc__produc__decription bg__white">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <!-- Start List And Grid View -->
                        <ul class="pro__details__tab" role="tablist">
                            <li role="presentation" class="description active"><a href="#description" role="tab" data-toggle="tab">Detalle</a></li>
                            <li role="presentation" class="review"><a href="#review" role="tab" data-toggle="tab">Extras</a></li>
                          <%--  <li role="presentation" class="shipping"><a href="#shipping" role="tab" data-toggle="tab">shipping</a></li>--%>
                        </ul>
                        <!-- End List And Grid View -->
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <div class="ht__pro__details__content">
                            <!-- Start Single Content -->
                            <div role="tabpanel" id="description" class="pro__single__content tab-pane fade in active">
                                <div class="pro__tab__content__inner">
                                    <p style="font-family: 'Poppins', sans-serif;"  runat="server" id="TxtDetalleProducto"></p>

                                </div>
                            </div>
                            <!-- End Single Content -->
                            <!-- Start Single Content -->
                            <div role="tabpanel" id="review" class="pro__single__content tab-pane fade">
                                <div class="pro__tab__content__inner">
                                    <p style="font-family: 'Poppins', sans-serif;"  runat="server" id="TxtExtrasProducto"></p>
                                </div>
                            </div>
                            <!-- End Single Content -->
                            <!-- Start Single Content -->
                         <%--   <div role="tabpanel" id="shipping" class="pro__single__content tab-pane fade">
                                <div class="pro__tab__content__inner">
                                    <p>Formfitting clothing is all about a sweet spot. That elusive place where an item is tight but not clingy, sexy but not cloying, cool but not over the top. Alexandra Alvarez’s label, Alix, hits that mark with its range of comfortable, minimal, and neutral-hued bodysuits.</p>
                                    <h4 class="ht__pro__title">Description</h4>
                                    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem</p>
                                    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.</p>
                                    <h4 class="ht__pro__title">Standard Featured</h4>
                                    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem</p>
                                </div>
                            </div>--%>
                            <!-- End Single Content -->
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Product Description -->
        <!-- Start Product Area -->
<%--        <section class="htc__product__area--2 pb--100 product-details-res">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="section__title--2 text-center">
                            <h2 class="title__line">New Arrivals</h2>
                            <p>But I must explain to you how all this mistaken idea</p>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="product__wrap clearfix">

                        <div class="col-md-3 col-lg-3 col-sm-6 col-xs-12">
                            <div class="category">
                                <div class="ht__cat__thumb">
                                    <a href="<%# Eval("url")%>">
                                        <img src="images/product/1.jpg" alt="product images">
                                    </a>
                                </div>
                                <div class="fr__hover__info">
                                    <ul class="product__action">
                                        <li><a href="wishlist.html"><i class="icon-heart icons"></i></a></li>

                                        <li><a href="cart.html"><i class="icon-handbag icons"></i></a></li>

                                        <li><a href="#"><i class="icon-shuffle icons"></i></a></li>
                                    </ul>
                                </div>
                                <div class="fr__product__inner">
                                    <h4><a href="<%# Eval("url")%>">Product Title Here </a></h4>
                                    <ul class="fr__pro__prize">
                                        <li class="old__prize">$30.3</li>
                                        <li>$25.9</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                     

                        <div class="col-md-3 col-lg-3 col-sm-6 col-xs-12">
                            <div class="category">
                                <div class="ht__cat__thumb">
                                    <a href="<%# Eval("url")%>">
                                        <img src="images/product/2.jpg" alt="product images">
                                    </a>
                                </div>
                                <div class="fr__hover__info">
                                    <ul class="product__action">
                                        <li><a href="wishlist.html"><i class="icon-heart icons"></i></a></li>

                                        <li><a href="cart.html"><i class="icon-handbag icons"></i></a></li>

                                        <li><a href="#"><i class="icon-shuffle icons"></i></a></li>
                                    </ul>
                                </div>
                                <div class="fr__product__inner">
                                    <h4><a href="<%# Eval("url")%>">Product Title Here </a></h4>
                                    <ul class="fr__pro__prize">
                                        <li class="old__prize">$30.3</li>
                                        <li>$25.9</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                     
                        <div class="col-md-3 col-lg-3 col-sm-6 col-xs-12">
                            <div class="category">
                                <div class="ht__cat__thumb">
                                    <a href="<%# Eval("url")%>">
                                        <img src="images/product/3.jpg" alt="product images">
                                    </a>
                                </div>
                                <div class="fr__hover__info">
                                    <ul class="product__action">
                                        <li><a href="wishlist.html"><i class="icon-heart icons"></i></a></li>

                                        <li><a href="cart.html"><i class="icon-handbag icons"></i></a></li>

                                        <li><a href="#"><i class="icon-shuffle icons"></i></a></li>
                                    </ul>
                                </div>
                                <div class="fr__product__inner">
                                    <h4><a href="<%# Eval("url")%>">Product Title Here </a></h4>
                                    <ul class="fr__pro__prize">
                                        <li class="old__prize">$30.3</li>
                                        <li>$25.9</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                   
                        <div class="col-md-3 col-lg-3 col-sm-6 col-xs-12">
                            <div class="category">
                                <div class="ht__cat__thumb">
                                    <a href="<%# Eval("url")%>">
                                        <img src="images/product/4.jpg" alt="product images">
                                    </a>
                                </div>
                                <div class="fr__hover__info">
                                    <ul class="product__action">
                                        <li><a href="wishlist.html"><i class="icon-heart icons"></i></a></li>

                                        <li><a href="cart.html"><i class="icon-handbag icons"></i></a></li>

                                        <li><a href="#"><i class="icon-shuffle icons"></i></a></li>
                                    </ul>
                                </div>
                                <div class="fr__product__inner">
                                    <h4><a href="<%# Eval("url")%>">Product Title Here </a></h4>
                                    <ul class="fr__pro__prize">
                                        <li class="old__prize">$30.3</li>
                                        <li>$25.9</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                       
                </div>
            </div>
        </section>--%>
        <!-- End Product Area -->
        <!-- Start Banner Area -->
     

              
        <div class="htc__brand__area bg__cat--4">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="ht__brand__inner">
                            <ul class="brand__list owl-carousel clearfix">
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
                                            <li style="display:none;"><a href="#" id="HrefTwitter" runat="server"><i class="icon-social-twitter icons" style="color:#ef7f2d;"></i></a></li>

                                             <li><a href="#" id="HrefFacebook" runat="server"><i><img style="width:38px; height:35px"  src="images/iconofacebooknaranja.png" /></i></a></li>

                                            <li><a href="#" id="HrefInstagram" runat="server"><i><img style="width:38px; height:35px"  src="images/iconoinstagramnaranja.png" /></i></a></li>

                                            <li><a href="#" id="HrefWhatsapp" runat="server"><i><img style="width:38px; height:35px"  src="images/iconowhatsappnaranja.png" /></i></a></li>

                                             

                                             
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
    <script src="js/waypoints.min.js"></script>
    <!-- Main js file that contents all jQuery plugins activation. -->
    <script src="js/main.js"></script>


                      <div class="modal fade" id="miModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" style=" display:none;" aria-hidden="true">
	<div class="modal-dialog" role="document">
		<div class="modal-content" style="    -webkit-background-clip: padding-box;
    background-clip: padding-box;
    border: 1px solid #999;
    border: 1px solid rgba(0,0,0,.2);
    border-radius: 6px;
    outline: 0;
    -webkit-box-shadow: 0 3px 9px rgba(0,0,0,.5);
    /* box-shadow: 0 3px 9px rgba(0,0,0,.5); */">
			<div class="modal-header">
				<button type="button" class="close" data-dismiss="modal" aria-label="Close">
					<span aria-hidden="true">&times;</span>
				</button>
				<h4 class="modal-title" id="myModalLabel">Consulta</h4>
			</div>
			<div id="ModalBody" class="modal-body " runat="server">
			
             <br />


                <input id="TxtNombre" runat="server" placeholder="Nombre y Apellido" style="border:none; border-bottom:1px solid #ef7f2d; color:#ef7f2d; width:100%; font-size:14px;font-family: 'Poppins', sans-serif;" />
                <br />  <br />
                <input id="TxtEmail" runat="server" placeholder="Email" style="border:none; border-bottom:1px solid #ef7f2d; color:#ef7f2d; width:100%; font-size:14px;font-family: 'Poppins', sans-serif;" />
                 <br />  <br />
                <input id="TxtTelefono" runat="server" placeholder="Teléfono" style="border:none; border-bottom:1px solid #ef7f2d; color:#ef7f2d; width:100%; font-size:14px;font-family: 'Poppins', sans-serif;" />
                 <br />  <br />
                <textarea id="TxtMensaje" placeholder="Escribe tu consulta sobre este producto..." style="border:none; border-bottom:1px solid #ef7f2d; color:#ef7f2d; width:100%; font-size:14px;font-family: 'Poppins', sans-serif; background:white;"></textarea>
                    <br />  <br />

                

                                        <button onclick="EnviarConsulta()" id="cmdEnviarConsulta" type="button" style=" background:#ef7f2d; font-family: 'Poppins', sans-serif; color:White; border:none; height:45px; width:100%;    font-size:14px;  ">Enviar</button>
                        <%--     <asp:TextBox ID="txtNombre" title="Se necesita un nombre" class="span1" Width="96%" required  placeholder="Nombre y Apellido"  runat="server"></asp:TextBox>
                                             <br />
                             <asp:TextBox ID="txtTelefono" class="span1" Width="96%" required  placeholder="Telefono"  runat="server"></asp:TextBox>
                            <br />
                             <asp:TextBox ID="txtEmail" type="email" pattern="^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$" class="span1" Width="96%" required  placeholder="Email"  runat="server"></asp:TextBox>
                             <br />
                                <asp:TextBox ID="txtMensaje" class="span1" Width="96%" Height="150px" style="font-size:14px; "  placeholder="Mensaje"  runat="server" TextMode="MultiLine"></asp:TextBox>
                                 <br />
                                 <asp:Button Visible="true" ID="cmdConsultar"  style=" background:#203f56; color:White; border:none; height:45px; width:99%;    font-size:14px;  " runat="server" Text="Enviar Consulta"></asp:Button>
		
        
        	--%>
            </div>

               <div id="ModalBodyGif" class="modal-body" style=" min-height:320px; display:none;">
             <center>
             <img src="https://www.pointcomfort.com/ResourcePackages/PointComfort/assets/dist/images/spinner.gif"  style=" margin-top:120px; height:50px;"/>
         </center>
                 </div>


		</div>
	</div>
</div>

         </form>

</body>

    


     <link href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.css" rel="stylesheet" type="text/css">
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.js"></script>

    
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>

    <script>

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
                            text: 'Pronto seras respondido/a',
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


        function EnviarEmailContacto() {

            var Email = $('#TxtEmailContacto').val();


            var par = "{\"Email\":\"" + Email + "\"}";


            var payload = { cadena: par };


            $.ajax({
                type: "POST",
                url: "FrmDetalleProducto.aspx/EnviarEmailContacto_Ws",
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

        function ClickBusqueda() {

            var busqueda = $('#TxtBusquedaGenerica').val();
            window.location = "frmBusquedaItems.aspx?Busqueda=" + busqueda;
        }
    </script>

</html>