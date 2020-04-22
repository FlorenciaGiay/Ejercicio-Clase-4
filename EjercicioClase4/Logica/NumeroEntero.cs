using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroEntero
    {
        public double Numero { get; set; }

        public static NumeroEntero operator /(NumeroEntero numero1, NumeroEntero numero2)
        {
            NumeroEntero resultado = new NumeroEntero();
            resultado.Numero = Convert.ToDouble(numero1.Numero / numero2.Numero);
            return resultado;
        }
    }
}
