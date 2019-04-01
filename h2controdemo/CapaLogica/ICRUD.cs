using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    interface ICRUD<TIPO>
    {
        void Insertar(TIPO obj);
        void Guardar();
        void Eliminar(TIPO obj);
        List<TIPO> Listar();
    }
}
