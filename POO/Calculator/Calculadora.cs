using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
   public class Calculadora
    {
       
        public float Numero1;
        public float Numero2;

       
        public void Somar(float numero1, float numero2)
        {
            Console.WriteLine($"Resultado da Soma: {numero1 + numero2}");
        }

        public void Subtrair(float numero1, float numero2)
        {
            Console.WriteLine($"Resultado da Subtração: {numero1 - numero2}");
        }

        public void Divisao (float numero1, float numero2)
        {
            Console.WriteLine($"Resultado da divisao: {numero1 / numero2}");
        }

        public void Multiplicacao (float numero1, float numero2)
        {
            Console.WriteLine($"Resultado da multiplicacao: {numero1 * numero2}");
        }

    }
}