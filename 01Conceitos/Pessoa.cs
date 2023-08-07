using System;

namespace Conceitos01
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public void LER_MENSAGEM()
        {
            Console.WriteLine("Olá " + Nome + " você tem " + Idade + " anos.");
        }
    }
}
