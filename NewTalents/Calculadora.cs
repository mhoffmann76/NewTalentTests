using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            return res;
        }
        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            return res;

        }
        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            return res;

        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            return res;

        }


    }
}