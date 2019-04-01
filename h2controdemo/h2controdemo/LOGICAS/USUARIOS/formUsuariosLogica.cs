using CapaLogica.LOGICAS.USUARIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace h2controdemo.LOGICAS.USUARIOS
{
    public class formUsuariosLogica
    {
        private UsuariosLogica contextoUsuarios;        
        public formUsuariosLogica()
        {
            contextoUsuarios = new UsuariosLogica();
        }

        public string GenerarFolioUsuario()
        {
            string folio = "US";
            var x = Global.GetConsecutivo("USUARIOS");           

            if (x == 0)
            {
                folio += "0000001";
            }
            else if (x < 10)
            {
                folio += "000000" + x;
            }
            else if (x < 100)
            {
                folio += "00000" + x;
            }
            else if (x < 1000)
            {
                folio += "0000" + x;
            }
            else if (x < 10000)
            {
                folio += "000" + x;
            }
            else if (x < 100000)
            {
                folio += "00" + x;
            }
            else if (x < 1000000)
            {
                folio +="0"+ x;
            }
            else if(x<10000000)
            {
                folio += "0" + x;
            }

            return folio;
        }
    }
}
