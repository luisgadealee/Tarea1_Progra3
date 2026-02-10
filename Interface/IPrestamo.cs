using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.Interface
{
    public interface IPrestamo
    {
        void SolicitarPrestamo(decimal monto);

        void PagarPrestamo(decimal monto);
    }



}
