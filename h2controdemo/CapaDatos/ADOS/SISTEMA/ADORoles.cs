using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADOS.SISTEMA
{
    public class ADORoles:ICRUD<ROLES>
    {
        private dbh2controlEntities contexto;
        public ADORoles()
        {
            contexto = new dbh2controlEntities();
        }
        public void Eliminar(ROLES obj)
        {
            contexto.ROLES.Remove(obj);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Insertar(ROLES obj)
        {
            contexto.ROLES.Add(obj);
        }

        public List<ROLES> Listar()
        {
            return contexto.ROLES.ToList();
        }
    }
}
