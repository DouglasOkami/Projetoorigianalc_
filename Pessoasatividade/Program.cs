using System;

namespace Pessoas_atividade
{
    class Program
    {
        static void Main(string[] args)
        {            
            int contador = 0, aprovado = 0, reprovado = 0;

            do
            {
                Console.WriteLine("Digite a idade de " + (10 - contador) + " pessoas");
                int idadeEscreva = int.Parse(Console.ReadLine());

                if(idadeEscreva >= 18){
                    Console.WriteLine("Aprovado");
                    aprovado = aprovado + 1;
                }else if (idadeEscreva <= 17){
                    Console.WriteLine("Reprovado");
                    reprovado = reprovado + 1;
                }else{
                    Console.WriteLine("Operação inválida");
                    break;
                }   
                contador = contador + 1;      
            } while (contador < 10);

            Console.WriteLine("pessoas com idade maior que 18 = "+aprovado+" pessoas com idade menor que 18 = "+reprovado);
        }
    }
}
