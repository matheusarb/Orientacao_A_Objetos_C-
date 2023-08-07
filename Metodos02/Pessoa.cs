using System;

namespace Metodos02;

class Pessoa
{
    public void APRESENTAR()
    {
        Console.WriteLine("Olá!!!");
    }
    
    public void APRESENTAR(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }

    public void APRESENTAR(string nome, int idade)
    {
        Console.WriteLine("OLá " + nome + " você tem " + idade + " anos.");
    }
    
}
