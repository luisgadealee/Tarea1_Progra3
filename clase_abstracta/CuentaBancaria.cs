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

        public CuentaBancaria(string numeroCuenta, string titular, decimal saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
        }

        protected CuentaBancaria(string numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
        }

        //Metodos para hacer sobrecargas


        public void Depositar(decimal monto)
        {
            Depositar(monto, "Depósito sin descripción");
        }


        public virtual void Depositar (decimal monto,  string descripcion) 
             {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a 0");
                         
            saldo += monto;
            Console.WriteLine("Descripción: " + descripcion + monto + " colones" );

             }

             public virtual void Retirar (decimal monto)
             {
                 if (monto <= 0 || monto > saldo)
                     throw new ArgumentException("No tiene fondos en la cuenta para el retiro, trate nuevamente");

                         saldo -= monto; 
                 Console.WriteLine("Retirando de la cuenta: " + monto + " colones");

             }


             // POLIMORFISMO
             public abstract decimal CalcularInteres();
        

      

    }
}