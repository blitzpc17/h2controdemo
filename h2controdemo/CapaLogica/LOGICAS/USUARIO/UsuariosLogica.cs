using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.ADOS.USUARIO;

namespace CapaLogica.LOGICAS.USUARIO
{
    public class UsuariosLogica
    {
        readonly ADOUsuarios contexto;

        public UsuariosLogica()
        {
            contexto = new ADOUsuarios();
        }

        public void Eliminar(USUARIOS obj)
        {
            contexto.Eliminar(obj);
        }

        public void Guardar()
        {
            contexto.Guardar();
        }

        public void Insertar(USUARIOS obj)
        {
            contexto.Insertar(obj);
        }

        public List<USUARIOS> Listar()
        {
            return contexto.Listar();
        }
        public USUARIOS GetUsuario(string folioUsuario)
        {
            return contexto.GetUsuario(folioUsuario);
        }

    }
}
