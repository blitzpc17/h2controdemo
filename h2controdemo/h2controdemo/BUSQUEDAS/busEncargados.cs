using CapaDatos;
using CapaLogica.LOGICAS.SISTEMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2controdemo.BUSQUEDAS
{
    public partial class busEncargados : Form
    {
        private EncargadosLogica contexto;
        public ENCARGADOS ObjEncargado;

        public busEncargados()
        {
            InitializeComponent();
        }
        public void CargarEncargadosBusqueda()
        {
            dgvRegistros.DataSource = contexto.ListarEncargadosBusqueda();
        }
        public ENCARGADOS GetEncargado(string claveEncargado)
        {
            return contexto.GetEncargado(claveEncargado);
        }
        public void InicializarForm()
        {
            contexto = new EncargadosLogica();
            CargarEncargadosBusqueda();
            Apariencias();
        }
        public void Apariencias()
        {
            try
            {
                if (dgvRegistros.ColumnCount <= 0) return;
                dgvRegistros.Columns[0].Visible = false;
                dgvRegistros.Columns[0].Name = @"idEncargado";

                dgvRegistros.Columns[1].Width = 100;
                dgvRegistros.Columns[1].Name = @"ClaveUsuario";
                dgvRegistros.Columns[1].ReadOnly = true;
                dgvRegistros.Columns[1].HeaderText = @"Clave usuario";

                dgvRegistros.Columns[2].Name = @"NombreEncargado";
                dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRegistros.Columns[2].ReadOnly = true;
                dgvRegistros.Columns[2].HeaderText = @"Nombre encargado";

                dgvRegistros.Columns[3].Name = @"rolSistema";
                dgvRegistros.Columns[3].Width = 100;
                dgvRegistros.Columns[3].ReadOnly = true;
                dgvRegistros.Columns[3].HeaderText = @"Rol";

                tsblTotalRegistros.Text = dgvRegistros.RowCount.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha generado un error en el sistema. Detalle del error: " + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RegistroSeleccionado()
        {
            if (dgvRegistros.RowCount < 1) return;
            string clave = dgvRegistros.CurrentRow.Cells["claveUsuario"].Value.ToString();
            ObjEncargado = contexto.GetEncargado(clave);
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            RegistroSeleccionado();
        }

        private void busEncargados_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroSeleccionado();
        }
    }
}
