/* Funciones Login javascript no mover aun no acabo*/

function verificaLogin()
{
  var email = $('#email').val();
  var pass = $('#pass').val();
  var band= false;

  if(!email||email=="")
    alert("Por favor introduce tu email");
  else
    band = true;
  return band;
}
