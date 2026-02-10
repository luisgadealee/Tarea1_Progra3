using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.clase_abstracta
{

    public class CuentaAhorro : CuentaBancaria
    {
        private const decimal TasaInteres = 0.03m;

        public CuentaAhorro(string numero, string titular) 
            : base(numero, titular) { }

        public override decimal CalcularInteres()
        {
            return saldo * TasaInteres;
        }

    }
}
