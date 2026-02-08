using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{
    abstract public class cuenta_Bancaria
    {
        public string numeroCuenta { get; set; }
        public string titular { get; set; }
        public decimal saldo { get; set; }
        public cuenta_Bancaria(string numeroCuenta, string titular, decimal saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
        }
        public abstract void Depositar(decimal monto);
        public abstract void Retirar(decimal monto);


        public virtual void Depositar(decimal monto)
        {
            Depositar(monto,"Deposito sin descripción")
        }


        public virtual void Depositar (decimal monto,  string descripcion) 
        {
            if (monto <= 0) 
                throw new ArgumentException("El monto debe ser mayor a 0")

        }

        public virtual void Retirar (decimal monto)
        {

        }
}
