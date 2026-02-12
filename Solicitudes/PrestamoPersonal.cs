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
            MontoPendiente = monto + (monto * TasaInteres);
            Console.WriteLine("Préstamo aprobado por "+ monto + " colones");
            Console.WriteLine("Monto total con intereses: " + MontoPendiente + " colones");
        }

        // Al Monto pendiente le vamos a restar el valor pagado. Si este resultado es mayor o igual que 0, se registra y ya
        //Pero si el pago excede el monto pendiente, transforma el monto pendiente en 0, para evitar quedar en negativos con la deuda.
        public void PagarPrestamo(decimal monto)
        {
                    
            MontoPendiente -= monto;

            if (MontoPendiente > 0)
            {
                Console.WriteLine("Pago realizado: " + monto + " colones");
                Console.WriteLine("Saldo pendiente del préstamo: " + MontoPendiente + " colones");
            }
            else {
                MontoPendiente = 0;
                Console.WriteLine("Pago realizado: " + monto + " colones. \n Prestamo completamente Pagado.");
                    }
        }

        // Con este metodo podemos ver cuanto debemos de los prestamos exclusivamente, nos permite ver el interes sobre el prestamo y nos muestra el total con intereses.
        public void ConsultarPrestamos ()
        {
  
            Console.WriteLine("Saldo total a pagar de prestamo + intereses: " + MontoPendiente + " colones.");
        }


        public decimal CalcularInteres()
        {
            return MontoPendiente * TasaInteres;
        }

 
    }
    
    
}
