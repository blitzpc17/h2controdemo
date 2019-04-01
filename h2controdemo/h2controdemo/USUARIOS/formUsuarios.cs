using h2controdemo.LOGICAS.USUARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2controdemo.USUARIOS
{
    public partial class formUsuarios : Form
    {
        private formUsuariosLogica contexto;
        public formUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            contexto = new formUsuariosLogica();
            txtFolio.Text = contexto.GenerarFolioUsuario();
        }
    }
}
