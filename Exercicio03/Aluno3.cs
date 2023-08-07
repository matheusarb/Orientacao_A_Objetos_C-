using System;

namespace Exercicio03;

class Aluno3
{
    public string? Nome;
    public double Nota1, Nota2;

    //Métodos
    //Média
    public double CALCULAR_MEDIA()
    {
        double result = (Nota1 + Nota2) / 2;
        return result;
    }

    //Situação
    public string ANALISAR_SITUACAO(double media)
    {
        media = (Nota1 + Nota2) / 2;
        
        return media >= 6 ? "aprovado" : "reprovado";
        
    }
    //Mensagem

    public void MOSTRAR_MENSAGEM()
    {
        double obterMedia = CALCULAR_MEDIA();
        string obterSituacao = ANALISAR_SITUACAO(obterMedia);

        Console.WriteLine(Nome + " está " + obterSituacao+" com média "+ obterMedia);
    }
}