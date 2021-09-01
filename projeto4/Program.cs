using System;

namespace imparPar
{
    class Program
    {
        static void Main(string[] args)
        {
         int[] par = new int[6];
            int[] numero = new int[6];
            int contador = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º de 6 numeros.");
                numero[i] = int.Parse(Console.ReadLine());
                if ((numero[i] % 2) == 0)
                {
                    par[contador] = numero[i];
                    contador++;
                }
            }

            Console.WriteLine($"Os numeros pares são :");
            for (int i = 0; i < contador; i++)
            {
                Console.Write($"{par[i]}, ");
            }   
        }
    }
}
