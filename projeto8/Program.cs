using System;

namespace projeto8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[12];
            int[] numTempMes = new int[12];
            int i, indiceMaior, indiceMenor;
            float menor = 99, maior = 0;

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine($"Digite a temperatura média do {i + 1}º mes de 12 meses.");
                numTempMes[i] = int.Parse(Console.ReadLine());

                for (i = 0; i < 12; i++)
                {
                    Console.WriteLine("Digite a temperatura do mes %d: ", i + 1);
                    Console.WriteLine($"%f, {temp[i]}");
                }
                for (i = 0; i < 12; i++)
                {
                    if (menor > temp[i])
                    {
                        menor = temp[i];
                        indiceMenor = i;
                    }
                    if (maior < temp[i])
                    {
                        maior = temp[i];
                        indiceMaior = i;
                    }
                }
            }//fim for

            Console.WriteLine("A menor temperatura foi %.2f e ocorreu no mes ", menor);
           
        }
    }
}
