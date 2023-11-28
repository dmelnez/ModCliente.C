using Banco.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    internal interface CuentaBancariaInterfaz
    {
        /// <summary>
        /// Interfaz de la Implementacion
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>

        public void cuentaBancaria(List<cuentaBancaria> cuentaBancaria);
    }
}
