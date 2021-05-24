using System;
using System.Collections.Generic;
using System.Text;

namespace Rajbank.Class
{
    class ContaCorrente : conta
    {
        public ContaCorrente(double valorInicial)
        {
            SaldoContaCorrente = valorInicial;
        }
        private double SaldoContaCorrente { get; set; }

        public void depositarValor(double valor)
        {
            if (valor > 0)
            {
                SaldoContaCorrente += valor;
            }
            else { }
        }
        
        public double verificaValor()
        {
            return SaldoContaCorrente;
        }

        public string saqueValor(double saque)
        {
            if (saque < SaldoContaCorrente)
            {
                SaldoContaCorrente -= saque;
                return "saque efetuado";
            }
            else
            {
                return "impossivel fazer o saque";
            }
        }

    }
}
