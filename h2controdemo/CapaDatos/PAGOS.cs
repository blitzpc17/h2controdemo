//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAGOS
    {
        public int Id { get; set; }
        public string FOLIO { get; set; }
        public decimal TARIFA { get; set; }
        public System.DateTime FECHAPAGO { get; set; }
        public decimal IMPORTE { get; set; }
        public int USUARIOSId { get; set; }
        public int ENCARGADOSId { get; set; }
        public string PERIODO { get; set; }
        public bool RETARDO { get; set; }
    }
}
