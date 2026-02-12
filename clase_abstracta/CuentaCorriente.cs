using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{
    
    public class CuentaCorriente : CuentaBancaria
{
        //Para la cuenta Corriente, creamos una constante de interes de 3% en decimal para cuentaCorriente, dado que hablamos de dinero es mejor que el double.
    private const decimal TasaInteres = 0.03m;

    public CuentaCorriente(string numeroCuenta, string titular)
        : base(numeroCuenta, titular) { }

        //Aplicamos polimorfismo de como funciona "Retirar"
        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("Monto inválido.");


            saldo -= monto;
            Console.WriteLine("Retiro realizado desde Cuenta Corriente: " + monto + " colones");
        }


        public override decimal CalcularInteres()
    {
        return saldo * TasaInteres;
    }

        public override void MostrarEstado()
        {
            Console.WriteLine("Tipo de cuenta: Cuenta Corriente");
            base.MostrarEstado();
        }

    }

}
