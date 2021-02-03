using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase4
{
    public partial class FrmMenuPrincipal : Form
    {
        //string datoUsuario;
        DatosInicio oDatosInicio = new DatosInicio();
        public FrmMenuPrincipal(DatosInicio datos)
        {
            //datoUsuario = usuario;
            oDatosInicio.CodigoUsuario = datos.CodigoUsuario;
            oDatosInicio.NombreUsuario = datos.NombreUsuario;
            oDatosInicio.NombrePerfil = datos.NombrePerfil;
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            cambiaTitulo();
        }

        private void cambiaTitulo()
        {
            this.Text = "Formulario Principal - Usuario Conectado: " + oDatosInicio.NombreUsuario + " - Perfil: " + oDatosInicio.NombrePerfil;
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones oFrmOperaciones = new FrmOperaciones(oDatosInicio);
            oFrmOperaciones.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPopup = new FrmPerfil(oDatosInicio);
            DialogResult result = formPopup.ShowDialog();
            if (result == DialogResult.OK)
            {
                oDatosInicio.NombrePerfil = formPopup.perfil;
                cambiaTitulo();
            }
        }
    }
}
