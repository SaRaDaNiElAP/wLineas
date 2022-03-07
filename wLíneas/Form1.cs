using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Nombre: Sara Daniela Parra Betancur
/// Fecha: 7/03/2022
/// Ejercicio: Dibujo Líneas
/// </summary>

namespace wLíneas
{
    public partial class Form1 : Form

    {
        Graphics liniesitas;
        public Form1()
        {
            InitializeComponent();
            liniesitas = CreateGraphics();
        
        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            try
            {
                float xinicial = float.Parse(txtxinicio.Text);
                float yinicial = float.Parse(txtyinicio.Text);
                float xfinal = float.Parse(txtxfin.Text);
                float yfinal = float.Parse(txtyfin.Text);
                clsLinea linea = new clsLinea(xinicial, yinicial, xfinal, yfinal);
                liniesitas.DrawLine(Pens.HotPink, xinicial, yinicial, xfinal, yfinal);
                txtnumlineas.Text = Convert.ToString(clsLinea.contar());

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un valor que sea válido");
            }
        }
    }
}
