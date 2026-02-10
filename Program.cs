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
            System.Console.WriteLine("Prueba");
            System.Console.WriteLine("Prueba Luis para subir cambio");
            System.Console.WriteLine("Prueba Jorge .2");
            System.Console.WriteLine("Prueba Luis para subir cambio 2");
            System.Console.WriteLine("Prueba Jorge 3 - Linea simultanea mientras edita su codigo.");



            System.Console.WriteLine("Presione enter para cerrar...");
            System.Console.ReadLine();



            CuentaBancaria cuenta = new CuentaAhorro("001", "Jorge Arroyo");

            cuenta.Depositar(100000);
            cuenta.Depositar(20000, "Muestra de deposito");

            Console.WriteLine($"Saldo: ₡{cuenta.Saldo}");
 

            PrestamoPersonal prestamo = new PrestamoPersonal();
            prestamo.SolicitarPrestamo(200000);
           // Console.WriteLine($"Interés préstamo: ₡{prestamo.CalcularInteres()}");
        }
    }
}
