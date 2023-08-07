using System;

class Program
{
    static void Main(string[] args)
    {
        Imposto gerente = new Gerente();
        Imposto atendente = new Atendente();
        Imposto estagiario = new Estagiario();

        gerente.valeAlimentacao(10000);
        gerente.valeTransporte(10000);
        Console.WriteLine("--------------");
        atendente.valeAlimentacao(5000);
        atendente.valeTransporte(5000);
    }
}