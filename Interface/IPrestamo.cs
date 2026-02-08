using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Bancaria.Interface
{
    internal class IPrestamo
    {
    }

    public interface IPrestamo
    {
        void solicitarPrestamo();

        void pagarPrestamo();
    }

}
