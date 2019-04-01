using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public static class GlobalControles
    {
        private static void LimpiarControles(GroupBox gbx)
        {
            foreach (var ctrl in gbx.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                    continue;
                }
                if (ctrl is DataGridView)
                {
                    if (((DataGridView)ctrl).DataSource != null)
                    {
                        ((DataGridView)ctrl).DataSource = null;
                    }
                    if (((DataGridView)ctrl).Rows.Count > 0)
                    {
                        ((DataGridView)ctrl).Rows.Clear();
                    }
                    continue;
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).DataSource = null;
                    continue;
                }
                if (ctrl is PictureBox)
                {
                    string nombre = "";
                    nombre = ((PictureBox)ctrl).Name;
                    if (nombre.Length > 8)
                    {
                        nombre = nombre.Substring(0, 8);
                        if (nombre.Equals("ErrorImg"))
                        {
                            ((PictureBox)ctrl).Hide();
                        }
                    }
                }
            }
        }

        public static void ReiniciarControles(Form formulario)
        {
            foreach (var control in formulario.Controls)
            {
                if (control is GroupBox)
                {
                    LimpiarControles((GroupBox)control);
                }
                if (control is TabControl)
                {
                    //limpiarControlesTabPage((TabControl)control);
                }
            }
        }

        public static bool ValidarControles(Form formulario)
        {
            var er = new ErrorProvider();
            bool validacion = true;
            foreach (var control in formulario.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (var ctrl in ((GroupBox)control).Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            if (string.IsNullOrEmpty(((TextBox)ctrl).Text))
                            {
                                if (((TextBox)ctrl).Name.Length > 10)
                                {
                                    if (((TextBox)ctrl).Name.Substring(0, 11).Equals("Obligatorio") && string.IsNullOrEmpty(((TextBox)ctrl).Text))
                                    {
                                        er.SetError(((TextBox)ctrl), "*Campo obligatorio.");
                                        validacion = false;
                                        return validacion;
                                    }
                                    else
                                    {
                                        er.SetError(((TextBox)ctrl), "");
                                        er.Dispose();
                                        validacion = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (validacion)
            {
                er.Clear();
            }
            return validacion;
        }

    }
}
