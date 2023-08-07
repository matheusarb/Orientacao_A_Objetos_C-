using System;
using Exercicio03;

class Program3
{
    static void Main(string[] args)
    {
        Aluno3 aluno1 = new Aluno3();
        aluno1.Nome = "Matheus";
        aluno1.Nota1 = 10;
        aluno1.Nota2 = 10;
        //double media = (nota1 + nota2) / 2;
        aluno1.MOSTRAR_MENSAGEM();
    }
}