using CapaDatos.ADOS.SISTEMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LOGICAS.SISTEMA
{
    public class GlobalLogica:IDisposable
    {
        readonly ADOGlobal contexto;

        public GlobalLogica()
        {
            contexto = new ADOGlobal();
        }

        public int GetConsecutivo(string tabla)
        {
            return contexto.GetConsecutivo(tabla);
        }
        public bool ExisteFolio(string folio, string entidad)
        {
            return contexto.ExisteFolio(folio, entidad);
        }
        public DateTime GetFechaServidor()
        {
            return contexto.GetFechaServidor();
        }

        public void Dispose()
        {
            try
                {
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }           
        }
    }
}
