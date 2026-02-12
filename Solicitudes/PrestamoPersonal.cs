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

        //Creamos las variables que involucran el proceso de prestamos, el monto decimal (dinero) pendiente y la constante de interes, que es de 5% para el personal
        //En otra clase se habló, pero la "m" asegura que el numero sea decimal, y al ser un interes lo definimos como una constante.
        public decimal MontoPendiente { get; set; }
        private const decimal TasaInteres = 0.05m;

        public void SolicitarPrestamo(decimal monto)
        {
            MontoPendiente = monto;
            Console.WriteLine("Préstamo aprobado por "+ monto + " colones");
        }

        // Al Monto pendiente le vamos a restar el valor pagado. Si este resultado es mayor o igual que 0, se registra y ya
        //Pero si el pago excede el monto pendiente, transforma el monto pendiente en 0, para evitar quedar en negativos con la deuda.
        public void PagarPrestamo(decimal monto)
        {
                    
            MontoPendiente -= monto;

            if (MontoPendiente >= 0)
            {
                Console.WriteLine("Pago realizado: " + monto + " colones");
            }
            else {
                MontoPendiente = 0;
                Console.WriteLine("Pago realizado: " + monto + " colones");
                    }
        }

        // Con este metodo podemos ver cuanto debemos de los prestamos exclusivamente, nos permite ver el interes sobre el prestamo y nos muestra el total con intereses.
        public void ConsultarPrestamos ()
        {
            Console.WriteLine("Prestamo actual adquirido: " + MontoPendiente + " colones.");
            Console.WriteLine("Intereses sobre prestamo al 5%: " + CalcularInteres() + " colones.");
            Console.WriteLine("Monto total a pagar de prestamo: " + PrestamoMontoTotal() + " colones.");
        }


        public decimal CalcularInteres()
        {
            return MontoPendiente * TasaInteres;
        }

        public decimal PrestamoMontoTotal()
        {
            return (MontoPendiente * TasaInteres) + MontoPendiente;
        }
    }
    
    
}
