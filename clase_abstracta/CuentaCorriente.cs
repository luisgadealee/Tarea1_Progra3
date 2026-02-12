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

    public override decimal CalcularInteres()
    {
        return saldo * TasaInteres;
    }

    }

}
