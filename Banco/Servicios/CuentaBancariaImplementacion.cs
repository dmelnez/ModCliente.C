using Banco.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{ 
    internal class CuentaBancariaImplementacion : CuentaBancariaInterfaz
    {
        public void cuentaBancaria(List<cuentaBancaria> cuentaBancaria)
        {

            /// <summary>
            /// Metodo el cual añade una nueva bancaria y solicita al usuario. Y es añadida a una nueva lista 
            /// DMN - 21/11/2023
            /// </summary>
            /// <param name="args"></param>

            cuentaBancaria cuentaNueva = new cuentaBancaria();

            Console.WriteLine("#############################");
            Console.WriteLine("### Nuevo Cuenta Bancaria ###");
            Console.WriteLine("#############################");
            Console.WriteLine("### Introduzca sus Datos ####");
            Console.WriteLine("#############################");

            Console.WriteLine("Id Cuenta Bancaria: ");
            cuentaNueva.IdCuentaBancaria = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("ISBAN: ");
            cuentaNueva.IsbanCuentaBancaria = Console.ReadLine();
            Console.WriteLine("Fecha de Alta: ");
            cuentaNueva.FchAltaCuentaBancaria = Console.ReadLine();
            Console.WriteLine("Id Cliente: ");
            cuentaNueva.IdCliente = Convert.ToInt64(Console.ReadLine());
        }
    

    }
    
}
