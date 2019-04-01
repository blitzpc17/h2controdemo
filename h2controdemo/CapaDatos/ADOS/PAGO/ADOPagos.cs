using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADOS.PAGO
{
    public class ADOPagos:ICRUD<PAGOS>
    {
        readonly dbh2controlEntities contexto;
        public ADOPagos()
        {
            contexto = new dbh2controlEntities();
        }

        public void Eliminar(PAGOS obj)
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(PAGOS obj)
        {
            throw new NotImplementedException();
        }

        public List<PAGOS> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
