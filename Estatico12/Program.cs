using System;

class Program
{
    static void Main(string[] args)
    {
        Exemplo.nome = "Kennan";
        Console.WriteLine("Olá " + Exemplo.nome);
        Exemplo.soma(3, 7);
    }
}