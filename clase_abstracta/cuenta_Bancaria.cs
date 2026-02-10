using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{
    public abstract class CuentaBancaria
    {
        public string numeroCuenta { get; set; }
        public string titular { get; set; }
        public decimal saldo  { get; set; }

         public cuenta_Bancaria(string numeroCuenta, string titular, decimal saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
        }

        //Metodos para hacer sobrecargas
   

        public void Depositar(decimal monto)
        {
            Depositar(monto,"Deposito sin descripción")
        }


        public virtual void Depositar (decimal monto,  string descripcion) 
        {
            if (monto <= 0) 
                throw new ArgumentException("El monto debe ser mayor a 0")
                    Saldo += monto;
            Console.WriteLine("Descripción: " + descripcion + monto + "colones" );

        }

        public virtual void Retirar (decimal monto)
        {
            if (monto <= 0 || monto > saldo)
                throw new ArgumentException("No tiene fondos en la cuenta para el retiro, trate nuevamente");

                    Saldo -= monto; 
            Console.WriteLine("Retirando de la cuenta: " + monto + "colones");

        }


        // POLIMORFISMO
        public abstract decimal CalcularInteres();


      

    }
}