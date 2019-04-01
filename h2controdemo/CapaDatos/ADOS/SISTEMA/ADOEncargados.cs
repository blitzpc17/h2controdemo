using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADOS.SISTEMA
{
    public class ADOEncargados:ICRUD<ENCARGADOS>
    {
        readonly dbh2controlEntities contexto;

        public ADOEncargados()
        {
            contexto = new dbh2controlEntities();
        }

        public void Eliminar(ENCARGADOS obj)
        {
            contexto.ENCARGADOS.Remove(obj);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Insertar(ENCARGADOS obj)
        {
            contexto.ENCARGADOS.Add(obj);
        }

        public List<ENCARGADOS> Listar()
        {
            return contexto.ENCARGADOS.ToList();
        }

        public ENCARGADOS GetEncargado(string usuario)
        {
            return contexto.ENCARGADOS.FirstOrDefault(x=>x.USUARIO==usuario);
        }       
        public bool ExisteUsuarioEncargado(string claveUsuario)
        {
            return contexto.ENCARGADOS.Any(x => x.USUARIO == claveUsuario);
        }
        public List<clsENCARGADOSBUSQUEDA> ListarEncargadosBusqueda()
        {
            var query = "select " +
                        "en.id as IdUsuario, en.USUARIO as ClaveUsuario, CONCAT(en.Nombres, en.Apellidos) as NombreEncargado,rol.NOMBRE as RolSistema " +
                        "from encargadosset en " +
                        "join ROLESSet rol on rol.id = en.rolesid";
            return contexto.Database.SqlQuery<clsENCARGADOSBUSQUEDA>(query).ToList();
        }
    }
}
