using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using h2controdemo.SISTEMA;

namespace h2controdemo.SISTEMA
{
    public partial class MDIPanel : Form
    {
        private int childFormNumber = 0;
        public ENCARGADOS ObjEncargado;

        public MDIPanel()
        {
            InitializeComponent();
        }

        private void eNCARGADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEncargados = formEncargados.GetInstancia();
            fEncargados.MdiParent = this;
            fEncargados.Show();
        }
        private void SetDatosEncargado()
        {
            tsclaveEncargado.Text = ObjEncargado.USUARIO;
            lblNombreEncargado.Text = ObjEncargado.NOMBRES + " " + ObjEncargado.APELLIDOS;
            if (ObjEncargado.ROLESId == 1)
            {
                lblNombreRol.Text = Enumeraciones.Roles.SA.ToString();
            }
            else if (ObjEncargado.ROLESId == 2)
            {
                lblNombreRol.Text = Enumeraciones.Roles.ADMIN.ToString();
            }
            else if (ObjEncargado.ROLESId == 3)
            {
                lblNombreRol.Text = Enumeraciones.Roles.COBRADOR.ToString();
            }
        }
        private void SetDatosSistema()
        {
            tsFecha.Text = InstanciasFechaHora();
            HoraIngreso();
            NombreEquipo();
        }

        private void MDIPanel_Load(object sender, EventArgs e)
        {
            SetDatosEncargado();
            SetDatosSistema();
        }

        private string InstanciasFechaHora()
        {
            string Fecha = "";
            DateTime fecha = DateTime.Now;
            Fecha+=Global.DayName()+" ";
            Fecha+=fecha.Day.ToString("N0")+" de "+Global.MonthName(fecha.Month)+" ";
            Fecha += fecha.Year;
            return Fecha;
        }
        private void HoraIngreso()
        {
            tslHoraIngreso.Text = Global.GetFechaServidor().ToShortTimeString();
        }
        private void NombreEquipo()
        {
            tslNombreEquipo.Text = Global.NombreEquipo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslHoraSistema.Text= DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
