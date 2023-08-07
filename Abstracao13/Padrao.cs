using System;

abstract class Padrao
{
    // Classes abstratas criam um padrão para o projeto. Pode possuir métodos obrigatórios ou opcionais

    // 1. Método obrigatório
    // 1.1. Pode ser public ou protected
    public abstract void TaxaEmprestimo(double valor);


    // 2. Método opcional
    public void calculoPoupanca(double valorAplicado, double taxa)
    {
        Console.WriteLine($"Ganhos obtidos pela poupança: R${valorAplicado * taxa}.");
    }
}