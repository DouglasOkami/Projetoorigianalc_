using System;
using projetoFuncionariosMercearia.Models;
using System.Collections.Generic;
using projetoFuncionariosMercearia.Funcionarios;
using projetoFuncionariosMercearia.Produtos;

namespace projetoFuncionariosMercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            List<Funcionario> listaFunc = new List<Funcionario>();

            ProdutoController produtoController = new ProdutoController();
            List<Produto> listaProd = new List<Produto>();
            string opcao;
            do
            {
                Console.WriteLine("1 - Cadastrar funcionário");
                Console.WriteLine("2 - Cadastrar produto");
                Console.WriteLine("3 - Listar funcionário");
                Console.WriteLine("4 - Listar produto");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Funcionario funcionarioRetornado = funcionarioController.CadatroDeFuncionarios();
                        listaFunc.Add(funcionarioRetornado);
                        break;
                    case "2":
                        Console.WriteLine("Digite o email do funcionário");
                        string emailFuncPesquisado = Console.ReadLine();
                        Console.WriteLine("Digite a senha do funcionário");
                        string senhaPesquisado = Console.ReadLine();
                        Funcionario funcLoginPes = funcionarioController.BuscarFuncionario(emailFuncPesquisado, listaFunc);
                        if (emailFuncPesquisado == null && senhaPesquisado == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                        }
                        else
                        {
                            if (senhaPesquisado != funcLoginPes.Senha)
                            {
                                Console.WriteLine("Senha inválida");
                            }
                            else
                            {
                                Produto produtoRetornado = produtoController.CadatroDeProdutos();
                                listaProd.Add(produtoRetornado);
                            }
                        }//fim else
                        break;
                    case "3":
                        funcionarioController.ListarFunc(listaFunc);
                        break;
                    case "4":
                        produtoController.ListarProd(listaProd);
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por usar nossos sistema , volte sempre :)");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }//fim switch
            } while (opcao != "0");
        }//fim Main
    }
}
