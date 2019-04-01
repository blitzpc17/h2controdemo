using CapaLogica.LOGICAS.SISTEMA;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace h2controdemo
{
    public static class Global
    {
        public static int  GetConsecutivo(string tabla)
        {
            using (var contexto= new GlobalLogica())
            {
                return contexto.GetConsecutivo(tabla);
            }               
        }
        public static bool ExisteFolio(string folio, string entidad)
        {
            using (var contexto = new GlobalLogica())
            {
                return contexto.ExisteFolio(folio, entidad);
            }
        }
        public static DateTime GetFechaServidor()
        {
            using (var contexto =new GlobalLogica()) 
            {
                return contexto.GetFechaServidor();
            }                
        }
        public static string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }
        public static string DayName( )
        {
            string dia = "";
            DateTime fecha = DateTime.Now;
            DayOfWeek dow = fecha.DayOfWeek;
            switch (dow.ToString())
            {
                case "Sunday":
                    dia = "Domingo";
                    break;

                case "Monday":
                    dia = "Lunes";
                    break;

                case "Tuesday":
                    dia = "Martes";
                    break;

                case "Wednesday":
                    dia = "Miércoles";
                    break;

                case "Thursday":
                    dia = "Jueves";
                    break;

                case "Friday":
                    dia = "Viernes";
                    break;

                case "Saturday":
                    dia = "Sábado";
                    break;
            }
            return dia;
        }
        public static string NombreEquipo()
        {
            var hostName = Dns.GetHostName();
            return hostName;
        }
        public static string IpHost(string NombreEquipo)
        {
            string ipEquipo = "";
            var host = Dns.GetHostEntry(NombreEquipo);
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipEquipo = ip.ToString();
                }
            }
            return ipEquipo;
        }
    }
}
