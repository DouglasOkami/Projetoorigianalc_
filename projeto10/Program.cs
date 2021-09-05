using System;

namespace projeto10
{
    class Program
    {
        static void Main(string[] args)
        {
            double litrosGasolina = 0, litrosAlcool = 0, totalA = 0, totalG = 0, valorG = 0, valorA = 0, valorPA = 0, valorPG = 0, descontG = 0, descontA = 0, descontPA = 0, descontPG = 0;
            double A = 4.90, G = 5.30;

            string opcao;
            Console.WriteLine("-------------------------------------Bem vindo ao Posto Ipanema--------------------------------");
            Console.WriteLine("Digite 1 para Alcool e está R$ 4,90");
            Console.WriteLine("Até 20 litros, desconto de 3% por litro Álcool ,Acima de 20 litros, desconto de 5% por litro");
            Console.WriteLine("Digite 2 para Gasolina e está R$ 5,30 ,Até 20 litros, desconto de 4% por litro Gasolina");
            Console.WriteLine("Até 20 litros, desconto de 4% por litro Gasolina ,Acima de 20 litros, desconto de 6% por litro");
            Console.WriteLine("Digite 0 para sair");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":

                    Console.WriteLine("Digite quantos litros você quer de Álcool");
                    litrosAlcool = double.Parse(Console.ReadLine());
                    if (litrosAlcool <= 20)
                    {
                        valorA = A * litrosAlcool;
                        descontA = valorA * 0.03;
                        Console.WriteLine($"Valor a pagar pelo álcool com desconto , abaixo de 20 litros é { totalA = valorA - descontA}");
                    }
                    if (litrosAlcool > 20)
                    {
                        valorPA = A * litrosAlcool;
                        descontA = valorPA * 0.05;
                        Console.WriteLine($"Valor a pagar pelo álcool com desconto , acima de 20 litros é { totalA = valorPA - descontPA}");
                    }
                    break;
                case "2":
                    Console.WriteLine("Digite quantos litros você quer de Gasolina");
                    litrosGasolina = double.Parse(Console.ReadLine());
                    if (litrosGasolina <= 20)
                    {
                        valorG = G * litrosGasolina;
                        descontG = valorG * 0.04;
                        Console.WriteLine($"Valor a pagar pela gasolina com desconto , abaixo de 20 litros é {totalG = valorG - descontG}");
                    }
                    if (litrosGasolina > 20)
                    {
                        valorPG = G * litrosGasolina;
                        descontG = valorPG * 0.04;
                        Console.WriteLine($"Valor a pagar pela gasolina com desconto , acima de 20 litros é {totalG = valorPG - descontPG}");
                    }
                    break;
                case "0":
                    Console.WriteLine("Volte sempre :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }//Fim switch
        }//Fim main
    }
}
