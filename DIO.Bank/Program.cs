using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisca, 0, 0, "Fulano de Tal");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
