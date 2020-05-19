<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmLogin.aspx.vb" Inherits="GAULICHO.BACKEND.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">
    <!-- App Favicon -->
    <link rel="shortcut icon" href="Imagenes/Fv.png">
    <!-- App title -->
      <title>Hiercons - Backend</title>
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
<body>
    <form id="form1" runat="server">
    <div class="account-pages">
    </div>
    <div class="clearfix">
    </div>
    <div class="wrapper-page">
         <div class="m-t-40 card-box">
        <div class="text-center">
            <img  style=" height:75px;" src="Imagenes/logo1.png" />
        <%--    <a href="Login.aspx" class="logo"><span>Login<span> Coovilros</span></span></a>--%>
            <h5 class="text-muted m-t-0 font-600">
            </h5>
            <hr />
        </div>
       
            <div class="text-center">
                <h4 class="text-uppercase font-bold m-b-0">
                    Administrador - Ingresar</h4>
                 <hr />
            </div>
            <div class="panel-body">
                <form class="form-horizontal m-t-20" action="Login.aspx">
                <asp:Login ID="Login1" runat="server" Style="width: 100%;" DestinationPageUrl="frmInicio.aspx">
                    <LayoutTemplate>
                        <div class="form-group ">
                            <div class="col-xs-12">
                                <asp:TextBox class="form-control" type="text" required="" placeholder="EMAIL" ID="UserName" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <br />    <br />    
                        <div class="form-group">
                            <div class="col-xs-12">
                               <asp:TextBox class="form-control" placeholder="CONTRASEÑA" required="" ID="Password" runat="server"
                            type="password"></asp:TextBox>
                              
                            </div>
                        </div>
                        <div class="form-group ">
                            <div class="col-xs-12">
                            </div>
                        </div>
                        <div class="form-group text-center m-t-30">
                            <div class="col-xs-12">
                             <br />  
                               <asp:Button class="btn btn-primary btn-block btn-flat" style=" background:#ff6600 !important; border: 1px solid #ff6600 !important;" ID="LoginButton" runat="server" CommandName="Login" Text="Ingresar"
                        ValidationGroup="Login1"></asp:Button>
                             <%--   <button class="btn btn-custom btn-bordred btn-block waves-effect waves-light" type="submit">
                                    Ingresar</button>--%>
                            </div>
                        </div>
                    </LayoutTemplate>
                </asp:Login>
                <div class="form-group m-t-30 m-b-0">
                    <%--<div class="col-sm-12">
                                <a href="page-recoverpw.html" class="text-muted"><i class="fa fa-lock m-r-5"></i> Olvidaste tu contraseña?</a>
                            </div>--%>
                </div>
                </form>
            </div>
        </div>
        <!-- end card-box-->
        <div class="row">
        </div>
    </div>
    </form>
    <!-- end wrapper page -->
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
    <script src="assets/js/wow.min.js"></script>
    <script src="assets/js/jquery.nicescroll.js"></script>
    <script src="assets/js/jquery.scrollTo.min.js"></script>
    <!-- App js -->
    <script src="assets/js/jquery.core.js"></script>
    <script src="assets/js/jquery.app.js"></script>
              
</body>
</html>
