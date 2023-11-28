using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        /// <summary>
        /// Metodo el cual Muestra al usuario un menu de seleccion
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>

        public int menu()
        {

            Console.WriteLine("########## Seleccione una Opcion ##########");
            Console.WriteLine("0 -> Finalizar la Aplicacion");
            Console.WriteLine("1 -> Añadir un Nuevo usuario");
            Console.WriteLine("2 -> Crear cuenta Bancaria");
            Console.WriteLine("3 -> Eliminar Cuenta Bancaria");
            Console.WriteLine("4 -> Ver Clientes");
            Console.WriteLine("###########################################");
            int seleccionMenu = Convert.ToInt32(Console.ReadLine());
            return seleccionMenu;

        }



        public string pedirDNI() {



            Console.WriteLine("Indica el DNI del Cliente");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }


        public int modificar()
        {

            Console.WriteLine("Introduzca el Campo que desea Modificar");
            Console.WriteLine("1 -> ID");
            Console.WriteLine("2 -> Nombre");
            Console.WriteLine("3 -> Apellido");
            Console.WriteLine("4 -> DNI");
            Console.WriteLine("5 -> Fecha de Nacimiento");
            Console.WriteLine("6 -> Email");
            Console.WriteLine("7 -> Telefono");
            Console.WriteLine("8 -> Fecha de Alta");
        }
    }
}
