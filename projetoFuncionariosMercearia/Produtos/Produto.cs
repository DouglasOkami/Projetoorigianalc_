namespace projetoFuncionariosMercearia.Produtos
{
    public class Produto
    {
        public int Codigo{get;set;}
        public string NomeProduto{get;set;}
        public double Preco{get;set;}
        public string Marca{get;set;}
        public string CadastradoPor{get;set;}
        public string DataCadastrado{get;set;}
        public Produto(int _codigo, string _nomeProduto, double _preco, string _marca, string _cadastradoPor, string _dataCadastrado){
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            Marca = _marca;
            CadastradoPor = _cadastradoPor;
            DataCadastrado = _dataCadastrado;
        }//Fim Produto
    }
}