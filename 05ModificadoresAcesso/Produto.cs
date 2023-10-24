class Produto
{
    /*
         * public    -> Atibutos e Métodos visíveis em quaisquer classes 
         * private   -> '' e '' visíveis apenas na classe onde são criados
         * protected -> '' e ''    '' em classes onde são criados ou herdados
     */

    protected string? herdeiro;
    public string? Nome { get { return Nome; } set { Nome = value; } }
    private double Valor;
}