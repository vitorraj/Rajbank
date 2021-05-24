using System;
using System.Collections.Generic;
using System.Text;

namespace Rajbank.Class
{
    class conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; private set; }
        public string idUsuario { get; private set; }

        public void DefinirNumeroConta(int agencia,int cpf)
        {
            NumeroConta = agencia + cpf;
        }
        
        public void definirIdUsuario(string nome, int numerodaconta)
        {
            idUsuario = nome + numerodaconta.ToString();
        }
    }
}
