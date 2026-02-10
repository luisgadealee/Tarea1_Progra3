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
        

            CuentaBancaria cuenta = new CuentaAhorro("001", "Miguelito Pruebas");
            PrestamoPersonal prestamo = new PrestamoPersonal();

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTIÓN BANCARIA ===");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Calcular interés");
                Console.WriteLine("5. Solicitar préstamo");
                Console.WriteLine("6. Pagar préstamo");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Monto a depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        break;

                    case 2:
                        Console.Write("Monto a retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    case 3:
                        Console.WriteLine($"Saldo actual: {cuenta.saldo} colones");
                        break;

                    case 4:
                        Console.WriteLine($"Interés generado: {cuenta.CalcularInteres()} colones");
                        break;

                    case 5:
                        Console.Write("Monto del préstamo: ");
                        decimal montoPrestamo = decimal.Parse(Console.ReadLine());
                        prestamo.SolicitarPrestamo(montoPrestamo);
                        break;

                    case 6:
                        Console.Write("Monto a pagar: ");
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
