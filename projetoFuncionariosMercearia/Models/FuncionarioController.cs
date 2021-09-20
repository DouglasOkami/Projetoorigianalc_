using System;
using System.Collections.Generic;
using projetoFuncionariosMercearia.Funcionarios;
namespace projetoFuncionariosMercearia.Models
{
    public class FuncionarioController
    {
          public Funcionario CadatroDeFuncionarios()
        {
            Console.WriteLine($"Digite o código do usuário");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do usuário");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite um email");
            string email = Console.ReadLine();

            Console.WriteLine($"Digite uma senha");
            string senha = Console.ReadLine();

            Console.WriteLine($"Digite a data que esta cadastrando");
            string dataCadastrado = Console.ReadLine();

            Funcionario funcionario = new Funcionario(codigo, nome, email, senha, dataCadastrado);

            return funcionario;
        }//fim Funcionario
        public void ListarFunc(List<Funcionario> lista){
            Console.WriteLine("Digite o email cadastrado");
            string email = Console.ReadLine();
            foreach (var item in lista)
            {
                Console.WriteLine($"Código: {item.Codigo} Nome: {item.Nome} Email: {item.Email} Senha: {item.Senha} Data de Cadastro: {item.DataCadastrado}");
            }
        }//Fim ListarFunc
        public Funcionario BuscarFuncionario(string funcionarioPesquisado, List<Funcionario> lista)
        {
            Funcionario FuncionarioRetornado = lista.Find(funcionario => funcionario.Email == funcionarioPesquisado);

            return FuncionarioRetornado;
        }// Fim buscar

        internal static Funcionario BuscarFuncionario()
        {
            throw new NotImplementedException();
        }
    }
}