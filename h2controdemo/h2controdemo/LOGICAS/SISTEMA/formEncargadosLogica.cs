using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.LOGICAS.SISTEMA;
using CapaDatos;
using h2controdemo;

namespace h2controdemo.LOGICAS.SISTEMA
{
    public class formEncargadosLogica
    {
        private EncargadosLogica contextoEncargados;
        private RolesLogica contextoRoles;
        public List<ENCARGADOS> ListaEncargados;
        public List<ROLES> ListaRoles;
        public ENCARGADOS ObjEncargados;        
        public string NombreUsuario;


        public formEncargadosLogica()
        {
            contextoEncargados = new EncargadosLogica();
            contextoRoles = new RolesLogica();            
        }
        
        public void Guardar()
        {
            contextoEncargados.Guardar();  
        }
        public void CrearEncargado()
        {
            ObjEncargados = new ENCARGADOS();
        }

        public void Insertar(ENCARGADOS obj)
        {
            contextoEncargados.Insertar(obj);
        }
        
        public ENCARGADOS GetEncargado(string usuario)
        {
            return contextoEncargados.GetEncargado(usuario);
        }

        public bool GenerarNombreUsuario(string nombres, string apellidos)
        {
            NombreUsuario = null;
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos)) return false;
            var nom = nombres.ToCharArray();
            int indexAux = 0;
            NombreUsuario += nombres.Substring(0, 1);
            for (int i = 0; i <= nom.Length; i++)
            {
                if (char.IsWhiteSpace(nom[i]))
                {
                    indexAux = i + 1;
                    break;
                }
            }
            if (indexAux != 0)
            {
                NombreUsuario += nombres.Substring(indexAux, 1);
                NombreUsuario += apellidos.Substring(0, 1);
            }
            else
            {
                indexAux = 0;
                NombreUsuario += apellidos.Substring(0, 1);
                var ap = apellidos.ToCharArray();
                for (int i = 0; i <= ap.Length; i++)
                {
                    if (char.IsWhiteSpace(ap[i]))
                    {
                        indexAux = i + 1;
                        break;
                    }
                }
                NombreUsuario += apellidos.Substring(indexAux, 1);
            }
            if (contextoEncargados.ExisteUsuarioEncargado(NombreUsuario))
            {
                var ramdom = new Random();
                NombreUsuario = null;
                nombres.Replace(" ", "");
                NombreUsuario += nombres.Substring(0, 1);
                NombreUsuario += nombres.Substring(ramdom.Next(1, nombres.Length), 1);
                apellidos.Replace(" ", "");
                NombreUsuario += apellidos.Substring(ramdom.Next(0, nombres.Length), 1);
            }
            return true;
        }
        public void ListarRoles()
        {
            ListaRoles = new List<ROLES>();
            ListaRoles = contextoRoles.Listar();
        }
        public void Insertar()
        {
            contextoEncargados.Insertar(ObjEncargados);
        }
    }
}
