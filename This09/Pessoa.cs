using System;

class Pessoa
{
    //Atributo
    public string nome = "Tatiana";

    //Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);

        nome = this.nome;
        //nome = nome.Substring(3);
        Console.WriteLine(nome);
    }
}