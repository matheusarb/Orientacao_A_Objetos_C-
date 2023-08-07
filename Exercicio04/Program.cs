using System;

namespace Exercicio04;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Peso = 100.2;
        pessoa.Altura = 1.72;

        pessoa.MOSTRAR_RESULTADO();

    }
}