using CapaDatos;
using CapaDatos.ADOS.SISTEMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LOGICAS.SISTEMA
{
    public class RolesLogica
    {
        private ADORoles contexto;
        public RolesLogica()
        {
            contexto = new ADORoles();
        }

        public void Eliminar(ROLES obj)
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(ROLES obj)
        {
            throw new NotImplementedException();
        }

        public List<ROLES> Listar()
        {
            return contexto.Listar();
        }
    }
}
