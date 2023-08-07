using System;

class Aluno6
{
    private double Nota1, Nota2;

    private double CALCULAR_MEDIA()
    {
        return (Nota1+Nota2)/2;
    }

    public void MOSTRAR_MENSAGEM()
    {
        Console.WriteLine("digite sua primeira nota");
        Nota1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("digite sua segunda nota");
        Nota2 = Convert.ToInt32(Console.ReadLine());
    }

    public void MOSTRAR_NOTA()
    {
        Console.WriteLine($"A média é {CALCULAR_MEDIA()}");
    }
}