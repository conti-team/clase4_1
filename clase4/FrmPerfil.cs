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
    public partial class FrmPerfil : Form
    {
        public string perfil;
        DatosInicio oDatos = new DatosInicio();
        public FrmPerfil(DatosInicio DatosPerfil)
        {
            oDatos.CodigoUsuario = DatosPerfil.CodigoUsuario;
            oDatos.NombreUsuario = DatosPerfil.NombreUsuario;
            if (DatosPerfil.NombrePerfil != null)
            {
                oDatos.NombrePerfil = DatosPerfil.NombrePerfil;
            }
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbPerfil.SelectedIndex != -1)
            {
                //MessageBox.Show((oDatos.NombrePerfil == null).ToString());
                if (oDatos.NombrePerfil == null)
                {
                    oDatos.NombrePerfil = cmbPerfil.Text;
                    FrmMenuPrincipal oFrmMenuPrincipal = new FrmMenuPrincipal(oDatos);
                    oFrmMenuPrincipal.Show();
                    this.Hide();
                    
                }
                else
                {
                    oDatos.NombrePerfil= cmbPerfil.Text;
                    this.perfil = oDatos.NombrePerfil;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Perfil");
            }
        }
    }
}
