using System.Text.RegularExpressions;

namespace Agenda_JuanMRuiz
{
    class Validacion
    {
        // este metodo tambien valida que el numero sea positivo
        public bool EsNumero(string numero)
        {
            Regex regNumero = new Regex(@"^\s*-?[0-9]{1,10}\s*$");
            return regNumero.IsMatch(numero);
        }
        // esta clase se encarga de hacer validaciones en la entrada de valores
        public bool EsValidoNombre(string nombre)
        {
            //si el texto esta dentro de este patron entonces devuelve true
            Regex regNombre = new Regex("^[a-zA-Z]{4,10}$");
            return regNombre.IsMatch(nombre);
        }
        public bool EsValidoMail(string mail)
        {
            Regex regMail = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
            return regMail.IsMatch(mail);
        }
        public bool EsValidoTel(string telefono)
        {
            Regex regTel = new Regex("^[0-9]{2}-? ?[0-9]{8}$");
            return regTel.IsMatch(telefono);
        }
    }
}
