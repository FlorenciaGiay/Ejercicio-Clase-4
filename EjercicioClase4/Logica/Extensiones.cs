using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Extensiones
    {
        public static int RetornarCantidadPalabras(this string cadena)
        {
            string[] arregloPalabras = cadena.Split(' ');
            return arregloPalabras.Count();
        }

        public static int RetornarCantidadPalabras(this string cadena, char separador)
        {
            string[] arregloPalabras = cadena.Split(separador);
            return arregloPalabras.Count();
        }

        public static decimal CalcularDiferenciaFechas(this DateTime fechaMayor, DateTime fechaMenor)
        {
            return Convert.ToDecimal((fechaMayor - fechaMenor).TotalSeconds) / 60;
        }

        public static double DevolverPromedio(this List<int> listaNumeros)
        {
            return Convert.ToDouble(listaNumeros.Average());

        }

        public static int ObtenerMultipicacionSumaParesRestaImpares(this List<int> listaNumeros)
        {
            return (listaNumeros.FindAll(x => x % 2 == 0).Sum()) * ((listaNumeros.First(x=>x % 2 != 0)*2) + ((listaNumeros.FindAll(x => x % 2 != 0).Sum())*-1));
        }
    }
}
