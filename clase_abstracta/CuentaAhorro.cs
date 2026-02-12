using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{


    public class CuentaAhorro : CuentaBancaria
    {
        //Creamos la tasa de interés, revisamos y como lo mencionamos anteriormente se usa decimal pues al parecer funciona mucho mejor que double en sistemas bancarios.
        //También al ser una tasa de interés fija, se utiliza "const" como constante, no se deberia definir nuevamente.
        //La "m" le indica al codigo en C# que ese numero es decimal (dinero). Por defecto, este lenguaje cree que cualquier numero con decimales es un double.
        
        
        private const decimal TasaInteres = 0.10m;

        //Investigando vimos que se tiene que llamar a la clase CuentaBancaria para que CuentaAhorro funcione bien, es una herencia.
        //Al crear el constructor de la clase que hereda (CuentaAhorro) se define que la base (CuentaBancaria) va a recibir esos datos de CuentaAhorro.

        public CuentaAhorro(string numeroCuenta, string titular) 
            : base(numeroCuenta, titular) { }

        //Retirar con polimorfismo para CuentaAhorro
        public override void Retirar(decimal monto)
        {
            if (monto <= 0 || monto > saldo)
                throw new ArgumentException("Fondos insuficientes en cuenta de ahorro.");

            saldo -= monto;
            Console.WriteLine("Retiro realizado desde Cuenta de Ahorro: " + monto + " colones");
        }

        public override decimal CalcularInteres()
        {
            return saldo * TasaInteres;
        }

        public override void MostrarEstado()
        {
            Console.WriteLine("Tipo de cuenta: Cuenta de Ahorro");
            base.MostrarEstado();
        }

    }
}
