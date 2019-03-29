<!DOCTYPE html>
<html lang="en">
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="icon" href="images/favicon.ico" type="image/ico" />

    <title>Sistema de Cobro</title>

    <!-- Bootstrap -->
    <link href="vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="vendors/nprogress/nprogress.css" rel="stylesheet">
    <!-- iCheck -->
    <link href="vendors/iCheck/skins/flat/green.css" rel="stylesheet">

    <!-- bootstrap-progressbar -->
    <link href="vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet">
    <!-- JQVMap -->
    <link href="vendors/jqvmap/dist/jqvmap.min.css" rel="stylesheet"/>
    <!-- bootstrap-daterangepicker -->
    <link href="vendors/bootstrap-daterangepicker/daterangepicker.css" rel="stylesheet">

    <!-- Custom Theme Style -->
    <link href="build/css/custom.css" rel="stylesheet">
    <link href="build/css/custom.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">

    <script type="text/javascript">

    function maxWindow(elem) {
        // ## The below if statement seems to work better ## if ((document.fullScreenElement && document.fullScreenElement !== null) || (document.msfullscreenElement && document.msfullscreenElement !== null) || (!document.mozFullScreen && !document.webkitIsFullScreen)) {
        if ((document.fullScreenElement !== undefined && document.fullScreenElement === null) || (document.msFullscreenElement !== undefined && document.msFullscreenElement === null) || (document.mozFullScreen !== undefined && !document.mozFullScreen) || (document.webkitIsFullScreen !== undefined && !document.webkitIsFullScreen)) {
            if (elem.requestFullScreen) {
                elem.requestFullScreen();
            } else if (elem.mozRequestFullScreen) {
                elem.mozRequestFullScreen();
            } else if (elem.webkitRequestFullScreen) {
                elem.webkitRequestFullScreen(Element.ALLOW_KEYBOARD_INPUT);
            } else if (elem.msRequestFullscreen) {
                elem.msRequestFullscreen();
            }
        } else {
            if (document.cancelFullScreen) {
                document.cancelFullScreen();
            } else if (document.mozCancelFullScreen) {
                document.mozCancelFullScreen();
            } else if (document.webkitCancelFullScreen) {
                document.webkitCancelFullScreen();
            } else if (document.msExitFullscreen) {
                document.msExitFullscreen();
            }
        }
    }
    </script>
  </head>

  <body class="nav-md">
    <div class="container body">
      <div class="main_container">
        <div class="col-md-3 left_col">
          <div class="left_col scroll-view">
            <div class="navbar nav_title" style="border: 0;">
              <!---a href="#" class="site_title"><img width="500 px" src="images/logo.jpeg"></a>--->
            </div>

            <div class="clearfix"></div>

            <!-- menu profile quick info -->
            <div class="profile clearfix">
              <div class="profile_pic">
                <img src="images/logo.jpeg" alt="..." class="img-circle profile_img">
              </div>
              <div class="profile_info">
                <span>SDC</span>
                <h2>Sistema de Cobro</h2>
              </div>
            </div>
            <!-- /menu profile quick info -->

            <br />

            <?php include("menu.html");?>

            <?php include("menu_footer.html");?>

          </div>
        </div>

        <?php include("header.php"); ?>
        <!-- page content -->
        <div class="right_col" role="main">
          <!-- Contenido aquí-->
          <!-- Inicio del TAB-->
          <!--
          <div class="" role="tabpanel" data-example-id="togglable-tabs">
                  <ul id="myTab" class="nav nav-tabs" role="tablist">
                    <li role="presentation" class=""><a href="listaUsuarios.php" >Lista</a></li>
                    <li role="presentation" class=""><a href="nuevoUsuario.php">Nuevo</a></li>                                  
                  </ul>
                    </div>
                    -->
            <!-- Fin del TAB-->                              
          <form class="form-horizontal form-label-left" action="backend/insertUsuario.php" method="post" novalidate enctype='multipart/form-data'>                
          <div class="x_title">
                    <h2>Nuevo Usuario</h2>
                    <ul class="nav navbar-right panel_toolbox"></ul>
                    <div class="clearfix"></div>
                  </div>                      
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="Nombre">Nombre <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <input id="Nombre" name="Nombre" class="form-control col-md-7 col-xs-12"  name="name" placeholder="Nombre del usuario" required="required" type="text"/>
                        </div>
                      </div> 
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="Nombre">Apellido Materno</label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <input id="apellidoM" name="apellidoM" class="form-control col-md-7 col-xs-12"  name="name" placeholder="Nombre de la empresa" type="text"/>
                        </div>
                      </div>
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="Nombre">Apellido Paterno</label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <input id="apellidoP" name="apellidoP" class="form-control col-md-7 col-xs-12" placeholder="RFC de la empresa" type="text"/>
                        </div>
                      </div>                         
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Email<span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">                                                
                        <input id="email" name="email" class="form-control col-md-7 col-xs-12" class='email' placeholder="Correo" required="required" type="email" />
                        </div>
                      </div>
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="Nombre">Telefono <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <input id="telefono" name="telefono" class="form-control col-md-7 col-xs-12" placeholder="Telefono" required="required" type="text"/>
                        </div>
                      </div>
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Contraseña <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                        <input id="Contraseña" name="Contraseña" class="form-control col-md-7 col-xs-12" data-validate-length="8" name="Contraseña"  required="required"placeholder="Contraseña" type="password"/>
                        </div>
                      </div>
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Repetir Contraseña <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-6">
                        <input id="RepiteContraseña" name="RepiteContraseña" data-validate-linked='Contraseña' class="form-control col-md-7 col-xs-12" required='required' placeholder="Contraseña" type="password"/>
                        </div>
                      </div>
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="logo">Imagen de Perfil</label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <input type="file" id="imagen" name="imagen" required><br>                          
                        </div>
                      </div> 
                      <!--
                      <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="logo">Tipo de Usuario <span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                        <select class="form-control" name="TipoAdmin" id="TipoAdmin" required>
                          <option value="" selected>Seleccionar tipo</option>
                          <option id="tipo" name="tipo" value="comunicacion">Comunicacion</option>
                          <option id="tipo" name="tipo" value="deportes">Deportes</option>
                          <option id="tipo" name="tipo" value="canchas">Canchas</option>
                          <option id="tipo" name="tipo" value="caddiehouse">CaddieHouse</option>
                          <option id="tipo" name="tipo" value="starter">Starter</option>
                        </select>
                        </div>
                      </div> -->
                      <!--
                       <div class="item form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="logo">Fotografía</label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <input type="file" id="imagen" name="imagen" required><br>                          
                        </div>
                      </div>   -->                                                               
                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-6 col-md-offset-3">
                          <button type="button" class="btn btn-danger" onclick="location.href='listaUsuarios.php'">Cancelar</button>
                          <button type="submit" class="btn btn-success" onclick="return verificapass();">Aceptar</button>                                             
                        </div>
                      </div>                      
              </form>
        </div>
        <!-- /page content -->

      <?php include("footer.html");?>

      </div>
    </div>

    <!-- jQuery -->
    <script src="vendors/jquery/dist/jquery.min.js"></script>
    <script src="vendors/validator/validator.js"></script>
    <!-- Bootstrap -->
    <script src="vendors/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- FastClick -->
    <script src="vendors/fastclick/lib/fastclick.js"></script>
    <!-- NProgress -->
    <script src="vendors/nprogress/nprogress.js"></script>
    <!-- Chart.js -->
    <script src="vendors/Chart.js/dist/Chart.min.js"></script>
    <!-- gauge.js -->
    <script src="vendors/gauge.js/dist/gauge.min.js"></script>
    <!-- bootstrap-progressbar -->
    <script src="vendors/bootstrap-progressbar/bootstrap-progressbar.min.js"></script>
    <!-- iCheck -->
    <script src="vendors/iCheck/icheck.min.js"></script>
    <!-- Skycons -->
    <script src="vendors/skycons/skycons.js"></script>
    <!-- Flot -->
    <script src="vendors/Flot/jquery.flot.js"></script>
    <script src="vendors/Flot/jquery.flot.pie.js"></script>
    <script src="vendors/Flot/jquery.flot.time.js"></script>
    <script src="vendors/Flot/jquery.flot.stack.js"></script>
    <script src="vendors/Flot/jquery.flot.resize.js"></script>
    <!-- Flot plugins -->
    <script src="vendors/flot.orderbars/js/jquery.flot.orderBars.js"></script>
    <script src="vendors/flot-spline/js/jquery.flot.spline.min.js"></script>
    <script src="vendors/flot.curvedlines/curvedLines.js"></script>
    <!-- DateJS -->
    <script src="vendors/DateJS/build/date.js"></script>
    <!-- JQVMap -->
    <script src="vendors/jqvmap/dist/jquery.vmap.js"></script>
    <script src="vendors/jqvmap/dist/maps/jquery.vmap.world.js"></script>
    <script src="vendors/jqvmap/examples/js/jquery.vmap.sampledata.js"></script>
    <!-- bootstrap-daterangepicker -->
    <script src="vendors/moment/min/moment.min.js"></script>
    <script src="vendors/bootstrap-daterangepicker/daterangepicker.js"></script>

    <!-- Custom Theme Scripts -->
    <script src="build/js/custom.js"></script>

  </body>
</html>
