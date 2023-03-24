using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico
{
    public static class Questoes
    {
        public static void CalcularSoma()
        {
            Console.WriteLine("Resolvendo primeira questão: Calcular SOMA...");
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine($"Resultado da soma é: {soma}");
            Console.ReadKey();
        }

        
    }
}