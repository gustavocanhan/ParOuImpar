using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = -1;

            while(entrada != 0)
            {
                Console.Write("Insira um número inteiro (0 para sair): ");

                if (int.TryParse(Console.ReadLine(), out entrada))
                {
                    if(entrada % 2 == 0)
                    {
                        Console.WriteLine($"{entrada} - PAR.\n");
                    }
                    else
                    {
                        Console.WriteLine($"{entrada} - ÍMPAR.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.\n");
                    entrada = -1;
                }
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}
