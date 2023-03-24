using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static void EhParteDeFibonacci()
        {
            Console.WriteLine("Resolvendo segunda questão: o número está na sequência de Fibonacci?");
            Console.WriteLine("Digite um numero inteiro positivo: (máx: 1836311903)");
            int.TryParse(Console.ReadLine(), out int numero);
            if (numero < 0 || numero > 1836311903)
            {
                Console.WriteLine($"Digite um número válido.");
            }
            List<int> sequenciaFibonacci = new List<int>();
            int proximoValor = 1;
            int limite = 45;

            for (int i = 0; i < limite; i++)
            {
                sequenciaFibonacci.Add(proximoValor);
                if (i > 0)
                {
                    proximoValor = sequenciaFibonacci[i] + sequenciaFibonacci[i - 1];
                }
                else
                {
                    proximoValor = sequenciaFibonacci[i] + 1;
                }
            }
            
            if (sequenciaFibonacci.Contains(numero))
            {
               Console.WriteLine($"O número {numero} pertence à Sequência Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à Sequência Fibonacci.");
            }
            Console.ReadKey();
        }

        public static void InverterString() 
        {
            Console.WriteLine("Digite uma entrada: ");
            string? entrada =  Console.ReadLine();
            if (String.IsNullOrEmpty(entrada) || String.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada nula ou em branco.");
            }
            else
            {
                var entradaInversa = new StringBuilder();
                for (int i = entrada.Length - 1; i >= 0; i--)
                {
                    entradaInversa.Append(entrada[i]);
                }
                
                Console.WriteLine(entradaInversa.ToString());
            }
            Console.ReadKey();
        }
    }
}