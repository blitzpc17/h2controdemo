using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.LOGICAS.SISTEMA;
using CapaDatos;

namespace h2controdemo.LOGICAS.SISTEMA
{
    public class formLoginLogica
    {
        readonly EncargadosLogica contextoEncargados;
        public ENCARGADOS ObjEncargado;
        public string mensajeError="";

        public formLoginLogica()
        {
            contextoEncargados = new EncargadosLogica();
        }
        public bool ValidarAcceso(string claveUsuario, string password)
        {
            ObjEncargado = contextoEncargados.GetEncargado(claveUsuario);
            if (ObjEncargado == null) {
                mensajeError = "Usuario invalido. Verifique que el dato sea correcto y vuelva a intentarlo.";
                return false;
            }
            if (ObjEncargado.PASSWORD != password)
            {
                mensajeError = "Contraseña incorrecta. Verifique que el dato sea correcto y vuelva a intentarlo.";
                return false;
            }
            return true;            
        }
    }
}
