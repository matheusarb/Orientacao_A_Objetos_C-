using System;

class PessoaFisica : Padrao
{
    //Método obrigatório herdado de Padrao
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de empréstimo para Pessoa Física: R${valor * 0.1}");
    }
}