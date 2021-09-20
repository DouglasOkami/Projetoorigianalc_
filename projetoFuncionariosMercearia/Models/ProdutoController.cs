using System;
using System.Collections.Generic;
using projetoFuncionariosMercearia.Produtos;
namespace projetoFuncionariosMercearia.Models
{
    public class ProdutoController
    {
        public Produto CadatroDeProdutos()
        {
            Console.WriteLine($"Digite o código do produto");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a marca do produto");
            string marca = Console.ReadLine();

            Console.WriteLine($"Digite quem esta cadastrando");
            string cadastradoPor = Console.ReadLine();

            Console.WriteLine($"Digite a data que está cadastrando");
            string dataCadastrado = Console.ReadLine();

            Produto produto = new Produto(codigo, nomeProduto, preco, marca, cadastradoPor,dataCadastrado);

            return produto;
        }//fim Funcionario
        public void ListarProd(List<Produto> lista){
            Console.WriteLine("Digite o nome do produto cadastrado");
            string nomeProduto = Console.ReadLine();
            foreach (var item in lista)
            {
                Console.WriteLine($"Código: {item.Codigo} Nome: {item.NomeProduto} Preço: {item.Preco} Marca: {item.Marca} Produto cadastrador por: {item.CadastradoPor} Data de cadastro: {item.DataCadastrado}");
            }
        }//Fim ListarProd
        public Produto BuscarProduto(string usuarioPesquisado, List<Produto> lista)
        {
            Produto usuarioRetornado = lista.Find(produto => produto.NomeProduto == usuarioPesquisado);
            return usuarioRetornado;
        }// Fim buscar
    }
}