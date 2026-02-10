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
            System.Console.WriteLine("Bienvenido al Sistema de Gestión Bancaria");
        

            CuentaBancaria cuenta = new CuentaAhorro("001", "Jorge Arroyo");

            cuenta.Depositar(100000);
            cuenta.Depositar(20000, "Ejemplo de un de deposito");

            Console.WriteLine($"Saldo: {cuenta.saldo}  colones");
 

            PrestamoPersonal prestamo = new PrestamoPersonal();
            prestamo.SolicitarPrestamo(200000);
            Console.WriteLine($"Interés préstamo: {prestamo.CalcularInteres()} colones");

            System.Console.WriteLine("Presione enter para cerrar...");
            System.Console.ReadLine();
        }
    }
}
