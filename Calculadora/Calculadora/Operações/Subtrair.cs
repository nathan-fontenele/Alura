using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operações
{
    public class Subtrair
    {
        public int Calcular (int valor1, int valor2)
        {
            if(valor1 > valor2)
            {
                return valor1 - valor2;
            }
            else
            {
                return valor2 - valor1;
            }
        }
    }
}
