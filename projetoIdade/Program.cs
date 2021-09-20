using System;

namespace projeto9
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 0,anoDeNascimento = 0;
            int idade = anoAtual - anoDeNascimento;

            Console.WriteLine("Digite o ano em que você nasceu ??");
            anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual ??");
            anoAtual = int.Parse(Console.ReadLine());

            if(idade > 18){
                Console.WriteLine("Você pode votar :)");
            }
            else if(idade < 18){
                Console.WriteLine("Desculpe mais você não tem idade pra votar ainda");
            }
        }//Fim main
    }
}
