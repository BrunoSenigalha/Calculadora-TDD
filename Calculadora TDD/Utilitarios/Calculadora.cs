using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_TDD.Utilitarios
{
    public class Calculadora
    {
        public double soma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }

        public double divisao(double num1, double num2)
        {
            if (num2 <= 0)
            {
                throw new DivideByZeroException("Não pode ser dividido por zero");
            }
            return num1 / num2;
        }
    }
}
