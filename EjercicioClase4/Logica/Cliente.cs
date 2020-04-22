using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int CUIT { get; set; }
        public double Saldo { get; set; }

        public static Cliente operator-(Cliente cliente1, Cliente cliente2)
        {
            Cliente nuevoCliente = new Cliente();
            if (cliente1.CUIT==cliente2.CUIT)
            {
                nuevoCliente.Saldo = cliente1.Saldo - cliente2.Saldo;
            }
            else
            {
                if(cliente1.Saldo<cliente2.Saldo)
                {
                    nuevoCliente.Saldo = cliente1.Saldo;
                }
                else
                {
                    nuevoCliente.Saldo = cliente2.Saldo;
                }
            }
            return nuevoCliente;
        }
    }
}
