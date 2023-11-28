using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Interfaz de la Implementacion
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>

        public int menu();

        public string pedirDNI();

        public int modificar();
    }
}
