using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class ConversorTemperatura
    {
        public static double ObtenerTemperaturaFahrenheit(double temperatura)
        {
            return temperatura * 2.12;
        }

        public static double ObtenerTemperaturaCelcius(double temperatura)
        {
            return temperatura / 2.12;
        }
    }
}
