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
            System.Console.WriteLine("Bienvenido al Sistema de Gestión Bancaria\n");
        
            //PROGRAMACION REALIZADA ENTRE LUIS GADEA Y JORGE ARROYO
            //UTILIZAMOS GITHUB PARA ACTUALIZAR SIMULTANEAMENTE NUESTRO PROYECTO MIENTRAS SOLUCIONABAMOS COMO HACERLO FUNCIONAR.
            //GRACIAS POR SU TIEMPO PROFE :)


           
            CuentaBancaria cuenta = new CuentaAhorro("001", "Miguelito Pruebas");
            CuentaBancaria cuenta2 = new CuentaAhorro("002", "Danilo Gutierrez");
            PrestamoPersonal prestamo = new PrestamoPersonal();

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("*-*-*-*-* SISTEMA DE GESTIÓN BANCARIA *-*-*-*-*");
                Console.WriteLine("1. Depositar colones");
                Console.WriteLine("2. Retirar colones");
                Console.WriteLine("3. Consultar saldo actual");
                Console.WriteLine("4. Calcular interés");
                Console.WriteLine("5. Solicitar préstamo");
                Console.WriteLine("6. Pagar préstamo");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción con el numero respectivo: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Digite cuantos colones desea depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        break;

                    case 2:
                        Console.Write("Digite cuantos colones desea retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    case 3:
                        Console.WriteLine($"Saldo actual: {cuenta.saldo} colones");
                        break;

                    case 4:
                        Console.WriteLine($"Calculo de interés generado: {cuenta.CalcularInteres()} colones");
                        break;

                    case 5:
                        Console.Write("Monto del préstamo: ");
                        decimal montoPrestamo = decimal.Parse(Console.ReadLine());
                        prestamo.SolicitarPrestamo(montoPrestamo);
                        break;

                    case 6:
                        Console.Write("Monto del prestamo a pagar: ");
                        decimal pago = decimal.Parse(Console.ReadLine());
                        prestamo.PagarPrestamo(pago);
                        break;
                }

                System.Console.WriteLine("\n Presione enter para cerrar...");
            System.Console.ReadLine();
        } while(opcion != 0);
        }
    }
}
