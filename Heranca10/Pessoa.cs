using System;

namespace Heranca10;

class Pessoa
{
    //Atributos
    protected int idade;
    protected string nome;

    //Método
    protected void MENSAGEM_PESSOA()
    {
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
    }
}
