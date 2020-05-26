<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRubros.aspx.vb" Inherits="GUALICHO.frmRubros" %>

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
                                             <li class="drop"><a href="frmNosotros.aspx">La Fábrica</a></li>
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
                                         <li style="display:none;" runat="server" visible="false" id="MenuIniciarSesion"><a style="color:#000;" href="frmLogin.aspx">INGRESAR</a></li>
                                        <li style="display:none;" runat="server" visible="false" id="MenuCerrarSesion"><a style="color:#000;"  id="A1" runat="server"  onserverclick="CerrarSesion">SALIR</a></li>

                                    </ul>
                                </nav>

                                   <div class="mobile-menu clearfix visible-xs visible-sm">
                                    <nav id="mobile_dropdown">
                                        <ul>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="frmInicio.aspx">PRINCIPAL</a></li>
                                           <li><a style="font-family: 'Poppins', sans-serif;" href="frmNosotros.aspx">La Fábrica</a></li>
                                            <li><a style="font-family: 'Poppins', sans-serif;" href="#">PRODUCTOS</a>
                                                <ul>
                                                     <asp:Repeater runat="server" ID="RepeaterMenuRubrosMobile">
                                             <ItemTemplate>
                                              <li><a style="font-family: 'Poppins', sans-serif;" href='<%# Eval("url")%>'>CONSULTAR</a></li>
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
     <div class="search__area" style="height: 170px;">
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
             <div class="ht__bradcaump__wrap"style="background-color:black">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="bradcaump__inner">
                                <nav class="bradcaump-inner" style="background-color:black" >
                                  <a class="breadcrumb-item" href="frmInicio.aspx" style="color:white;">Principal</a>
                                  <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;"></i></span>
                                  <span class="breadcrumb-item active" style="color:white;">Productos</span>
                                           <span class="brd-separetor"><i class="zmdi zmdi-chevron-right" style="color:white;"></i></span>
                                     <span class="breadcrumb-item active" style="color:white;" id="txtRubro" runat="server">Productos</span>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Bradcaump area -->
        <!-- Start Product Grid -->
        <section class="htc__product__grid bg__white ptb--100">
            <div class="container">
                <div class="row">
                    <div class="col-lg-9 col-lg-push-3 col-md-9 col-md-push-3 col-sm-12 col-xs-12">
                             <%--  <h4 style="color: #212121;font-size: 14px; font-weight: 600;  text-transform: uppercase;">MARCAS</h4>--%>
                        <div class="htc__product__rightidebar" style="">
                            <div class="htc__grid__top">
                         
                                <div class="htc__select__option">
                                
                                      

                                  <%--  <select style="font-family: 'Poppins', sans-serif; " onchange="CantidadItems2()" class="ht__select"
                                         data-jplist-control="select-filter"
                                data-group="group1"
                                data-name="tags-filter">
                                        
                                       

                                        <option value="0" data-path="default">MOSTRAR TODOS</option>
                                       
                                     <asp:Repeater ID="RepeaterMarcas" runat="server">
                        <ItemTemplate>
                            <option value="<%# Eval("descripcion").ToString.ToLower%>"
                                    data-path=".<%# Eval("marcaCombo").ToString.ToLower%>"> <%# Eval("descripcion").ToString%></option>
                                    </ItemTemplate>
                                    </asp:Repeater>
                                  
                                        
                                    </select>--%>
                                


                                   <%-- <select class="ht__select">
                                        <option>Show by</option>
                                        <option>Sort by popularity</option>
                                        <option>Sort by average rating</option>
                                        <option>Sort by newness</option>
                                    </select>--%>
                                
                                
                                
                                
                                </div>
                                <div class="ht__pro__qun">
                                    <span style="font-family: 'Poppins', sans-serif; " id="TxtCantidadItemTop"></span>
                                  



                                </div>
                                <!-- Start List And Grid View -->
                                <ul class="view__mode" role="tablist">
                                    <li style="display:none;" role="presentation" class="grid-view active"><a href="#grid-view" role="tab" data-toggle="tab"><i class="zmdi zmdi-grid"></i></a></li>
                                    <li style="display:none;" role="presentation" class="list-view"><a href="#list-view" role="tab" data-toggle="tab"><i class="zmdi zmdi-view-list"></i></a></li>
                                </ul>
                                <!-- End List And Grid View -->
                            </div>
                            <!-- Start Product View -->
                            <div class="row" data-jplist-group="group1"  >
                                <div class="shop__grid__view__wrap">
                                    <div role="tabpanel" id="grid-view" class="single-grid-view tab-pane fade in active clearfix">
                                        <!-- Start Single Product -->
                                     
                                            <asp:Repeater ID="RepeaterItems" runat="server">
                        <ItemTemplate>
                      
                          <%--  style="display: inline-flex; margin-right:33px;"--%>
                            
                                        <div class="col-md-4 col-lg-4 col-sm-6 col-xs-12" data-jplist-item>
                                            <div >
                                            <div class="category">
                                                <center>

                                                <div class="ht__cat__thumb" style=" max-height:345.16px">
                                                    <a href='<%# Eval("url")%>'>
                                                        <img src="<%# Eval("Imagen")%>" style=" height:344px; object-fit:cover;" alt="product images">
                                                    </a>
                                                </div>
                                             <div class="fr__hover__info">
                                        <ul class="product__action">
                                             <li><a href='<%# Eval("url")%>'  style="font-family: 'Poppins', sans-serif; line-height: 3.7; width:120px;">Ver detalles</a></li>

<%--                                            <li><a href="cart.html"><i class="icon-handbag icons"></i></a></li>

                                            <li><a href="#"><i class="icon-shuffle icons"></i></a></li>--%>
                                        </ul>
                                    </div>
                                                <div class="fr__product__inner" >
                                                    <h4><a href="<%# Eval("url")%>" style="font-family: 'Poppins', sans-serif; font-weight:lighter; "><%# Eval("producto")%></a></h4>
                                        <ul class="fr__pro__prize">
                                            <li style="font-family: 'Poppins', sans-serif; color:#000; font-weight:700;">CONSULTAR</li>
                                          <span style="display:none" class="badge badge-info <%# Eval("marcas").ToString.ToLower%>"><%# Eval("marcas").ToString.ToLower%></span>
                                        </ul>
                                                    
                                                    
                                                
                                                </div>
                                        
                                                </center>
                                            </div>
                                        </div></div>
                                   </ItemTemplate>
                            </asp:Repeater>

                                        <div class="col text-center" style="font-family: 'Poppins', sans-serif; font-size:20px; " data-jplist-control="no-results" data-group="group1" data-name="no-results">Busqueda sin resultados</div>

                                    </div>
              
                                    
                                    
                                    <%--<div role="tabpanel" id="list-view" class="single-grid-view tab-pane fade clearfix">
                                        <div class="col-xs-12">
                                            <div class="ht__list__wrap">
                                                <!-- Start List Product -->
                                                <div class="ht__list__product">
                                                    <div class="ht__list__thumb">
                                                        <a href="<%# Eval("url")%>"><img src="images/product-2/pro-1/1.jpg" alt="product images"></a>
                                                    </div>
                                                    <div class="htc__list__details">
                                                        <h2><a href="<%# Eval("url")%>">Product Title Here </a></h2>
                                                        <ul  class="pro__prize">
                                                            <li class="old__prize">$82.5</li>
                                                            <li>$75.2</li>
                                                        </ul>
                                                        <ul class="rating">
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                        </ul>
                                                        <p>Lorem ipsum dolor sit amet, consectetur adipisLorem ipsum dolor sit amet, consec adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqul Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                                        <div class="fr__list__btn">
                                                            <a class="fr__btn" href="cart.html">Add To Cart</a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- End List Product -->
                                                <!-- Start List Product -->
                                                <div class="ht__list__product">
                                                    <div class="ht__list__thumb">
                                                        <a href="<%# Eval("url")%>"><img src="images/product-2/pro-1/2.jpg" alt="product images"></a>
                                                    </div>
                                                    <div class="htc__list__details">
                                                        <h2><a href="<%# Eval("url")%>">Product Title Here </a></h2>
                                                        <ul  class="pro__prize">
                                                            <li class="old__prize">$82.5</li>
                                                            <li>$75.2</li>
                                                        </ul>
                                                        <ul class="rating">
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                        </ul>
                                                        <p>Lorem ipsum dolor sit amet, consectetur adipisLorem ipsum dolor sit amet, consec adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqul Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                                        <div class="fr__list__btn">
                                                            <a class="fr__btn" href="cart.html">Add To Cart</a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- End List Product -->
                                                <!-- Start List Product -->
                                                <div class="ht__list__product">
                                                    <div class="ht__list__thumb">
                                                        <a href="<%# Eval("url")%>"><img src="images/product-2/pro-1/3.jpg" alt="product images"></a>
                                                    </div>
                                                    <div class="htc__list__details">
                                                        <h2><a href="<%# Eval("url")%>">Product Title Here </a></h2>
                                                        <ul  class="pro__prize">
                                                            <li class="old__prize">$82.5</li>
                                                            <li>$75.2</li>
                                                        </ul>
                                                        <ul class="rating">
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                        </ul>
                                                        <p>Lorem ipsum dolor sit amet, consectetur adipisLorem ipsum dolor sit amet, consec adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqul Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                                        <div class="fr__list__btn">
                                                            <a class="fr__btn" href="cart.html">Add To Cart</a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- End List Product -->
                                                <!-- Start List Product -->
                                                <div class="ht__list__product">
                                                    <div class="ht__list__thumb">
                                                        <a href="<%# Eval("url")%>"><img src="images/product-2/pro-1/4.jpg" alt="product images"></a>
                                                    </div>
                                                    <div class="htc__list__details">
                                                        <h2><a href="<%# Eval("url")%>">Product Title Here </a></h2>
                                                        <ul  class="pro__prize">
                                                            <li class="old__prize">$82.5</li>
                                                            <li>$75.2</li>
                                                        </ul>
                                                        <ul class="rating">
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                            <li class="old"><i class="icon-star icons"></i></li>
                                                        </ul>
                                                        <p>Lorem ipsum dolor sit amet, consectetur adipisLorem ipsum dolor sit amet, consec adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqul Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                                        <div class="fr__list__btn">
                                                            <a class="fr__btn" href="cart.html">Add To Cart</a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- End List Product -->
                                            </div>
                                        </div>
                                    </div>--%>
                                </div>
                            </div>
                            <!-- End Product View -->
                        </div>
                        <!-- Start Pagenation -->
                        <div class="row">
                       <%--     <div class="col-xs-12">
                                <ul class="htc__pagenation">
                                   <li><a href="#"><i class="zmdi zmdi-chevron-left"></i></a></li> 
                                   <li><a href="#">1</a></li> 
                                   <li class="active"><a href="#">3</a></li>   
                                   <li><a href="#">19</a></li> 
                                   <li><a href="#"><i class="zmdi zmdi-chevron-right"></i></a></li> 
                                </ul>
                            </div>--%>
                      
                   <div class="col-xs-12">
               <center>
                   <br /><br /><br />
                        <div class="col flex">
                            <!-- pagination control -->
                            <nav
                                    data-jplist-control="pagination"
                                    data-group="group1"
                                    data-items-per-page="9"
                                    data-current-page="0"
                                    data-disabled-class="disabled"
                                    data-selected-class="active"
                                    data-name="pagination1"
                                    class="mb-2 mb-lg-0">

                                <!-- first and previous buttons -->
                                <ul class="pagination d-inline-flex">
                                    <li class="page-item d-none d-sm-none d-lg-inline-block" data-type="first"><a class="page-link" href="#"><i class="zmdi zmdi-chevron-left" style="color:#000;"></i><i class="zmdi zmdi-chevron-left" style="color:#000;"></i></a></li>
                                    <li class="page-item" data-type="prev"><a class="page-link" href="#"><i class="zmdi zmdi-chevron-left" style="color:#000;"></i></a></li>
                                </ul>

                                <!-- pages buttons -->
                                <ul class="pagination d-none d-sm-none d-lg-inline-flex" style=" margin-left:2.4px;" data-type="pages">
                                    <li class="page-item" data-type="page"><a class="page-link" href="#">{pageNumber}</a></li>
                                </ul>

                                <!-- next and last buttons -->
                                <ul class="pagination d-inline-flex" style=" margin-left:4px; ">
                                    <li class="page-item" data-type="next"><a class="page-link" href="#"><i class="zmdi zmdi-chevron-right" style="color:#000;"></i></a></li>
                                    <li class="page-item d-none d-sm-none d-lg-inline-block" data-type="last"><a class="page-link" href="#"><i class="zmdi zmdi-chevron-right" style="color:#000;"></i><i class="zmdi zmdi-chevron-right" style="color:#000;"></i></a></li>
                                </ul>

                                <!-- information labels -->
                                <span id="TxtCantidadItem" data-type="info" class="d-none d-sm-none d-lg-inline-flex badge badge-secondary" style=" margin-left:20px; margin-top: -70px;color:#000; background:white; border:none;font-family: 'Poppins',sans-serif;">
                                {endItem} de {itemsNumber}
                                </span>

                                <!-- items per page dropdown -->
                                <div class="dropdown d-inline-flex ml-3" 
                                     data-type="items-per-page-dd"
                                     data-opened-class="show">

                                    <button style=" display:none;"
                                            data-type="panel"
                                            class="btn btn-primary dropdown-toggle"
                                            type="button">Items per page</button>

                                    <div
                                            data-type="content"
                                            class="dropdown-menu"
                                            aria-labelledby="dropdownMenuButton">

                                        <a class="dropdown-item" href="#" data-value="3">3 per page</a>
                                        <a class="dropdown-item" href="#" data-value="6">6 per page</a>
                                        <a class="dropdown-item" href="#" data-value="9">9 per page</a>
                                        <a class="dropdown-item" href="#" data-value="0">View All</a>

                                    </div>
                                </div>

                            </nav>

                            <!-- dropdown sort control -->
                     

                </div>
                   </center>
                       </div>
            </div>
                        
                        
                        
                        
                        </div>
                        <!-- End Pagenation -->
                   
                    <div class="col-lg-3 col-lg-pull-9 col-md-3 col-md-pull-9 col-sm-12 col-xs-12 smt-40 xmt-40">
                        <div class="htc__product__leftsidebar">
                            <!-- Start Prize Range -->
                            
                            <!-- End Prize Range -->
                            <!-- Start Category Area -->
                            <div class="htc__category">
                                <h4 class="title__line--4">Sub Rubros</h4>
                                <ul class="ht__cat__list">
                                   
                                    	 <asp:Repeater ID="RepeaterSubRubros" runat="server">
              <ItemTemplate>
                                    <li><a  style="font-family: 'Poppins', sans-serif; color:#000;" href='<%# Eval("URL")%>'><%# Eval("DescripcionSubRubro")%></a></li>
                                	 </ItemTemplate>
  </asp:Repeater>
                                
                                
                                </ul>
                                 <h4 class="title__line--4"></h4>
                            </div>


                              <div class="htc__category">
                                <h4 class="title__line--4">MARCAS</h4>
                              <select style="font-family: 'Poppins', sans-serif; " onchange="CantidadItems2()" class="ht__select"
                                         data-jplist-control="select-filter"
                                data-group="group1"
                                data-name="tags-filter">
                                        
                                       

                                        <option value="0" data-path="default">MOSTRAR TODOS</option>
                                       
                                     <asp:Repeater ID="RepeaterMarcas" runat="server">
                        <ItemTemplate>
                            <option value="<%# Eval("descripcion").ToString.ToLower%>"
                                    data-path=".<%# Eval("marcaCombo").ToString.ToLower%>"> <%# Eval("descripcion").ToString%></option>
                                    </ItemTemplate>
                                    </asp:Repeater>
                                  
                                        
                                    </select>
                             </div>


                           
                            
                            <!-- End Best Sell Area -->
                        </div>
                    </div>
                </div> </div>
            </div>

        </section>
        <!-- End Product Grid -->
        <!-- Start Brand Area -->
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
                    <div class="row" style="background-color:#000">
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
                                        <li><a style="color:#fff" href="frminicio.aspx">Principal</a></li>
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

                                            <button class="fr__btn" style="border:none;background-color:#fff;color:#000"
                                                onclick="EnviarEmailContacto()" id="btnEnviarEmailContacto"
                                                type="button">Enviar</button>
                                            <button class="fr__btn" style="border:none; display:none;background-color:#fff;color:#000 "
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


    <!-- Waypoints.min.js. -->
    <script src="js/waypoints.min.js"></script>
    <!-- Main js file that contents all jQuery plugins activation. -->
    <script src="js/main.js"></script>

    

           
     <link href="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.css" rel="stylesheet" type="text/css">
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/6.10.1/sweetalert2.min.js"></script>

    <script>




        $(document).ready(function () {


            CantidadItems();

        });

        function myfunction() {
            alert('af');
        }

        function CantidadItems() {

           
            var cantidad = $('#TxtCantidadItem').text();

            $('#TxtCantidadItemTop').text('Estas viendo ' + cantidad);
            
         

        }

        function CantidadItems2() {


            setTimeout(
                function () {
                    var cantidad = $('#TxtCantidadItem').text();

                    $('#TxtCantidadItemTop').text('Estas viendo ' + cantidad);

                   
                }, 500);


        


        }

        function EnviarEmailContacto() {

            var Email = $('#TxtEmailContacto').val();


            var par = "{\"Email\":\"" + Email + "\"}";


            var payload = { cadena: par };


            $.ajax({
                type: "POST",
                url: "frmRubros.aspx/EnviarEmailContacto_Ws",
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

         </form>
</body>

</html>