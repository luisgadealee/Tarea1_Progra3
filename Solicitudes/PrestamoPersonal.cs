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
        public decimal MontoPendiente { get; private set; }
        private const decimal TasaInteres = 0.05m;

        public void SolicitarPrestamo(decimal monto)
        {
            MontoPendiente = monto;
            Console.WriteLine($"Préstamo aprobado por ₡{monto}");
        }

        public void PagarPrestamo(decimal monto)
        {
            MontoPendiente -= monto;
            Console.WriteLine($"Pago realizado: ₡{monto}");
        }

        public decimal CalcularInteres()
        {
            return MontoPendiente * TasaInteres;
        }
    }
    
    
}
