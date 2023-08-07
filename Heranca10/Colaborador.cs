using System;

namespace Heranca10;

class Colaborador : Pessoa
{
    //atributos
    private double salario;

    //método
    private void MENSAGEM_COLABORADOR()
    {
        Console.WriteLine("Salario: " + salario);
    }

    //Construtor
    public Colaborador(string nome, int idade,  double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        MENSAGEM_PESSOA();
        MENSAGEM_COLABORADOR();
    }
}