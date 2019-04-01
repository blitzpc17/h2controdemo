using System;
using System.Transactions;
using System.Windows.Forms;
using h2controdemo.LOGICAS.SISTEMA;
using GlobalControles = Controles.GlobalControles;

namespace h2controdemo.SISTEMA
{
    public partial class formEncargados : Form
    {
        private formEncargadosLogica contexto;

        public formEncargados()
        {
            InitializeComponent();
        }
        private void formEncargados_Load(object sender, EventArgs e)
        {
            InicializarControles();
            InicializarContextos();
            CargarRoles();
        }

        public void GenerarFolioUsuario(string nombres, string apellidos)
        {
            if (contexto.GenerarNombreUsuario(nombres, apellidos))
            {
                ObligatoriotxtUsuario.Text = contexto.NombreUsuario;
                btnGenUsuario.Enabled = false;
            }
        }
        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked)
            {
                ObligatoriotxtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                ObligatoriotxtContrasena.UseSystemPasswordChar = true;
            }
        }
        private void InicializarControles()
        {
            btnGenUsuario.Enabled = true;
            ObligatoriotxtContrasena.UseSystemPasswordChar = true;
        }
        public void Guardar()
        {
            if (MessageBox.Show("¿Desea guardar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (var t = new TransactionScope())
            {
                try
                {
                    if (contexto.ObjEncargados != null)
                    {
                        contexto.ObjEncargados.NOMBRES = ObligatoriotxtNombres.Text;
                        contexto.ObjEncargados.APELLIDOS = ObligatoriotxtApellidos.Text;
                        contexto.ObjEncargados.USUARIO = ObligatoriotxtUsuario.Text;
                        contexto.ObjEncargados.CORREO = ObligatoriotxtCorreo.Text;
                        contexto.ObjEncargados.DIRECCION = ObligatoriotxtDireccion.Text;
                        contexto.ObjEncargados.PASSWORD = ObligatoriotxtContrasena.Text;
                        contexto.ObjEncargados.TELEFONO = ObligatoriotxtTelefono.Text;                        
                        contexto.ObjEncargados.ROLESId = (int)ObligatoriocbxRol.SelectedValue;
                        contexto.ObjEncargados.FECHAMODIFICACION = Global.GetFechaServidor();
                    }
                    else
                    {
                        contexto.CrearEncargado();
                        contexto.ObjEncargados.NOMBRES = ObligatoriotxtNombres.Text;
                        contexto.ObjEncargados.APELLIDOS = ObligatoriotxtApellidos.Text;
                        contexto.ObjEncargados.USUARIO = ObligatoriotxtUsuario.Text;                        
                        contexto.ObjEncargados.DIRECCION = ObligatoriotxtDireccion.Text;
                        contexto.ObjEncargados.PASSWORD = ObligatoriotxtContrasena.Text;                        
                        contexto.ObjEncargados.ROLESId = (int)ObligatoriocbxRol.SelectedValue;
                        contexto.ObjEncargados.FECHAALTA = Global.GetFechaServidor();
                        contexto.ObjEncargados.FECHAMODIFICACION = Global.GetFechaServidor();
                        contexto.ObjEncargados.TELEFONO = ObligatoriotxtTelefono.Text;
                        contexto.ObjEncargados.CORREO = ObligatoriotxtCorreo.Text;
                        contexto.Insertar();
                    }
                    contexto.Guardar();
                    t.Complete();
                    MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error en el sistema. Detalle del error: " + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarRoles()
        {
            contexto.ListarRoles();
            ObligatoriocbxRol.DataSource = contexto.ListaRoles;
            ObligatoriocbxRol.ValueMember = "id";
            ObligatoriocbxRol.DisplayMember = "Nombre";
        }
        private void SetDatosEncargado()
        {
            ObligatoriotxtApellidos.Text = contexto.ObjEncargados.APELLIDOS;
            ObligatoriotxtNombres.Text = contexto.ObjEncargados.NOMBRES;
            ObligatoriotxtUsuario.Text = contexto.ObjEncargados.USUARIO;
            ObligatoriotxtDireccion.Text = contexto.ObjEncargados.DIRECCION;            
            ObligatoriotxtContrasena.Text = contexto.ObjEncargados.PASSWORD;
            ObligatoriocbxRol.SelectedValue = contexto.ObjEncargados.ROLESId;
            ObligatoriotxtCorreo.Text = contexto.ObjEncargados.CORREO;
            ObligatoriotxtTelefono.Text = contexto.ObjEncargados.TELEFONO;
            btnGenUsuario.Enabled = false;
        }

        public void InicializarContextos()
        {
            contexto = new formEncargadosLogica();
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("`Se perderá la información ingresada. ¿Desea continuar?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            GlobalControles.ReiniciarControles(this);
            InicializarControles();
            InicializarContextos();
            CargarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GlobalControles.ValidarControles(this))
            {
                Guardar();
                GlobalControles.ReiniciarControles(this);
                InicializarControles();
                InicializarContextos();
                CargarRoles();
            }            
        }

        private void btnGenUsuario_Click(object sender, EventArgs e)
        {
            GenerarFolioUsuario(ObligatoriotxtNombres.Text.Trim(), ObligatoriotxtApellidos.Text.Trim());
            btnGenUsuario.Enabled = false;
        }

        private void btnBusEncargado_Click(object sender, EventArgs e)
        {
            var busEncargado = new BUSQUEDAS.busEncargados();
            busEncargado.ShowInTaskbar = false;
            busEncargado.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            busEncargado.ShowDialog(this);
            if (busEncargado.ObjEncargado == null) return;
            contexto.ObjEncargados=contexto.GetEncargado(busEncargado.ObjEncargado.USUARIO);
            
            SetDatosEncargado();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    contexto.ObjEncargados = contexto.GetEncargado(txtBuscar.Text);
                    if (contexto.ObjEncargados == null) return;
                    SetDatosEncargado();
                    break;
            }
        }

        #region Diseño MDI

        private static formEncargados _instancia;

        public static formEncargados GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new formEncargados();
            }
            if (_instancia.WindowState == FormWindowState.Minimized)
            {
                _instancia.WindowState = FormWindowState.Normal;
            }
            _instancia.BringToFront();
            return _instancia;
        }


        #endregion

        
    }
}
