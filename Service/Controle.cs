
using System;


namespace SistemaBancario.Service
{
    public class Controle
    {
        public bool Verificar;

        public string Mensagem = "";
        
        public bool Acessar(string Login, string Senha)
        {
            return Verificar;
        }

        public string Cadastrar(string Nome, string Sobrenome, string Telefone, string Email, string CPF, string Senha, string ConfSenha)
        {
            return Mensagem;
        }
    }
}
