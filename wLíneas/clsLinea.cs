using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/// <summary>
/// Nombre: Sara Daniela Parra Betancur
/// Fecha: 7/03/2022
/// Ejercicio: Dibujo Líneas
/// </summary>

namespace wLíneas
{
    class clsLinea
    {
        private int xinicial;
        private int xfinal;
        private int yinicial;
        private int yfinal;
        private static int contador = 0;

        public clsLinea()
        {
            xinicial = 0;
            xfinal = 0;
            yinicial = 0;
            yfinal = 0;

        }

        public clsLinea(double xinicial,double yinicial, double xfinal, double yfinal)
        {
            this.xinicial = (int)xinicial;
            this.yinicial = (int)yinicial;
            this.xfinal = (int)xfinal;
            this.yfinal = (int)yfinal;

        }

        public static int contar()
        {
            contador += 1;
            return contador;
        }


    }
}
