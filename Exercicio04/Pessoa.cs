using System;

class Pessoa
{
    public double Peso;
    public double Altura;

    public double CALCULAR_IMC()
    {
        return (Peso / (Altura * Altura));
        
    }

    public string STATUS_SAUDE(double imc)
    {
        //double valorImc = CALCULAR_IMC();
        string message = "";

        switch (imc)
        {
            case < 18.5:
                message = "abaixo do peso";
                break;
            case < 23:
                message = "com o peso normal";
                break;
            case < 30:
                message = "acima do peso";
                break;
            case < 35:
                message = "com obesidade I";
                break;
            case < 40:
                message = "com obesidade II";
                break;
            case >= 40:
                message = "com obesidade III";
                break;
        }

        return message;
    }

    public void MOSTRAR_RESULTADO()
    {
        double obterIMC = CALCULAR_IMC();
        string statusSaude = STATUS_SAUDE(obterIMC);

        Console.WriteLine($"Seu imc é de {Math.Round(obterIMC)}.");
        Console.WriteLine($"Você está {statusSaude}");
    }
}