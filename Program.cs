using Sistema_Gestion_Bancaria.clase_abstracta;
using Sistema_Gestion_Bancaria.Solicitudes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //PROGRAMACION REALIZADA ENTRE LUIS GADEA Y JORGE ARROYO
            //UTILIZAMOS GITHUB PARA ACTUALIZAR SIMULTANEAMENTE NUESTRO PROYECTO MIENTRAS SOLUCIONABAMOS COMO HACERLO FUNCIONAR.
            //GRACIAS POR SU TIEMPO PROFE :)


            // Vamos a trabajar con un usuario precargado, Miguelito Pruebas. 
            CuentaBancaria cuenta;
            Console.WriteLine("*-*-*-*-* SISTEMA DE GESTIÓN BANCARIA *-*-*-*-*");
            System.Console.WriteLine("Tarea #1 - Programación III \n");
            Console.WriteLine("Seleccione tipo de cuenta:");
            Console.WriteLine("1. Cuenta Ahorro");
            Console.WriteLine("2. Cuenta Corriente");

            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
                cuenta = new CuentaAhorro("001", "Miguelito Pruebas");
            else
                cuenta = new CuentaCorriente("002", "Miguelito Pruebas");
           
            PrestamoPersonal prestamo = new PrestamoPersonal();

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("*-*-*-*-* SISTEMA DE GESTIÓN BANCARIA *-*-*-*-*");
                System.Console.WriteLine("Tarea #1 - Programación III \n");
                Console.WriteLine("1. Depositar colones");
                Console.WriteLine("2. Retirar colones");
                Console.WriteLine("3. Consultar saldo actual");
                Console.WriteLine("4. Calcular intereses sobre Cuenta");
                Console.WriteLine("5. Solicitar préstamo");
                Console.WriteLine("6. Pagar préstamo");
                Console.WriteLine("7. Consultar préstamo + intereses");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción con el numero respectivo: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nDigite cuantos colones desea depositar: \n");
                        decimal deposito = decimal.Parse(Console.ReadLine());

                        Console.Write("\nDigite la descripción del depósito (opcional): \n");
                        string descripcion = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(descripcion))
                        {
                            cuenta.Depositar(deposito);
                        }
                        else
                        {
                            cuenta.Depositar(deposito, descripcion);
                        }
                        break;

                    case 2:
                        Console.Write("\nDigite cuantos colones desea retirar: \n");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    case 3:
                        cuenta.MostrarEstado();
                        break;

                    case 4:
                        Console.WriteLine("\nCalculo de interés generado: " + cuenta.CalcularInteres() + " colones\n");
                        break;

                    case 5:
                        Console.Write("\nMonto del préstamo: \n");
                        decimal montoPrestamo = decimal.Parse(Console.ReadLine());
                        prestamo.SolicitarPrestamo(montoPrestamo);
                        break;

                    case 6:
                        Console.Write("\nMonto del prestamo a pagar: \n");
                        decimal pago = decimal.Parse(Console.ReadLine());
                        prestamo.PagarPrestamo(pago);
                        break;

                    case 7:
                        Console.Write("\nEstado de prestamo actual: \n");
                        prestamo.ConsultarPrestamos();
                        break;


                }
                System.Console.WriteLine("\n Presione enter para continuar... ");
                System.Console.ReadLine();

            } while(opcion != 0);

           

        }


    }

}

//Gracias por su tiempo profesor! Se hizo lo que se pudo, saludos :)