<!-- top navigation -->
<div class="top_nav">
  <div class="nav_menu">
    <nav>
      <div class="nav toggle">
        <a id="menu_toggle"><i class="fa fa-bars"></i></a>
      </div>
      
      <ul class="nav navbar-nav navbar-right">
        <li class="">
          <a href="javascript:;" class="user-profile dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
            Iniciar Sesión
            <span class=" fa fa-angle-down"></span>
          </a>
          <ul class="dropdown-menu dropdown-usermenu pull-left">
            <form class="login" action="backend/login.php" method="POST">
              <h1 class="login-title">Iniciar Sesión</h1>
              <input name="login" type="hidden" value="index.php"/>
                <input id="correo" name="correo" type="text" class="login-input" placeholder="Correo Electronico">
                  <input id="password" name="password" type="password" class="login-input" placeholder="Contraseña">
                  <input type="submit" value="Entrar" class="login-button">
              </form>
          </ul>
        </li>
        <li>
          <a href="registro.php"><h5>Registrate</h5></a>
        </li>
      </ul>
    </nav>
  </div>
</div>
<!-- /top navigation -->
