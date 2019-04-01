using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ADOS.USUARIO
{
   public  class ADOUsuarios:ICRUD<USUARIOS>
    {
        readonly dbh2controlEntities contexto;

        public ADOUsuarios()
        {
            contexto = new dbh2controlEntities();
        }

        public void Eliminar(USUARIOS obj)
        {
            contexto.USUARIOS.Remove(obj);
        }

        public void Guardar()
        {
            contexto.SaveChanges();
        }

        public void Insertar(USUARIOS obj)
        {
            contexto.USUARIOS.Add(obj);
        }

        public List<USUARIOS> Listar()
        {
            return contexto.USUARIOS.ToList();
        }

        public USUARIOS GetUsuario(string folioUsuario)
        {
            return contexto.USUARIOS.FirstOrDefault(x => x.FOLIO == folioUsuario);
        }

        //public bool ExisteUsuarioSistema(string nombreUsuario, string telefono, string direccion)
        //{
            
        //}
    }
}
