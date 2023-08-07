using System;
using System.Diagnostics.CodeAnalysis;

namespace Construtor07;

class Pessoa7
{

    //Construtor: Assim que você instancia um objeto, o construtor é executado

    //1ºConstrutor
    public Pessoa7()
    {
        Console.WriteLine("Construtor executado");
    }

    // 2º Constrtuor
    public Pessoa7(string nome)
    {
        Console.WriteLine("olá "+nome);
    }

    // 3º Construtor
    public Pessoa7(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, vc tem {idade} anos");
    }
}
