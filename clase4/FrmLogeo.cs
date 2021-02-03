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
    public partial class FrmLogeo : Form
    {
        public FrmLogeo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            if (usuario == string.Empty)
            {
                MessageBox.Show("Ingrese su usuario");
                return;
            }
            string pass = txtpass.Text;
            if (pass != "123")
            {
                MessageBox.Show("Ingrese clave correcta");
                return;
            }else
            {
                DatosInicio oDatos = new DatosInicio("codigoUsuario",usuario);
                //FrmMenuPrincipal oFrmMenuPrincipal = new FrmMenuPrincipal(oDatos);
                //oFrmMenuPrincipal.Show();
                FrmPerfil ofrmPerfil = new FrmPerfil(oDatos);
                ofrmPerfil.Show();
                this.Hide();
            }
            
        }
    
    }
}
