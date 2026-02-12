using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{
    public abstract class CuentaBancaria
    {
        private string numero;

        public string numeroCuenta { get; set; }
        public string titular { get; set; }
        public decimal saldo  { get; set; }

        //Para crear el constructor de CuentaBancaria, incluimos el numero de cuenta y el usuario dueño de la cuenta (titular).
        public CuentaBancaria(string numeroCuenta, string titular)
        {
            this.numero = numeroCuenta;
            this.titular = titular;
            saldo = 0;
        }

        //Metodos para hacer sobrecargas


        //En el caso de los depositos, el sistema en la consola va a preguntar por una descripcion. Si el usuario no pone nada, va a utilizar el primero
        //El primero solo usa el decimal monto, y pone automaticamente que no hay descripción.
        //Si se recibe descripcion, utilizará el virtual void de Depositar que incluye descripción. Asi tenemos la flexibilidad que nos da la sobrecarga.
        
        public void Depositar(decimal monto)
        {
            Depositar(monto, "Depósito sin descripción");
        }

        
        public virtual void Depositar (decimal monto,  string descripcion) 
             {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a 0");
                         
            saldo += monto;
            Console.WriteLine("Descripción: " + descripcion + " , " + monto + " colones");

             }

             public virtual void Retirar (decimal monto)
             {
                 if (monto <= 0 || monto > saldo)
                     throw new ArgumentException("No tiene colones suficientes en la cuenta para el retiro, trate nuevamente");

                         saldo -= monto; 
                 Console.WriteLine("Retirando de la cuenta: " + monto + " colones");

             }


             // POLIMORFISMO
             public abstract decimal CalcularInteres();

        // ESTADO DE CUENTA (pero con base para el polimorfismo)
        public virtual void MostrarEstado()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Saldo: " + saldo + " colones");
        }

    }
}