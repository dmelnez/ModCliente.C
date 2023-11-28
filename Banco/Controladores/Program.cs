using Banco.Dtos;
using Banco.Servicios;

namespace Banco
{

    class Program
    {
        /// <summary>
        /// Clase principal de la aplicacion
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            /// <summary>
            /// Metodo Principal de la aplicacion
            /// DMN - 21/11/2023
            /// </summary>
            /// <param name="args"></param>

            MenuInterfaz mi = new MenuImplementacion();
            AltaClienteInterfaz mi01 = new AltaClienteImplementacion();
            CuentaBancariaInterfaz mi02 = new CuentaBancariaImplementacion();

            List<ClientesDtos> listaClientes = new List<ClientesDtos>();
            List<cuentaBancaria> cuentasBancarias = new List<cuentaBancaria>();



            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                int seleccionMenu = mi.menu();

                switch (seleccionMenu)
                {

                    case 0:

                        Console.WriteLine("0 --> Cierre de la Apliacion");
                        cerrarMenu = true;
                        break;


                    case 1:
                        Console.WriteLine("1 --> Darse de Alta como Cliente");
                        mi01.clienteAlta(listaClientes);
                        break;


                    case 2:
                        Console.WriteLine("2 --> Creacion de una cuenta Bancaria");
                        mi02.cuentaBancaria(cuentasBancarias);
                        break;

                    case 3:
                        /*Console.WriteLine("2 --> Creacion de una cuenta Bancaria");
                        mi02.cuentaBancaria(cuentasBancarias);*/
                        break;

                    case 4:
                        Console.WriteLine("4 --> Ver Clientes");

                        foreach (ClientesDtos clientes in listaClientes)
                        {
                            Console.WriteLine(clientes.ToString());
                        }
                        
                        break;


                    default:
                        Console.WriteLine("###########################################");
                        Console.WriteLine("########### Seleccion no Valida ########### ");
                        Console.WriteLine("###########################################");
                        break;


                }




            }




        }






    }

}
