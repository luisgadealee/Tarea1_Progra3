using Sistema_Gestion_Bancaria.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.Solicitudes
{
    public class PrestamoPersonal : IPrestamo
    {

        //creamos las variables que involucran el proceso de prestamos, el monto decimal (dinero) pendiente y la constante de interes, que es de 5% para el personal.
        public decimal MontoPendiente { get; set; }
        private const decimal TasaInteres = 0.05m;

        public void SolicitarPrestamo(decimal monto)
        {
            MontoPendiente = monto;
            Console.WriteLine($"Préstamo aprobado por {monto} colones");
        }

        public void PagarPrestamo(decimal monto)
        {
            MontoPendiente -= monto;
            Console.WriteLine($"Pago realizado: {monto} colones");
        }

        public decimal CalcularInteres()
        {
            return MontoPendiente * TasaInteres;
        }
    }
    
    
}
