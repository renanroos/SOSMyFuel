using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSMyFuel
{
    static class CalculaMedia
    {
        public static int calculaLitros(int preco, int valor)
        {
            return valor / preco;
        }

        public static int calculaMedia(int kms, int litros)
        {
            return kms / litros;
        }

    }
}
