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
    public partial class FrmOperaciones : Form
    {
        DatosInicio oDatos = new DatosInicio();
        public FrmOperaciones(DatosInicio oDatosP)
        {
            oDatos = oDatosP;
            InitializeComponent();
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            this.Text = oDatos.NombreUsuario + ": esta realizando el siguiente calculo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado=0;
            num1 = Convert.ToDouble(txtVariable1.Text);
            num2 = Convert.ToDouble(txtVariable2.Text);
            if (rbDivision.Checked) resultado = num1 / num2;
            else if (rbMultiplicacion.Checked) resultado = num1 * num2;
            else if (rbExponenciacion.Checked) resultado = Math.Pow(num1, num2);
            txtResultado.Text = Math.Round(resultado, 2).ToString();
 
        }
    }
}
