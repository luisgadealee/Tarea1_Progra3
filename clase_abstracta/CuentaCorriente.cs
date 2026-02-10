using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{
    
    public class CuentaCorriente : CuentaBancaria
{
    private const decimal TasaInteres = 0.01m;

    public CuentaCorriente(string numero, string titular)
        : base(numero, titular) { }

    public override decimal CalcularInteres()
    {
        return saldo * TasaInteres;
    }

    }

}
