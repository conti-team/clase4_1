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
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Formulario Principal - Usuario Conectado: " + oDatosInicio.NombreUsuario;
        }
    }
}
