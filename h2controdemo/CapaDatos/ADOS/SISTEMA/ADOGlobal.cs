using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADOS.SISTEMA
{
    public class ADOGlobal
    {
        readonly dbh2controlEntities contexto;

        public ADOGlobal()
        {
            contexto = new dbh2controlEntities();
        }

        public int GetConsecutivo(string tabla)
        {
            string query = "SELECT (CASE WHEN (MAX(Id)) is null then 0 else (MAX(Id)) end)  FROM " + tabla;
            var q = (int?)contexto.Database.SqlQuery<int>(query).ToList().FirstOrDefault();
            return q != null ? (int)q : 0;
        }
        public bool ExisteFolio(string folio, string entidad)
        {
            string query = "SELECT COUNT(*) FROM '" + entidad + "' WHERE FOLIO='" + folio+"'";
            var coincidencias = (int?)contexto.Database.SqlQuery<int>(query).ToList().FirstOrDefault();
            if (coincidencias > 0) return true;
            return false;            
        }
        public DateTime GetFechaServidor()
        {
            var query = "select getdate();";
            return contexto.Database.SqlQuery<DateTime>(query).First();
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
