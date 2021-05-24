using System;
using System.Collections.Generic;
using System.Text;

namespace Rajbank.Class
{
    class usuarioBanco
    {
        public usuarioBanco(string nome, string cpf)
        {
            nomeUsuario = nome;
            cpfUsuario = cpf;
        }
        public string nomeUsuario { get; private set; }
        public string cpfUsuario { get; private set; }
        public string loginUsuario { get; set; }
        private string senhaUsuario { get; set; }
        
        public int definirSenha(string minhasenha)
        {
            int verificaSenha;
            if (minhasenha.Length < 8)
            {
                verificaSenha = 1;
                return verificaSenha;
            }
            else
            {
                verificaSenha = 2;
                senhaUsuario = minhasenha;
                return verificaSenha;
            }
        }

        public string alterarSenha(string novaSenha, string senhaAntiga)
        {
            if(novaSenha == senhaAntiga)
            {
                senhaUsuario = senhaAntiga;
                return senhaAntiga;
            }
            else
            {
                senhaUsuario = novaSenha;
                return novaSenha;
            }
        }

    }
}
