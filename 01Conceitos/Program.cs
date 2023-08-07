using System;

namespace Conceitos01;

class Program
{
    static void Main(string[] args)
    {
        Conceitos01.Pessoa obj = new Pessoa();
        obj.Nome = "Matheus";
        obj.Idade = 31;
        obj.LER_MENSAGEM();
    }
}