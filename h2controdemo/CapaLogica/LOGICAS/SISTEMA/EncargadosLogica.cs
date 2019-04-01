using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.ADOS.SISTEMA;
using ENTIDADES;

namespace CapaLogica.LOGICAS.SISTEMA
{
    public class EncargadosLogica:ICRUD<ENCARGADOS>
    {
        readonly ADOEncargados contexto;

        public EncargadosLogica()
        {
            contexto = new ADOEncargados();
        }

        public void Eliminar(ENCARGADOS obj)
        {
            contexto.Eliminar(obj);
        }

        public void Guardar()
        {
            contexto.Guardar();
        }

        public void Insertar(ENCARGADOS obj)
        {
            contexto.Insertar(obj);
        }

        public List<ENCARGADOS> Listar()
        {
            return contexto.Listar();
        }

        public ENCARGADOS GetEncargado(string usuario)
        {
            return contexto.GetEncargado(usuario);
        }      

        public bool ExisteUsuarioEncargado(string claveUsuario)
        {
            return contexto.ExisteUsuarioEncargado(claveUsuario);
        }
        public List<clsENCARGADOSBUSQUEDA> ListarEncargadosBusqueda()
        {
            return contexto.ListarEncargadosBusqueda();
        }
    }
}
