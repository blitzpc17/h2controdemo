namespace h2controdemo.SISTEMA
{
    partial class MDIPanel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPanel));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNCARGADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaYConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARSESIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombreEncargado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombreRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslNombreEquipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslHoraIngreso = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslHoraSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsclaveEncargado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sISTEMAToolStripMenuItem,
            this.uSUARIOSToolStripMenuItem,
            this.pAGOSToolStripMenuItem,
            this.cERRARSESIÓNToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1284, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // sISTEMAToolStripMenuItem
            // 
            this.sISTEMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNCARGADOSToolStripMenuItem});
            this.sISTEMAToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sISTEMAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            this.sISTEMAToolStripMenuItem.Size = new System.Drawing.Size(80, 36);
            this.sISTEMAToolStripMenuItem.Text = "SISTEMA";
            // 
            // eNCARGADOSToolStripMenuItem
            // 
            this.eNCARGADOSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eNCARGADOSToolStripMenuItem.Name = "eNCARGADOSToolStripMenuItem";
            this.eNCARGADOSToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.eNCARGADOSToolStripMenuItem.Text = "Captura y consulta";
            this.eNCARGADOSToolStripMenuItem.Click += new System.EventHandler(this.eNCARGADOSToolStripMenuItem_Click);
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaYConsultaToolStripMenuItem});
            this.uSUARIOSToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUARIOSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // capturaYConsultaToolStripMenuItem
            // 
            this.capturaYConsultaToolStripMenuItem.Name = "capturaYConsultaToolStripMenuItem";
            this.capturaYConsultaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.capturaYConsultaToolStripMenuItem.Text = "Captura y consulta";
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAGOSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            // 
            // cERRARSESIÓNToolStripMenuItem
            // 
            this.cERRARSESIÓNToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cERRARSESIÓNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cERRARSESIÓNToolStripMenuItem.Name = "cERRARSESIÓNToolStripMenuItem";
            this.cERRARSESIÓNToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.cERRARSESIÓNToolStripMenuItem.Text = "CERRAR SESIÓN";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lblNombreEncargado,
            this.toolStripStatusLabel1,
            this.lblNombreRol,
            this.toolStripStatusLabel2,
            this.tslNombreEquipo,
            this.toolStripStatusLabel3,
            this.tslHoraIngreso,
            this.toolStripStatusLabel5,
            this.tslHoraSistema,
            this.tsclaveEncargado,
            this.tsFecha});
            this.statusStrip.Location = new System.Drawing.Point(0, 705);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel.Text = "Sesión de:";
            // 
            // lblNombreEncargado
            // 
            this.lblNombreEncargado.AutoSize = false;
            this.lblNombreEncargado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreEncargado.Name = "lblNombreEncargado";
            this.lblNombreEncargado.Size = new System.Drawing.Size(230, 17);
            this.lblNombreEncargado.Text = "nombre encargado";
            this.lblNombreEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Puesto:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = false;
            this.lblNombreRol.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(80, 17);
            this.lblNombreRol.Text = "nombre puesto";
            this.lblNombreRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel2.Text = "Equipo:";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslNombreEquipo
            // 
            this.tslNombreEquipo.AutoSize = false;
            this.tslNombreEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.tslNombreEquipo.Name = "tslNombreEquipo";
            this.tslNombreEquipo.Size = new System.Drawing.Size(110, 17);
            this.tslNombreEquipo.Text = "Nombreequipo";
            this.tslNombreEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel3.Text = "Hora ingreso:";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslHoraIngreso
            // 
            this.tslHoraIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.tslHoraIngreso.Name = "tslHoraIngreso";
            this.tslHoraIngreso.Size = new System.Drawing.Size(70, 17);
            this.tslHoraIngreso.Text = "00:00:00";
            this.tslHoraIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel5.Text = "Hora:";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslHoraSistema
            // 
            this.tslHoraSistema.AutoSize = false;
            this.tslHoraSistema.ForeColor = System.Drawing.SystemColors.Control;
            this.tslHoraSistema.Name = "tslHoraSistema";
            this.tslHoraSistema.Size = new System.Drawing.Size(110, 17);
            this.tslHoraSistema.Text = "00:00:00 pm";
            this.tslHoraSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsclaveEncargado
            // 
            this.tsclaveEncargado.Name = "tsclaveEncargado";
            this.tsclaveEncargado.Size = new System.Drawing.Size(62, 17);
            this.tsclaveEncargado.Text = "claveusr";
            this.tsclaveEncargado.Visible = false;
            // 
            // tsFecha
            // 
            this.tsFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsFecha.Name = "tsFecha";
            this.tsFecha.Size = new System.Drawing.Size(163, 17);
            this.tsFecha.Text = "Lunes 23, Febrero 2019.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDIPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::h2controdemo.Properties.Resources.fondo2h2control;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1175, 766);
            this.Name = "MDIPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H2CONTROL - BIENVENIDO";
            this.Load += new System.EventHandler(this.MDIPanel_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem sISTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARSESIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNCARGADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblNombreEncargado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNombreRol;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslNombreEquipo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslHoraIngreso;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tslHoraSistema;
        private System.Windows.Forms.ToolStripStatusLabel tsclaveEncargado;
        private System.Windows.Forms.ToolStripMenuItem capturaYConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsFecha;
        private System.Windows.Forms.Timer timer1;
    }
}



