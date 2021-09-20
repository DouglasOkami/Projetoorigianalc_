namespace projetoFuncionariosMercearia.Funcionarios
{
    public class Funcionario
    {
        public int Codigo {get;set;}
        public string Nome{get;set;}
        public string Email{get;set;}
        public string Senha{get;set;}
        public string DataCadastrado{get;set;}
        public Funcionario(int _codigo, string _nome, string _email, string _senha , string _dataCadastrado){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastrado = _dataCadastrado;
        }//Fim funcionario
    }
}