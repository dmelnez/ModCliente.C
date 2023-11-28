

namespace Banco.Dtos
{
    internal class ClientesDtos
    {
        /// <summary>
        /// Clase que contiene todos los atributos de los campos que tendra el usuario
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>


        long idCliente;

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string dniCliente = "aaaaa";

        string fchNacimientoCliente = "9999/12/31";

        string emailCliente = "aaaaa";

        int tlfCliente = 111111111;

        string fchAltaCliente = "9999/12/31";

        string fchBajaCliente = "9999/12/31";

        public ClientesDtos(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
        }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
    }





    internal class cuentaBancaria

    {
        /// <summary>
        /// Clase que contendra todos los atributos de los campos del banco
        /// DMN - 21/11/2023
        /// </summary>
        /// <param name="args"></param>


        long idCuentaBancaria;

        long idCliente;

        string switchCuentaBancaria = "CSI1SSXX";

        string numeroCuentaBancaria = "9999/12/31";

        string isbanCuentaBancaria = "9999/12/31";

        string fchAltaCuentaBancaria = "9999/12/31";

        string fchBajaCuentaBanacaria = "9999/12/31";


        public long IdCuentaBancaria { get => idCuentaBancaria; set => idCuentaBancaria = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string SwitchCuentaBancaria { get => switchCuentaBancaria; set => switchCuentaBancaria = value; }
        public string NumeroCuentaBancaria { get => numeroCuentaBancaria; set => numeroCuentaBancaria = value; }
        public string IsbanCuentaBancaria { get => isbanCuentaBancaria; set => isbanCuentaBancaria = value; }
        public string FchAltaCuentaBancaria { get => fchAltaCuentaBancaria; set => fchAltaCuentaBancaria = value; }
        public string FchBajaCuentaBanacaria { get => fchBajaCuentaBanacaria; set => fchBajaCuentaBanacaria = value; }


        public cuentaBancaria(long idCuentaBancaria, string switchCuentaBancaria, string numeroCuentaBancaria, string isbanCuentaBancaria, string fchAltaCuentaBancaria, string fchBajaCuentaBanacaria)
        {

            /// <summary>
            /// Constructos de las cuentas bancarias
            /// DMN - 21/11/2023
            /// </summary>
            /// <param name="args"></param>


            this.idCuentaBancaria = idCuentaBancaria;
            this.switchCuentaBancaria = switchCuentaBancaria;
            this.numeroCuentaBancaria = numeroCuentaBancaria;
            this.isbanCuentaBancaria = isbanCuentaBancaria;
            this.fchAltaCuentaBancaria = fchAltaCuentaBancaria;
            this.fchBajaCuentaBanacaria = fchBajaCuentaBanacaria;
        }

        public cuentaBancaria(){

            /// <summary>
            /// Constructor vacio de las cuentas bancarias
            /// DMN - 21/11/2023
            /// </summary>
            /// <param name="args"></param>


        }

        override

        public string ToString()
        {

            string clientsStrings =


            "ID: " + this.idCliente = idCliente +
            "Nombre: " + this.nombreCliente +
            "Apellidos: " + this.apellidosCliente +
            "DNI: " + this.dniCliente +
            "Fecha de Nacimiento: " + this.fchNacimientoCliente +
            "Email: " + this.emailCliente +
            "Nº Telefono: " + this.tlfCliente +
            "Fecha de Alta: " + this.fchAltaCliente +
            "Fecha de Baja: " + this.fchBajaCliente;


        }


    }

}