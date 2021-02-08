using System;


namespace SistemaBancario.Service
{
    class Comandos
    {
        public bool Verificar;

        public string Mensagem;

        public bool VerificarLogin(string Login, string senha)
        {
            return Verificar;

        }

        public string Cadastrar(string Nome, string sobrenome, string Telefone, string Email, string CPF, string Senha, string Confsenha)
        {
            return Mensagem;
        }
    }
}
