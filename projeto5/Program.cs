using System;

namespace CalculaImc
{
    class Program
    {
        // 2.	 Faça um programa que receba a idade, o peso, altura e o sexo de 10 pessoas. Calcule e Exiba:
        // a.	Total de Homens;
        // b.	Total de Mulheres;
        // c.	Média de idade dos Homens;
        // d.	Média de idade das mulheres.
        // e.	Quantidade de pessoas que estão acima do peso, abaixo do peso e com o peso ideal.

        static void Main(string[] args)
        {
            int idade;
            double peso, altura;
            char sexo;
            int contador = 0;
            int contMasculino = 0, contFeminino = 0;
            int somaIdadeM = 0, somaIdadeF = 0;
            int contadorAbaixoPeso = 0, contadorPesoIdeal = 0, contadorAcimaPeso = 0;
            do
            {
                Console.WriteLine("Digite a idade:");
                idade = int.Parse(Console.ReadLine());//30

                Console.WriteLine("Digite o peso:");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o altura:");
                altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o genero M ou F");
                sexo = char.Parse(Console.ReadLine()); //M

                if (sexo == 'M')
                {
                    //Masculino
                    somaIdadeM = somaIdadeM + idade; //50
                    contMasculino = contMasculino + 1;  //2 
                }
                else
                {
                    //Feminino
                    somaIdadeF = somaIdadeF + idade;
                    contFeminino = contFeminino + 1;
                }
                // Calculo IMC
                double imc = peso/(altura*altura);

                if(imc < 18.5){
                    contadorAbaixoPeso++;
                }else if( imc < 25){
                    contadorPesoIdeal++;
                }else{
                    contadorAcimaPeso++;
                }
                contador = contador + 1;
            } while (contador < 3);

            Console.WriteLine($"A quantidade Homens = {contMasculino} e a média de idade = {somaIdadeM/contMasculino}");
            Console.WriteLine($"A quantidade Mulheres = {contFeminino} e a média de idade = {somaIdadeF/contFeminino}");
            Console.WriteLine($"Quandida de pessoas acima do peso = {contadorAcimaPeso}");
            Console.WriteLine($"Quandida de pessoas abaixo do peso = {contadorAbaixoPeso}");
            Console.WriteLine($"Quandida de pessoas com o peso ideal = {contadorPesoIdeal}");
        }
    }
}
