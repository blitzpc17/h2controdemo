using h2controdemo.LOGICAS.SISTEMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalControles = Controles.GlobalControles;


namespace h2controdemo.SISTEMA
{
    public partial class formLogin : Form
    {
        private formLoginLogica contexto;
        private MDIPanel panel;
        private bool validacion;
        private bool enmascararPass;

        public formLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!GlobalControles.ValidarControles(this))
            {
                MessageBox.Show("Ingrese sus datos de usuario para que puedan ser válidados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BarraCargado.Visible = true;
            textoCargado.Text = "Validando información, un momento...";
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            contexto = new formLoginLogica();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (contexto.ValidarAcceso(ObligatoriotxtUsuario.Text.Trim(), ObligatoriotxtPassword.Text.Trim()))
            {
                validacion = true;    
            }           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BarraCargado.Visible = false;
            if (validacion)
            {
                MessageBox.Show("Bienvenido " + contexto.ObjEncargado.NOMBRES + " a H2CONTROL.", "¡Hola!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel = new MDIPanel();
                panel.ObjEncargado = contexto.ObjEncargado;
                Hide();
                panel.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(contexto.mensajeError, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (enmascararPass)
            {
                ObligatoriotxtPassword.UseSystemPasswordChar = true;
                enmascararPass = false;
            }
            else
            {
                ObligatoriotxtPassword.UseSystemPasswordChar = false;
                enmascararPass = true;
            }
        }
    }
}
